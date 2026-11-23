using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class ConexionPrueba
    {
        [TestMethod]
        public void DebeConectarYConsultarVacacionesPolicia()
        {
            string cadena = ConfigurationManager.ConnectionStrings["CadenaConexion"]?.ConnectionString;
            Assert.IsFalse(string.IsNullOrWhiteSpace(cadena), "No se encontró CadenaConexion.");

            using (var conexion = new SqlConnection(cadena))
            using (var comando = new SqlCommand("SELECT COUNT(*) FROM Rol;", conexion))
            {
                conexion.Open();
                Assert.AreEqual(ConnectionState.Open, conexion.State);

                int cantidadRoles = (int)comando.ExecuteScalar();
                Assert.IsTrue(cantidadRoles > 0, "La tabla Rol no devolvió registros.");
            }
        }
    }
}