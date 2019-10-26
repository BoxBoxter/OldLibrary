using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaWindowsUi
{
    static class Program
    {
        static AuthorForm MyForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyForm = new AuthorForm();
            Application.Run(MyForm);
            //Application.Run(new Biblioteca());
        }
    }
}
