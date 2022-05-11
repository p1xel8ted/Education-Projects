/*
* Author: Ben Logan
* Student ID: 30013164
*/

using System;
using System.Windows.Forms;

namespace ABC_Management_Studio
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

#if DEBUG
            Application.Run(new FrmTask("Ben", "god"));
#else
            Application.Run(new FrmLogin());
#endif
        }
    }
}