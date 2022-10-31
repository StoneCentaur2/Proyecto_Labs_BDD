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
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Agg_Usuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.CargarUsuarios();
            if (sql.EncargadoAcceso("ing. en sistemas computacionales") == 1)
            {
                Propiedades.Carrera_Usua = "ing. en sistemas computacionales";
                dataGridView2.DataSource = sql.CargarInventario();
            }
            if (sql.EncargadoAcceso("ing. civil") == 1)
            {
                Propiedades.Carrera_Usua = "ing. civil";
                dataGridView2.DataSource = sql.CargarInventario();
            }
            if (sql.EncargadoAcceso("ing. industrial") == 1)
            {
                Propiedades.Carrera_Usua = "ing. industrial";
                dataGridView2.DataSource = sql.CargarInventario();
            }
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
    }
}
