using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSorter
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
            try
            {
                Application.Run(new StartupScreen());
            }
            catch(Exception e)
            {
                MessageBox.Show(string.Format("{0} failed to Start. Due to {1}.", Application.ProductName,e.Message) );
            }
        }
    }
}
