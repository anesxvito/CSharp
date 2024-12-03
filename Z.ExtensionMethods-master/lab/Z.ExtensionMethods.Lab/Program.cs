| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.Windows.Forms;

namespace Z.ExtensionMethods.Lab
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
            Application.Run(new Form1());
        }
    }
}