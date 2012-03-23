using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SDepends
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] _args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm mainForm = new MainForm();
            if (_args.Length > 0)
            {
                mainForm.Open(_args[_args.Length - 1]);
            }
            Application.Run(mainForm);
        }
    }
}
