using Org.BouncyCastle.Asn1.X500;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Labs_BDD
{
    public partial class Solicitud : Form
    {
        SQL sql = new SQL();
        public Solicitud()
        {
            InitializeComponent();
            if (sql.BuscarEncargado(Propiedades.ID_Usuario,1) == 1)
            {
                btn_agg_Usuario.Visible = true;
                Propiedades.Encargado = 1;
            }
            else
            {
                Propiedades.Encargado = 0;
            }
            if (sql.EncargadoAcceso("ing. en sistemas computacionales") == 1)
            {
                Propiedades.Carrera_Usua = "ing. en sistemas computacionales";
                cmbx_Docente.Items.Add("José María Gerónimo Pérez");
                cmbx_Docente.Items.Add("Diana Elizabeth López Chacon");
                cmbx_Docente.Items.Add(sql.Teachers());
            }
            if (sql.EncargadoAcceso("ing. civil") == 1)
            {
                Propiedades.Carrera_Usua = "ing. civil";
                cmbx_Docente.Items.Add("Daniel Escalante Jiménez");
                cmbx_Docente.Items.Add("Everardo Flores Ortiz");
                cmbx_Docente.Items.Add(sql.Teachers());
            }
            if (sql.EncargadoAcceso("ing. industrial") == 1)
            {
                Propiedades.Carrera_Usua = "ing. industrial";
                cmbx_Docente.Items.Add("Jezaharel Rocio Ibarra"); 
                cmbx_Docente.Items.Add("Jorge Ibarra Soto");
                cmbx_Docente.Items.Add(sql.Teachers());
            }
            Propiedades.Time = dateTimePicker1.Value;
            sql.NameUsu(Propiedades.ID_Usuario);
            Login login = new Login();
            login.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btn_agg_Usuario_Click(object sender, EventArgs e)
        {
            Agg_Usuarios agg = new Agg_Usuarios();
            agg.Show();
            this.Close();
        }

        private void Solicitud_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.CargarInventario();//Se carga el query realizado en SQL en el datagridviewif (sql.EncargadoAcceso("ing. en sistemas computacionales",Propiedades.Encargado) == 1)
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            tbx_Solicitud.Text = "";
            cmbx_Docente.Text = "";
        }

        private void btn_Agg_Click(object sender, EventArgs e)
        {
            sql.IDherramienta(tbx_Solicitud.Text);
            MessageBox.Show(sql.Solicitudes(tbx_Solicitud.Text, cmbx_Docente.Text));
            dataGridView1.DataSource = sql.CargarInventario();
        }
    }
}
