using ICSharpCode.TextEditor.Document;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EPocalipse.Json.JsonView
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //自定义代码高亮
            string path = Application.StartupPath + "\\highlighting";
            FileSyntaxModeProvider fsmp;
            fsmp = new FileSyntaxModeProvider(path);
            HighlightingManager.Manager.AddSyntaxModeFileProvider(fsmp);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}