using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Labs_BDD
{
    public partial class Login : Form
    {
        SQL sql = new SQL();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            if (tBx_Usuario.Text == "" || tBx_Contraseña.Text == "")
            {
                MessageBox.Show("Rellene de forma correcta los campos");
            }
            else if (sql.BuscarUsuarioSesión(Convert.ToInt32(tBx_Usuario.Text)) == 1 && sql.BuscarContraseña(tBx_Contraseña.Text) == 1)
            {
                Propiedades.ID_Usuario = Convert.ToInt32(tBx_Usuario.Text);
                MessageBox.Show("¡Bienvendi@!");
                Form form = new Solicitud();
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
