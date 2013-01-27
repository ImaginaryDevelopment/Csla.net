using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Csla;

namespace WinFormsUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //higher performance
            Csla.ApplicationContext.PropertyChangedMode = Csla.ApplicationContext.PropertyChangedModes.Windows;
            Application.Run(new Form1());
        }
    }
}
