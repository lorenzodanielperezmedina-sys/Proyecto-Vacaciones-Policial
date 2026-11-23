using System.Configuration;
using System.Data.SqlClient;

namespace Datos
{
    public static class Conexion
    {
        public static SqlConnection ObtenerConexion()
        {
            string cadena =
                ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;

            return new SqlConnection(cadena);
        }
    }
}