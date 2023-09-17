using ERS_NeoCare.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERS_NeoCare
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Crea una instancia del formulario de inicio de sesión y lo muestra.
            Login loginForm = new Login();
            Application.Run(loginForm);
        }
    }
}
