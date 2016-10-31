using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactBookApp.View_Layer;
using ContactBookApp.Presenter_Layer;
using ContactBookApp.Model_Layer;

namespace ContactBookApp
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
            Model dataService = new Model();

            Application.Run(new MainView(dataService));
        }
    }
}
