using System;
using Datos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PruebaDatos
    {
        [TestMethod]
        public void VerificarConexionYConsultasBasicas()
        {
            var rangoDal = new RangoDAL();
            var rolDal = new RolDAL();
            var usuarioDal = new UsuarioDAL();
            var ausenciaDal = new AusenciaDAL();

            var rangos = rangoDal.Listar();
            var roles = rolDal.Listar();
            var detalleUsuarios = usuarioDal.ListarDetalle();
            var ausentes = ausenciaDal.AusentesActuales();

            Assert.IsNotNull(rangos);
            Assert.IsNotNull(roles);
            Assert.IsNotNull(detalleUsuarios);
            Assert.IsNotNull(ausentes);
        }
    }
}