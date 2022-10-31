using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Labs_BDD
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
            
            Login login = new Login();
            login.FormClosed += Login_FormClosed;
            login.Show();
            Application.Run();
        }
        private static void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= Login_FormClosed;
            if(Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed -= Login_FormClosed;
            }
        }
    }
}
