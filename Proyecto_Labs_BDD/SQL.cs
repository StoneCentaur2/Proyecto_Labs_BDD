using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X500;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
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

        public int BuscarUsuarioSesión (int Usuario, string Contraseña)//Busqueda para verificar
        {
            int contrador = 0;
            try {
                cmd = new MySqlCommand("SELECT * FROM usuarios where ID = " + Usuario + " and Contraseña = '"+ Contraseña +"';", cn);
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
        public string NameUsu (int ID)
        {
            string contador;
            try {
                cmd = new MySqlCommand("select substring_index(Nombre, ',', "+ID+") from usuarios where ID = "+ID+";", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    Propiedades.Nombre_Usuario = dr.GetString(0);
                }
                dr.Close();
                contador = Propiedades.Nombre_Usuario;
            }
            catch (Exception ex) { MessageBox.Show(contador ="Error con la consulta"+ " \n Tipo: " + ex.ToString()); }
            return contador;
        }
        public string Teachers()
        {
            string contador;
            try
            {
                    cmd = new MySqlCommand("select substring_index(Nombre, ',', 1) from usuarios where Docente = 1 and Carrera = '"+Propiedades.Carrera_Usua+"';", cn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                    Propiedades.Teacher_Usua1 = dr.GetString(0);
                }
                    dr.Close();
                contador = Propiedades.Teacher_Usua1;
            }
            catch (Exception ex) { MessageBox.Show(contador = "Error con la consulta Teachers" + " \n Tipo: " + ex.ToString()); }
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
                string query = "select * from herramienta where Carrera = '"+Propiedades.Carrera_Usua+"';";
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
                string query = "select * from usuarios where Carrera = '"+Propiedades.Carrera_Usua+"';";
                MySqlDataAdapter CH = new MySqlDataAdapter(query, cn);//Realiza el query y abre la conexión
                DataTable dt = new DataTable();//llama la instancia de DataTable para el uso de tablas
                CH.Fill(dt);//archiva el contenido del query en la variable que pueda contener todo el query
                return dt;//Devuelve el contenido del query para que sea usado en un datawridview
            }
            catch (Exception ex) { MessageBox.Show("No se pudo cargar la tabla. \n Tipo: " + ex.ToString()); throw; }
        }
        public int Verificacion(string Carrera)
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
        public string Solicitudes(string Herramienta, string Docente)
        {
            string Mss = "Elemento solicitado correctamente";
            try
            {
                cmd = new MySqlCommand("UPDATE inventario SET Cantidad = (Cantidad - 1) WHERE ID = "+Propiedades.IDHerramientas+ " and Laboratorio = '"+Propiedades.Carrera_Usua+"';", cn);
                cmd.ExecuteNonQuery();
                try
                {
                    cmd = new MySqlCommand("insert into herramienta values(0, '" + Herramienta + "', '" + Propiedades.Nombre_Usuario + "', '" + Docente + "', '" + Propiedades.Time + "', '" + Propiedades.Carrera_Usua + "');", cn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { Mss = "Error de ingreso, \n Tipo: " + ex.ToString(); throw; }
            }
            catch (Exception ex) { Mss = "Error de al modificar inventario, \n Tipo: " + ex.ToString(); throw; }
            return Mss;
        }
        public int IDherramienta(string ID,string Herramienta)//Selecciona la celda de la herramienta a buscar
        {
            int contador;
            try
            {
                cmd = new MySqlCommand("select substring_index(ID, ',', 2) from inventario where " +
                    ""+ID+" = '"+Herramienta+ "' and Laboratorio = '" + Propiedades.Carrera_Usua+"';", cn);//Busca exactamente una celda ahora busca el ID
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Propiedades.IDHerramientas = dr.GetInt32(0);
                }
                dr.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error con la consulta Herramientas" + " \n Tipo: " + ex.ToString()); }
            return contador = Propiedades.IDHerramientas;
        }
        public string AddUsers(int ID, string Passwrd, string Name, int Encargado, int Teacher)
        {
            string Mss = "Se ingreso el nuevo usuario";
            try
            { 
                cmd = new MySqlCommand("insert into usuarios values("+ID+", '"+Passwrd+"', '"+ Propiedades.Carrera_Usua + "', '"+Name+"', "+Encargado+", "+Teacher+");",cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex){ MessageBox.Show("Error al agregar usuario  \n Tipo: " + ex.ToString()); throw; }
            return Mss;
        }
        public string ModUsers(int ID, string Mod, string LugarMod)
        {
            string Mss = "Se modifico correctamente";
            try
            {
                cmd = new MySqlCommand("UPDATE usuarios SET "+LugarMod+" = '"+Mod+"' WHERE ID = " + ID + ";", cn);//Actualiza especificamente un lugar
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { Mss = "Error de al modificar Usuario, \n Tipo: " + ex.ToString(); throw; }
            return Mss;
        }
        public string DeleteUser(int ID)
        {
            string Mss = "Se elimino correctamente";
            try
            {
                cmd = new MySqlCommand("delete from usuarios WHERE ID = " + ID + " and Carrera = '"+Propiedades.Carrera_Usua+"';", cn);//eliminación por busqueda
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { Mss = "Error de al eliminar. \n Tipo: " + ex.ToString(); throw; }
            return Mss;
        }
        public DataTable SearchUsers(string ID, string Search)
        {
            try
            {
                cmd = new MySqlCommand("select * from usuarios WHERE "+Search+" = '" + ID + "' and Carrera = '"+ Propiedades.Carrera_Usua+"';", cn);//Actualiza especificamente un lugar
                MySqlDataAdapter ch = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ch.Fill(dt);
                return dt;
            }
            catch (Exception ex) {MessageBox.Show("Error de al buscar el usuario, \n Tipo: " + ex.ToString()); throw; }
        }
        public DataTable SearchPrestamo(string ID, string Search)
        {
            try
            {
                cmd = new MySqlCommand("select * from herramienta WHERE " + Search + " = '" + ID + "' and Carrera = '" + Propiedades.Carrera_Usua + "';", cn);//Actualiza especificamente un lugar
                MySqlDataAdapter ch = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ch.Fill(dt);
                return dt;
            }
            catch (Exception ex) { MessageBox.Show("Error de al buscar el prestamo, \n Tipo: " + ex.ToString()); throw; }
        }
        public string DeletePrestamo(string IDPresTable,string IDPresDate)
        {
            string Mss = "Se solicito";
            try
            {
                cmd = new MySqlCommand("UPDATE inventario SET Cantidad = (Cantidad + 1) WHERE ID = '" + Propiedades.IDHerramientas
                    + "' and Laboratorio = '" + Propiedades.Carrera_Usua+"';", cn);
                cmd.ExecuteNonQuery();
                try
                {
                    cmd = new MySqlCommand("delete from herramienta where " + IDPresTable + " = '" + IDPresDate + "' and Carrera = '" + Propiedades.Carrera_Usua + "';", cn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { Mss = "Error de ingreso, \n Tipo: " + ex.ToString(); throw; }
            }
            catch (Exception ex) { Mss = "Error de al modificar inventario, \n Tipo: " + ex.ToString(); throw; }
            return Mss;
        }
        public string DeletePresForName(string IDPresTable, string IDPresDate,string columnHerra, string ID)
        {
            string Mss = "Se elimino correctamente";
            try
            {
                cmd = new MySqlCommand("UPDATE inventario SET Cantidad = (Cantidad + 1) WHERE ID = '" + Propiedades.IDHerramientas
                    + "' and Laboratorio = '" + Propiedades.Carrera_Usua + "';", cn);
                cmd.ExecuteNonQuery();
                try
                {
                    cmd = new MySqlCommand("delete from herramienta where " + IDPresTable + " = '" + IDPresDate + "' and "+columnHerra+" = '"+ID+"'" +
                        " and Carrera = '" + Propiedades.Carrera_Usua + "';", cn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { Mss = "Error de ingreso, \n Tipo: " + ex.ToString(); throw; }
            }
            catch (Exception ex) { Mss = "Error de al modificar inventario, \n Tipo: " + ex.ToString(); throw; }
            return Mss;
        }
        public DataTable SearchInvent(string ID, string column)
        {
            try
            {
                cmd = new MySqlCommand("select * from inventario where "+column+" = '"+ID+"' and Laboratorio = '"+Propiedades.Carrera_Usua+"';",cn);
                MySqlDataAdapter ch = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ch.Fill(dt);
                return dt;
            }
            catch (Exception ex){ MessageBox.Show("Error en la busqueda en inventario \n Tipo: " + ex.ToString()); throw; }
        }
        public string AddInvent(string Descripcion, int Cantidad, string Marca, string Modelo,string Serie)
        {
            string Mss = "Se elimino correctamente";
            try
            {
                cmd = new MySqlCommand("insert into inventario values(0, '"+Descripcion+"',"+Cantidad+",'"+Marca+"','"+Modelo+"','"+Serie+"', '" + Propiedades.Carrera_Usua + "';", cn);//eliminación por busqueda
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { Mss = "Error de al eliminar. \n Tipo: " + ex.ToString(); throw; }
            return Mss;
        }
    }
}
