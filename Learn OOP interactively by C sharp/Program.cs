using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_OOP_interactively_by_C_sharp
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
            //Application.Run(new Form_OOP());
            //For fast testing
            //Application.Run(new Form_of_set_and_get());
            Application.Run(new Form_of_set_and_get("hello", "hello", "hello", "hello"));


        }
    }
}
