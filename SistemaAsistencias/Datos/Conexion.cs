using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemaAsistencias.Logica;

namespace SistemaAsistencias.Datos
{
    public class Conexion
    {
        public static string cadenaConexion = "";
        public static SqlConnection conexion = new SqlConnection(cadenaConexion);

        public static void abriConexion()
        {
            if(conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        
    }
}
