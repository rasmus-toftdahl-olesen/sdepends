namespace SDepends
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.m_toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.m_tree = new System.Windows.Forms.TreeView();
            this.m_imageList = new System.Windows.Forms.ImageList(this.components);
            this.m_toolStrip = new System.Windows.Forms.ToolStrip();
            this.m_openButton = new System.Windows.Forms.ToolStripButton();
            this.m_excludeSystem = new System.Windows.Forms.ToolStripButton();
            this.m_toolStripContainer.ContentPanel.SuspendLayout();
            this.m_toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.m_toolStripContainer.SuspendLayout();
            this.m_toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_toolStripContainer
            // 
            // 
            // m_toolStripContainer.ContentPanel
            // 
            this.m_toolStripContainer.ContentPanel.Controls.Add(this.m_tree);
            this.m_toolStripContainer.ContentPanel.Size = new System.Drawing.Size(481, 398);
            this.m_toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.m_toolStripContainer.Name = "m_toolStripContainer";
            this.m_toolStripContainer.Size = new System.Drawing.Size(481, 423);
            this.m_toolStripContainer.TabIndex = 0;
            this.m_toolStripContainer.Text = "toolStripContainer1";
            // 
            // m_toolStripContainer.TopToolStripPanel
            // 
            this.m_toolStripContainer.TopToolStripPanel.Controls.Add(this.m_toolStrip);
            // 
            // m_tree
            // 
            this.m_tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_tree.HideSelection = false;
            this.m_tree.ImageIndex = 0;
            this.m_tree.ImageList = this.m_imageList;
            this.m_tree.Location = new System.Drawing.Point(0, 0);
            this.m_tree.Name = "m_tree";
            this.m_tree.SelectedImageIndex = 0;
            this.m_tree.Size = new System.Drawing.Size(481, 398);
            this.m_tree.TabIndex = 0;
            // 
            // m_imageList
            // 
            this.m_imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.m_imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.m_imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // m_toolStrip
            // 
            this.m_toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.m_toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_openButton,
            this.m_excludeSystem});
            this.m_toolStrip.Location = new System.Drawing.Point(3, 0);
            this.m_toolStrip.Name = "m_toolStrip";
            this.m_toolStrip.Size = new System.Drawing.Size(244, 25);
            this.m_toolStrip.TabIndex = 0;
            // 
            // m_openButton
            // 
            this.m_openButton.Image = global::SDepends.Properties.Resources.Assembly;
            this.m_openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_openButton.Name = "m_openButton";
            this.m_openButton.Size = new System.Drawing.Size(53, 22);
            this.m_openButton.Text = "Open";
            this.m_openButton.Click += new System.EventHandler(this.m_openButton_Click);
            // 
            // m_excludeSystem
            // 
            this.m_excludeSystem.Checked = true;
            this.m_excludeSystem.CheckOnClick = true;
            this.m_excludeSystem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_excludeSystem.Image = ((System.Drawing.Image)(resources.GetObject("m_excludeSystem.Image")));
            this.m_excludeSystem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_excludeSystem.Name = "m_excludeSystem";
            this.m_excludeSystem.Size = new System.Drawing.Size(150, 22);
            this.m_excludeSystem.Text = "Ignore system assemblies";
            this.m_excludeSystem.CheckedChanged += new System.EventHandler(this.m_excludeSystem_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 423);
            this.Controls.Add(this.m_toolStripContainer);
            this.Name = "MainForm";
            this.Text = "SDepends";
            this.m_toolStripContainer.ContentPanel.ResumeLayout(false);
            this.m_toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.m_toolStripContainer.TopToolStripPanel.PerformLayout();
            this.m_toolStripContainer.ResumeLayout(false);
            this.m_toolStripContainer.PerformLayout();
            this.m_toolStrip.ResumeLayout(false);
            this.m_toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer m_toolStripContainer;
        private System.Windows.Forms.ToolStrip m_toolStrip;
        private System.Windows.Forms.ToolStripButton m_openButton;
        private System.Windows.Forms.TreeView m_tree;
        private System.Windows.Forms.ImageList m_imageList;
        private System.Windows.Forms.ToolStripButton m_excludeSystem;

    }
}

