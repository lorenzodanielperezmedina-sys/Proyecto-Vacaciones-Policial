using ENTIDADESS;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class AusenciaDAL : RepositorioBase<Ausencia>
    {
        protected override string Tabla { get { return "Ausencia"; } }
        protected override string ColumnaId { get { return "IdAusencia"; } }

        protected override string SqlInsertar
        {
            get
            {
                return @"INSERT INTO Ausencia (IdSolicitud, FechaInicioReal, FechaReincorporacionPrevista, FechaReincorporacionReal)
                         VALUES (@IdSolicitud, @FechaInicioReal, @FechaReincorporacionPrevista, @FechaReincorporacionReal);
                         SELECT SCOPE_IDENTITY();";
            }
        }

        protected override string SqlActualizar
        {
            get
            {
                return @"UPDATE Ausencia
                         SET IdSolicitud = @IdSolicitud,
                             FechaInicioReal = @FechaInicioReal,
                             FechaReincorporacionPrevista = @FechaReincorporacionPrevista,
                             FechaReincorporacionReal = @FechaReincorporacionReal
                         WHERE IdAusencia = @Id";
            }
        }

        protected override Ausencia Mapear(SqlDataReader dr)
        {
            return new Ausencia
            {
                IdAusencia = (int)dr["IdAusencia"],
                IdSolicitud = (int)dr["IdSolicitud"],
                FechaInicioReal = dr["FechaInicioReal"] == DBNull.Value ? (DateTime?)null : (DateTime)dr["FechaInicioReal"],
                FechaReincorporacionPrevista = (DateTime)dr["FechaReincorporacionPrevista"],
                FechaReincorporacionReal = dr["FechaReincorporacionReal"] == DBNull.Value ? (DateTime?)null : (DateTime)dr["FechaReincorporacionReal"]
            };
        }

        protected override void CargarParametros(SqlCommand cmd, Ausencia entidad, bool esActualizacion)
        {
            cmd.Parameters.Add("@IdSolicitud", SqlDbType.Int).Value = entidad.IdSolicitud;
            cmd.Parameters.Add("@FechaInicioReal", SqlDbType.Date).Value = entidad.FechaInicioReal.HasValue ? (object)entidad.FechaInicioReal.Value.Date : DBNull.Value;
            cmd.Parameters.Add("@FechaReincorporacionPrevista", SqlDbType.Date).Value = entidad.FechaReincorporacionPrevista.Date;
            cmd.Parameters.Add("@FechaReincorporacionReal", SqlDbType.Date).Value = entidad.FechaReincorporacionReal.HasValue ? (object)entidad.FechaReincorporacionReal.Value.Date : DBNull.Value;

            if (esActualizacion)
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = entidad.IdAusencia;
        }

        public DataTable AusentesActuales()
        {
            DataTable tabla = new DataTable();
            SqlConnection cn = null;
            try
            {
                cn = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand("sp_AusentesActuales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                new SqlDataAdapter(cmd).Fill(tabla);
            }
            catch (SqlException ex)
            {
                throw new Exception("No se pudo consultar los ausentes actuales. " + ex.Message, ex);
            }
            finally
            {
                if (cn != null) cn.Dispose();
            }
            return tabla;
        }

        public DataTable ProximasReincorporaciones(int dias)
        {
            DataTable tabla = new DataTable();
            SqlConnection cn = null;
            try
            {
                cn = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand("sp_ProximasReincorporaciones", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Dias", SqlDbType.Int).Value = dias;
                new SqlDataAdapter(cmd).Fill(tabla);
            }
            catch (SqlException ex)
            {
                throw new Exception("No se pudo consultar las próximas reincorporaciones. " + ex.Message, ex);
            }
            finally
            {
                if (cn != null) cn.Dispose();
            }
            return tabla;
        }

        public DataTable ReporteAusencias(DateTime? fechaDesde, DateTime? fechaHasta, int? idDepartamento, int? idTipo)
        {
            DataTable tabla = new DataTable();
            SqlConnection cn = null;
            try
            {
                cn = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand("sp_ReporteAusencias", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@FechaDesde", SqlDbType.Date).Value = fechaDesde.HasValue ? (object)fechaDesde.Value.Date : DBNull.Value;
                cmd.Parameters.Add("@FechaHasta", SqlDbType.Date).Value = fechaHasta.HasValue ? (object)fechaHasta.Value.Date : DBNull.Value;
                cmd.Parameters.Add("@IdDepartamento", SqlDbType.Int).Value = idDepartamento.HasValue ? (object)idDepartamento.Value : DBNull.Value;
                cmd.Parameters.Add("@IdTipo", SqlDbType.Int).Value = idTipo.HasValue ? (object)idTipo.Value : DBNull.Value;
                new SqlDataAdapter(cmd).Fill(tabla);
            }
            catch (SqlException ex)
            {
                throw new Exception("No se pudo generar el reporte de ausencias. " + ex.Message, ex);
            }
            finally
            {
                if (cn != null) cn.Dispose();
            }
            return tabla;
        }

        public void RegistrarReincorporacion(int idAusencia, DateTime fechaReal)
        {
            SqlConnection cn = null;
            SqlTransaction tx = null;
            try
            {
                cn = Conexion.ObtenerConexion();
                cn.Open();
                tx = cn.BeginTransaction();

                SqlCommand cmdAusencia = new SqlCommand(
                    @"UPDATE Ausencia
                      SET FechaReincorporacionReal = @FechaReal
                      WHERE IdAusencia = @IdAusencia", cn, tx);
                cmdAusencia.Parameters.Add("@FechaReal", SqlDbType.Date).Value = fechaReal.Date;
                cmdAusencia.Parameters.Add("@IdAusencia", SqlDbType.Int).Value = idAusencia;
                if (cmdAusencia.ExecuteNonQuery() == 0)
                    throw new Exception("No se encontró la ausencia indicada.");

                SqlCommand cmdSolicitud = new SqlCommand(
                    @"UPDATE Solicitud
                      SET IdEstado = 5
                      WHERE IdSolicitud = (SELECT IdSolicitud FROM Ausencia WHERE IdAusencia = @IdAusencia)", cn, tx);
                cmdSolicitud.Parameters.Add("@IdAusencia", SqlDbType.Int).Value = idAusencia;
                cmdSolicitud.ExecuteNonQuery();

                tx.Commit();
            }
            catch (Exception ex)
            {
                if (tx != null) tx.Rollback();
                throw new Exception("No se pudo registrar la reincorporación. " + ex.Message, ex);
            }
            finally
            {
                if (cn != null) cn.Dispose();
            }
        }
    }
}