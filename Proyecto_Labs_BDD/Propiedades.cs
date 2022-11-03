using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Labs_BDD
{
    public static class Propiedades
    {
        public static int ID_Usuario { get; set; }
        public static string Carrera_Usua { get; set; }
        public static string Nombre_Usuario { get; set; }
        public static int Encargado { get; set; }
        //No referentes al usuario
        public static DateTime Time { get; set; }
        public static int IDHerramientas { get; set; }
        //Maestros de carrera
        public static string Teacher_Usua1 { get; set; }
        public static string Teacher_Usua2 { get; set; }
        public static string Teacher_Usua3 { get; set; }

    }
}
