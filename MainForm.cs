using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace SDepends
{
    public partial class MainForm : Form
    {
        private string m_currentFile;
        
        public MainForm()
        {
            InitializeComponent();

            m_imageList.Images.Add("Assembly", Properties.Resources.Assembly);
            m_imageList.Images.Add("Info", Properties.Resources.Info);
            m_imageList.Images.Add("Resolved", Properties.Resources.Resolved);
            m_imageList.Images.Add("Unresolved", Properties.Resources.Unresolved);
        }

        public void Open(string _dllFilename)
        {
            m_tree.Nodes.Clear();
            m_currentFile = _dllFilename;
            TreeNode root = m_tree.Nodes.Add(_dllFilename);
            root.ImageKey = "Assembly";
            root.SelectedImageKey = "Assembly";
            Examine(root, _dllFilename);
            //m_tree.ExpandAll();
        }

        private void ExpandAllParents(TreeNode _node)
        {
            _node.Expand();
            if (_node.Parent != null)
            {
                ExpandAllParents(_node.Parent);
            }
        }
        
        private AssemblyName Examine(TreeNode _parent, string _dllFilename)
        {
            Assembly assembly = Assembly.ReflectionOnlyLoadFrom(_dllFilename);
            AssemblyName assemblyName = AssemblyName.GetAssemblyName(_dllFilename);
            AddAssemblyNameInfo(_parent, assemblyName);

            TreeNode references = AddNode(_parent, "Assembly", "References");
            foreach (AssemblyName info in assembly.GetReferencedAssemblies())
            {
                if (!m_excludeSystem.Checked || !(info.Name.StartsWith("System") || info.Name == "mscorlib"))
                {
                    TreeNode assemblyRoot = AddNode(references, "Unresolved", info.FullName);
                    string fullpath = Path.Combine(Path.GetDirectoryName(_dllFilename), info.Name + ".dll");
                    if (File.Exists(fullpath))
                    {
                        AddInfo(assemblyRoot, "FileName", fullpath);
                        AssemblyName foundAssemblyName = AssemblyName.GetAssemblyName(fullpath);
                        if (foundAssemblyName.FullName.Equals(info.FullName))
                        {
                            assemblyRoot.ImageKey = "Resolved";
                            assemblyRoot.SelectedImageKey = "Resolved";
                            AddInfo(assemblyRoot, "AssemblyName", "Matches");
                            Examine(assemblyRoot, fullpath);
                        }
                        else
                        {
                            AddInfo(assemblyRoot, "AssemblyName", "Does not match!");
                            ExpandAllParents(assemblyRoot);
                        }
                    }
                    else
                    {
                        AddInfo(assemblyRoot, "FileName", String.Format("Could not find file named {0}", fullpath));
                        ExpandAllParents(assemblyRoot);
                    }
                }
            }
            return assemblyName;
        }

        private void AddAssemblyNameInfo(TreeNode _parent, AssemblyName _name)
        {
            AddInfo(_parent, "FullName", _name.FullName);
            AddInfo(_parent, "ProcessorArchitecture", _name.ProcessorArchitecture);
            AddInfo(_parent, "Version", _name.Version);
            AddInfo(_parent, "VersionCompatibility", _name.VersionCompatibility);
        }

        private void AddInfo(TreeNode _parent, string _key, object _value)
        {
            AddNode(_parent, "Info", "{0} = {1}", _key, _value);
        }

        private TreeNode AddNode(TreeNode _parent, string _imageKey, string _textFormat, params object[] _textArgs)
        {
            TreeNode node = _parent.Nodes.Add(String.Format(_textFormat, _textArgs));
            node.ImageKey = _imageKey;
            node.SelectedImageKey = _imageKey;
            return node;
        }

        private void m_openButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = false;
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    Open(dialog.FileName);
                }
            }
        }

        private void m_excludeSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (m_currentFile != null)
            {
                Open(m_currentFile);
            }
        }
    }
}
