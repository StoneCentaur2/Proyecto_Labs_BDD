using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Labs_BDD
{
    public partial class Agg_Usuarios : Form
    {
        SQL sql = new SQL();
        public Agg_Usuarios()
        {
            InitializeComponent();
            cmb_DocentePres.Items.Add(Propiedades.Teacher_Usua2);
            cmb_DocentePres.Items.Add(Propiedades.Teacher_Usua3);
            cmb_DocentePres.Items.Add(Propiedades.Teacher_Usua1);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Agg_Usuarios_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = sql.CargarInventario();
            dataGridView1.DataSource = sql.CargarUsuarios();
            dataGridView3.DataSource = sql.CargarHerramientas();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            Solicitud form2 = new Solicitud();
            form2.Show();
            this.Close();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Login form2 = new Login();
            form2.Show();
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (tbx_Nom.Text != "" || tbx_ID.Text != "" || tbx_Contraseña.Text != "" || cmb_Docente.Text != "" || cmb_Encargado.Text != "")
            {
                sql.AddUsers(Convert.ToInt32(tbx_ID.Text), tbx_Contraseña.Text, tbx_Nom.Text, Convert.ToInt32(cmb_Encargado.Text), Convert.ToInt32(cmb_Docente.Text));
            }
            else
            {
                MessageBox.Show("Favor de rellenar todos los espacios para agregar");
            }
            cmb_Docente.Text = null;
            cmb_Encargado.Text = null;
            dataGridView1.DataSource = sql.CargarUsuarios();
            tbx_Nom.Text = "";
            tbx_ID.Text = "";
            tbx_Contraseña.Text = "";
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            tbx_Nom.Text = "";
            tbx_ID.Text = "";
            tbx_Contraseña.Text = "";
            cmb_Docente.Text = null;
            cmb_Encargado.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbx_ID.Text == "")//Busqueda por nombre
            {
                dataGridView1.DataSource = sql.SearchUsers(tbx_Nom.Text, "Nombre");
            }
            else if (tbx_Nom.Text == "")//Busqueda por ID
            {
                dataGridView1.DataSource = sql.SearchUsers(tbx_ID.Text, "ID");
            }
            else
            {
                MessageBox.Show("Rellene el campo por el cual desea buscar al usuario \n" +
                    "Ingrese en el campo ID o Por nombre");
            }
            tbx_Nom.Text = "";
            tbx_ID.Text = "";
            tbx_Contraseña.Text = "";
            cmb_Docente.Text = null;
            cmb_Encargado.Text = null;
            tbx_Contraseña.Text = "";
        }

        private void btn_ModUser_Click(object sender, EventArgs e)
        {
            //coamndo sql
            if (tbx_Nom.Text == "" && cmb_Encargado.Text == "" && cmb_Docente.Text == "")
            {
                if (tbx_ID.Text == "")
                {
                    MessageBox.Show("Ingrese el ID Para modificar al usuario");
                }
                else
                {
                    MessageBox.Show(sql.ModUsers(Convert.ToInt32(tbx_ID.Text), tbx_Contraseña.Text, "Contraseña"));
                    dataGridView1.DataSource = sql.CargarUsuarios();
                }
            }
            else if (tbx_Contraseña.Text == "" && cmb_Encargado.Text == "" && cmb_Docente.Text == "")
            {
                if (tbx_ID.Text == "")
                {
                    MessageBox.Show("Ingrese el ID Para modificar al usuario");
                }
                else
                {
                    MessageBox.Show(sql.ModUsers(Convert.ToInt32(tbx_ID.Text), tbx_Nom.Text, "Nombre"));
                    dataGridView1.DataSource = sql.CargarUsuarios();
                }
            }
            else if (tbx_Contraseña.Text == "" && tbx_Nom.Text == "" && cmb_Encargado.Text == "")
            {
                if (tbx_ID.Text == "")
                {
                    MessageBox.Show("Ingrese el ID Para modificar al usuario");
                }
                else
                {
                    MessageBox.Show(sql.ModUsers(Convert.ToInt32(tbx_ID.Text), cmb_Docente.Text, "Docente"));
                    dataGridView1.DataSource = sql.CargarUsuarios();
                }
            }
            else if (tbx_Contraseña.Text == "" && tbx_Nom.Text == "" && cmb_Docente.Text == "")
            {
                if (tbx_ID.Text == "")
                {
                    MessageBox.Show("Ingrese el ID Para modificar al usuario");
                }
                else
                {
                    MessageBox.Show(sql.ModUsers(Convert.ToInt32(tbx_ID.Text), cmb_Encargado.Text, "Encargado"));
                    dataGridView1.DataSource = sql.CargarUsuarios();
                }
            }
            else if (tbx_Nom.Text != "" && tbx_ID.Text != "" && tbx_Contraseña.Text != "" && cmb_Docente.Text != "" && cmb_Encargado.Text != "")
            {
                MessageBox.Show("Solo debe de colocar el ID y lo que desea modificar");
            }
            else
            {
                MessageBox.Show("No se ingreso correctamente para modificar");
            }
            //Borrado de contenido
            tbx_Nom.Text = "";
            tbx_ID.Text = "";
            tbx_Contraseña.Text = "";
            cmb_Docente.Text = null;
            cmb_Encargado.Text = null;
        }

        private void btn_EliminateUser_Click(object sender, EventArgs e)
        {
            if(tbx_ID.Text != "")
            {
                sql.DeleteUser(Convert.ToInt32(tbx_ID.Text));
                dataGridView1.DataSource = sql.CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Necesita rellenar el ID para poder eliminar");
            }
            //Para dejar en blanco despues del comando
            tbx_ID.Text = ""; tbx_Nom.Text = "";
            tbx_Contraseña.Text = "";
            cmb_Docente.Text = null;
            cmb_Encargado.Text = null;
        }
    }
}
