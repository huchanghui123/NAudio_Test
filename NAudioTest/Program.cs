using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NAudioTest
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm main = new MainForm();
            main.FormClosed += delegate (Object sender, FormClosedEventArgs e) {
                Application.Exit();
            };
            Application.Run(main);
        }
    }
}
