using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X500;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Labs_BDD
{
    class SQL
    {
        //Tipo de usuario, se asigna en Login
        public string user = "";
        readonly MySqlConnection cn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataAdapter ad;
        //Conexion SQL
        public SQL()
        {
            try
            {
                //Ingresar informacion de la base de datos
                cn = new MySqlConnection("server= 127.0.0.1; port= 3306; user id= root; password= RousLee; database= Laboratorio;");
                cn.Open();
            }
            catch (Exception x)
            {
                MessageBox.Show("Conexion Fallida \n" + x.ToString());
            }
        }

        public int BuscarUsuarioSesión (int Usuario)//Busqueda de usuario
        {
            int contrador = 0;
            try {
                cmd = new MySqlCommand("SELECT * FROM usuarios where ID = " + Usuario + ";", cn);
                dr = cmd.ExecuteReader();//Para que la variable realice la busqueda se agrega en una variable
                while (dr.Read())//Esta varible lee hasta que encuentre más de 1 coincidencia
                    {
                    contrador++;//Contará todas las coincidencias
                    }//while
                dr.Close();//se usa la variable dr para cerrar la conexión que abrimos con la variable cmd
                }//Try
            catch (Exception ex) { MessageBox.Show("Error con el usuario \n Tipo: " + ex.ToString()); }//catch por cualquier error con la base de datos
            return contrador;//devuelde la cantidad de coincidencias que encuentre
        }
        public int BuscarContraseña (string Constraseña)
        {
            int contador = 0;
            try {
                cmd = new MySqlCommand("SELECT * FROM usuarios where Contraseña = '" + Constraseña + "';", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error con la contraseña \n Tipo: " + ex.ToString()); }
            return contador;
        }
        public int BuscarEncargado(int Usuario, int Encargado)
        {
            int contador = 0;
            try
            {
                cmd = new MySqlCommand("SELECT * FROM usuarios where ID = " + Usuario + " and Encargado = "+ Encargado +";", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error con la busqueda \n Tipo: " + ex.ToString()); }
            return contador;
        }
        public DataTable CargarHerramientas()//metodo para cargar las tablas de las herramientas en un datawridview
        {
            try
            {
                string query = "select * from herramienta;";
                MySqlDataAdapter CH = new MySqlDataAdapter(query, cn);//Realiza el query y abre la conexión
                DataTable dt = new DataTable();//llama la instancia de DataTable para el uso de tablas
                CH.Fill(dt);//archiva el contenido del query en la variable que pueda contener todo el query
                return dt;//Devuelve el contenido del query para que sea usado en un datawridview
            }
            catch (Exception ex) { MessageBox.Show("No se pudo cargar la tabla. \n Tipo: " + ex.ToString()); throw; } 
        }
        public DataTable CargarUsuarios()//metodo para cargar las tablas de las herramientas en un datawridview
        {
            try
            {
                string query = "select * from usuarios;";
                MySqlDataAdapter CH = new MySqlDataAdapter(query, cn);//Realiza el query y abre la conexión
                DataTable dt = new DataTable();//llama la instancia de DataTable para el uso de tablas
                CH.Fill(dt);//archiva el contenido del query en la variable que pueda contener todo el query
                return dt;//Devuelve el contenido del query para que sea usado en un datawridview
            }
            catch (Exception ex) { MessageBox.Show("No se pudo cargar la tabla. \n Tipo: " + ex.ToString()); throw; }
        }
        public int EncargadoAcceso(string Carrera)
        {
            int contador = 0;
            try
            {
                cmd = new MySqlCommand("select * from usuarios where Carrera = '"+Carrera+"' and ID = "+Propiedades.ID_Usuario+";", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();//Todo esto realiza un recorrido int (numerico) para saber cuantas veces da de resultado
            }
            catch (Exception ex) { MessageBox.Show("Error con la busqueda \n Tipo: " + ex.ToString()); }
            return contador;
        }

        public DataTable CargarInventario()//metodo para cargar las tablas de las herramientas en un datawridview
        {
            try
            {
                string query = "SELECT * FROM inventario where Laboratorio = '"+ Propiedades.Carrera_Usua +"';";
                MySqlDataAdapter CH = new MySqlDataAdapter(query, cn);//Realiza el query y abre la conexión
                DataTable dt = new DataTable();//llama la instancia de DataTable para el uso de tablas
                CH.Fill(dt);//archiva el contenido del query en la variable que pueda contener todo el query
                return dt;//Devuelve el contenido del query para que sea usado en un datawridview
            }
            catch (Exception ex) { MessageBox.Show("No se pudo cargar la tabla. \n Tipo: " + ex.ToString()); throw; }
        }
        public string Solicitudes(int ID, string Herramienta, string Nombre, string Docente, string Fecha)
        {
            string Mensaje = "Se ingreso correctamente";
            try
            {
                cmd = new MySqlCommand("insert into herramienta values("+ID+", '"+Herramienta+"', '"+Nombre+"', '"+Docente+"', '"+Fecha+"');",cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex){ Mensaje = "Error de ingreso, \n Tipo: " + ex.ToString(); throw; }
            return Mensaje;
        }
    }
}
