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
            this.CenterToScreen();
            cmb_DocentePres.Items.Add(Propiedades.Teacher_Usua2);
            cmb_DocentePres.Items.Add(Propiedades.Teacher_Usua3);
            cmb_DocentePres.Items.Add(Propiedades.Teacher_Usua1);
        }
        private void LoadandClear() //Metodo para cargar tablas y limpiar contenido
        {
            //Page 1
            tbx_Nom.Text = "";
            tbx_ID.Text = "";
            tbx_Contraseña.Text = "";
            cmb_Docente.Text = null;
            cmb_Encargado.Text = null;
            //Page 2
            tbx_DescrPres.Text = "";
            tbx_IDPres.Text = "";
            tbx_NamePres.Text = "";
            cmb_DocentePres.Text = null;
            //Page 3
            tbx_CantInvent.Text = "";
            tbx_HerraInvent.Text = "";
            tbx_MarcaInvent.Text = "";
            tbx_ModeloInvent.Text = "";
            tbx_SerieInvent.Text = "";
            
            dgvInventario.DataSource = sql.CargarInventario();
            dgvUsuarios.DataSource = sql.CargarUsuarios();
            dgvPrestamos.DataSource = sql.CargarHerramientas();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Agg_Usuarios_Load(object sender, EventArgs e)
        {
            LoadandClear();
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
            LoadandClear();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbx_ID.Text == "")//Busqueda por nombre
            {
                dgvUsuarios.DataSource = sql.SearchUsers(tbx_Nom.Text, "Nombre");
            }
            else if (tbx_Nom.Text == "")//Busqueda por ID
            {
                dgvUsuarios.DataSource = sql.SearchUsers(tbx_ID.Text, "ID");
            }
            else
            {
                MessageBox.Show("Rellene el campo por el cual desea buscar al usuario \n" +
                    "Ingrese en el campo ID o Por nombre");
            }
            LoadandClear();
        }

        private void btn_ModUser_Click(object sender, EventArgs e)
        {
            //coamndo sql, comparaciones para el poder modificar dependiendo que este rellenado
            if (tbx_Nom.Text == "" && cmb_Encargado.Text == "" && cmb_Docente.Text == "")
            {
                if (tbx_ID.Text == "")
                {
                    MessageBox.Show("Ingrese el ID Para modificar al usuario");
                }
                else
                {
                    MessageBox.Show(sql.ModUsers(Convert.ToInt32(tbx_ID.Text), tbx_Contraseña.Text, "Contraseña"));
                    dgvUsuarios.DataSource = sql.CargarUsuarios();
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
                    dgvUsuarios.DataSource = sql.CargarUsuarios();
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
                    dgvUsuarios.DataSource = sql.CargarUsuarios();
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
                    dgvUsuarios.DataSource = sql.CargarUsuarios();
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
            LoadandClear();
        }

        private void btn_EliminateUser_Click(object sender, EventArgs e)
        {
            if(tbx_ID.Text != "")
            {
                sql.DeleteUser(Convert.ToInt32(tbx_ID.Text));
                dgvUsuarios.DataSource = sql.CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Necesita rellenar el ID para poder eliminar");
            }
            LoadandClear();
        }

        private void btn_SearchPrestamo_Click(object sender, EventArgs e)
        {
            if (tbx_IDPres.Text != "" && tbx_DescrPres.Text == "" && cmb_DocentePres.Text == "" && tbx_NamePres.Text == "")
            {
              dgvPrestamos.DataSource = sql.SearchPrestamo(tbx_IDPres.Text, "ID");
            }
            else if(tbx_NamePres.Text != "" && tbx_DescrPres.Text == "" && cmb_DocentePres.Text == "" && tbx_IDPres.Text == "")
            {
                dgvPrestamos.DataSource = sql.SearchPrestamo(tbx_NamePres.Text, "Nombre");
            }
            else if (tbx_DescrPres.Text != "" && tbx_NamePres.Text == "" && cmb_DocentePres.Text == "" && tbx_IDPres.Text == "")
            {
                dgvPrestamos.DataSource = sql.SearchPrestamo(tbx_DescrPres.Text, "Herramienta");
            }
            else if (cmb_DocentePres.Text != "" && tbx_DescrPres.Text == "" && tbx_NamePres.Text == "" && tbx_IDPres.Text == "")
            {
                dgvPrestamos.DataSource = sql.SearchPrestamo(cmb_DocentePres.Text, "Docente");
            }
            else
            {
                MessageBox.Show("Rellenar solo el espacio por el cual desea buscar");
            }
            //Para que no limpie sin ver el resultado
            tbx_DescrPres.Text = "";
            tbx_IDPres.Text = "";
            tbx_NamePres.Text = "";
            cmb_DocentePres.Text = null;
        }

        private void btn_Devuelto_Click(object sender, EventArgs e)
        {
            if (tbx_IDPres.Text != "" && tbx_DescrPres.Text == "" && cmb_DocentePres.Text == "" && tbx_NamePres.Text == "")
            {
                sql.IDherramienta("ID", tbx_IDPres.Text);//Devolución por solo ID
                 sql.DeletePrestamo("ID", tbx_IDPres.Text);
            }
            else if (tbx_NamePres.Text != "" && cmb_DocentePres.Text == "")
            {
                if (tbx_IDPres.Text != "")
                {
                    sql.IDherramienta("ID", tbx_IDPres.Text);// Devolución por ID y Nombre del solicitante
                     sql.DeletePresForName("ID", tbx_IDPres.Text,"Nombre", tbx_NamePres.Text);
                }
                else if(tbx_DescrPres.Text != "")
                {
                    sql.IDherramienta("Descripcion", tbx_DescrPres.Text);// Devolución por descripción y nombre del solicitante
                     sql.DeletePresForName("Herramienta", tbx_DescrPres.Text,"Nombre", tbx_NamePres.Text);
                }
                else { // Mensaje por solo colocar el nombre 
                    MessageBox.Show("No es posible devolver tu articulo con solo nombre \n Necesita ingresar el ID o Nombre del articulo");
                } 
            }
            else if (tbx_DescrPres.Text != "" && tbx_NamePres.Text == "" && cmb_DocentePres.Text == "" && tbx_IDPres.Text == "")
            {
                sql.IDherramienta("Descripcion", tbx_DescrPres.Text); // Devolución por solo Descripción
                 sql.DeletePrestamo("Herramienta", tbx_DescrPres.Text);
            }
            else if (cmb_DocentePres.Text != "" && tbx_NamePres.Text == "")
            {
                if (tbx_IDPres.Text != "")
                {
                    sql.IDherramienta("ID", tbx_IDPres.Text); // Devolución por ID y docente encargado
                     sql.DeletePresForName("ID", tbx_IDPres.Text,"Docente", cmb_DocentePres.Text);
                }
                else if (tbx_DescrPres.Text != "")
                {
                    sql.IDherramienta("Descripcion", tbx_DescrPres.Text); // Devolución por Descripción y docente encargado
                     sql.DeletePresForName("Herramienta", tbx_DescrPres.Text, "Docente", cmb_DocentePres.Text);
                }
                else // Mensaje de que debe rellenar más que solo el docente
                {
                    MessageBox.Show("No es posible devolver tu articulo con solo el docente \n Necesita ingresar el ID o Nombre del articulo");
                }
            }
            else // Mensaje de que no relleno nada
            {
                MessageBox.Show("Rellenar correctamente los espacios");
            }
            //Volver a cargar las tablas y limpiar espacios
            LoadandClear();
        }

        private void btn_ClearInvent_Click(object sender, EventArgs e)
        {
            LoadandClear();
        }

        private void btn_Inven_Click(object sender, EventArgs e)
        {
            //Busqueda sql
            if (tbx_HerraInvent.Text != "")
            {
                sql.SearchInvent(tbx_HerraInvent.Text, "Descripcion");
            }
            else if (tbx_ModeloInvent.Text != "")
            {
                sql.SearchInvent(tbx_ModeloInvent.Text, "Modelo");
            }
            else if (tbx_MarcaInvent.Text != "")
            {
                sql.SearchInvent(tbx_MarcaInvent.Text, "Marca");
            }
            else if (tbx_SerieInvent.Text != "")
            {
                sql.SearchInvent(tbx_SerieInvent.Text, "Serie");
            }
            else
            {
                MessageBox.Show("Tiene que rellenar el campo que desee buscar");
            }
            LoadandClear();
        }

        private void btn_AggInvent_Click(object sender, EventArgs e)
        {
            if(tbx_CantInvent.Text != "" && tbx_ModeloInvent.Text != "" && tbx_SerieInvent.Text != "" && tbx_HerraInvent.Text != "")
            { sql.AddInvent(tbx_HerraInvent.Text, Convert.ToInt32(tbx_CantInvent.Text), tbx_MarcaInvent.Text, tbx_ModeloInvent.Text, tbx_SerieInvent.Text); }
            else
            {
                MessageBox.Show("Rellenar correctamente los espacios");
            }
            LoadandClear();
        }

        private void btn_deleteInvent_Click(object sender, EventArgs e)
        {
            if (tbx_CantInvent.Text != "" && tbx_ModeloInvent.Text != "" && tbx_SerieInvent.Text != "" && tbx_HerraInvent.Text != "")
            {
                MessageBox.Show("Solo se rellena los campos de herramienta y serie");
            }
            else if (tbx_SerieInvent.Text != "" && tbx_HerraInvent.Text != "")
            {
                sql.IDherramienta("Descripcion", tbx_HerraInvent.Text);
                sql.DeleteInvent(tbx_HerraInvent.Text, tbx_SerieInvent.Text);
            }
            else
            {
                MessageBox.Show("Rellenar correctamente los espacios");
            }
        }

        private void btn_ModInvent_Click(object sender, EventArgs e)
        {

        }
    }
}
