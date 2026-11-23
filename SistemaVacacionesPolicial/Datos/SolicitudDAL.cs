using ENTIDADESS;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class SolicitudDAL : RepositorioBase<SolicitudAusencia>
    {
        protected override string Tabla { get { return "Solicitud"; } }
        protected override string ColumnaId { get { return "s.IdSolicitud"; } }

        protected override string SqlSeleccionar
        {
            get
            {
                return @"SELECT s.*, t.Categoria
                         FROM Solicitud s
                         INNER JOIN TipoAusencia t ON t.IdTipo = s.IdTipo";
            }
        }

        protected override string SqlInsertar
        {
            get
            {
                return @"INSERT INTO Solicitud
                         (IdPersonal, IdTipo, FechaInicio, FechaFin, DiasSolicitados, Motivo, ReferenciaDocumento, IdEstado, IdUsuarioRegistra)
                         VALUES
                         (@IdPersonal, @IdTipo, @FechaInicio, @FechaFin, @DiasSolicitados, @Motivo, @ReferenciaDocumento, @IdEstado, @IdUsuarioRegistra);
                         SELECT SCOPE_IDENTITY();";
            }
        }

        protected override string SqlActualizar
        {
            get
            {
                return @"UPDATE Solicitud
                         SET IdPersonal = @IdPersonal,
                             IdTipo = @IdTipo,
                             FechaInicio = @FechaInicio,
                             FechaFin = @FechaFin,
                             DiasSolicitados = @DiasSolicitados,
                             Motivo = @Motivo,
                             ReferenciaDocumento = @ReferenciaDocumento,
                             IdEstado = @IdEstado,
                             IdUsuarioRegistra = @IdUsuarioRegistra
                         WHERE IdSolicitud = @Id";
            }
        }

        protected override SolicitudAusencia Mapear(SqlDataReader dr)
        {
            SolicitudAusencia s;
            string categoria = dr["Categoria"].ToString();

            switch (categoria)
            {
                case "Vacacion":
                    s = new Vacacion();
                    break;
                case "Licencia":
                    s = new Licencia();
                    break;
                default:
                    s = new Permiso();
                    break;
            }

            s.IdSolicitud = (int)dr["IdSolicitud"];
            s.IdPersonal = (int)dr["IdPersonal"];
            s.IdTipo = (int)dr["IdTipo"];
            s.FechaInicio = (DateTime)dr["FechaInicio"];
            s.FechaFin = (DateTime)dr["FechaFin"];
            s.DiasSolicitados = (int)dr["DiasSolicitados"];
            s.Motivo = dr["Motivo"] == DBNull.Value ? null : dr["Motivo"].ToString();
            s.ReferenciaDocumento = dr["ReferenciaDocumento"] == DBNull.Value ? null : dr["ReferenciaDocumento"].ToString();
            s.IdEstado = (int)dr["IdEstado"];
            s.IdUsuarioRegistra = (int)dr["IdUsuarioRegistra"];
            return s;
        }

        protected override void CargarParametros(SqlCommand cmd, SolicitudAusencia entidad, bool esActualizacion)
        {
            cmd.Parameters.Add("@IdPersonal", SqlDbType.Int).Value = entidad.IdPersonal;
            cmd.Parameters.Add("@IdTipo", SqlDbType.Int).Value = entidad.IdTipo;
            cmd.Parameters.Add("@FechaInicio", SqlDbType.Date).Value = entidad.FechaInicio.Date;
            cmd.Parameters.Add("@FechaFin", SqlDbType.Date).Value = entidad.FechaFin.Date;
            cmd.Parameters.Add("@DiasSolicitados", SqlDbType.Int).Value = entidad.DiasSolicitados;
            cmd.Parameters.Add("@Motivo", SqlDbType.VarChar).Value = (object)entidad.Motivo ?? DBNull.Value;
            cmd.Parameters.Add("@ReferenciaDocumento", SqlDbType.VarChar).Value = (object)entidad.ReferenciaDocumento ?? DBNull.Value;
            cmd.Parameters.Add("@IdEstado", SqlDbType.Int).Value = entidad.IdEstado;
            cmd.Parameters.Add("@IdUsuarioRegistra", SqlDbType.Int).Value = entidad.IdUsuarioRegistra;

            if (esActualizacion)
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = entidad.IdSolicitud;
        }

        public override void Eliminar(int id)
        {
            throw new NotSupportedException("Las solicitudes no se eliminan.");
        }

        public int ContarSolapes(int idPersonal, DateTime inicio, DateTime fin)
        {
            string sql = @"SELECT COUNT(*) FROM Solicitud
                           WHERE IdPersonal = @IdPersonal
                             AND IdEstado IN (1, 2, 4)
                             AND FechaInicio <= @Fin AND FechaFin >= @Inicio";
            SqlConnection cn = null;
            try
            {
                cn = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Add("@IdPersonal", SqlDbType.Int).Value = idPersonal;
                cmd.Parameters.Add("@Inicio", SqlDbType.Date).Value = inicio.Date;
                cmd.Parameters.Add("@Fin", SqlDbType.Date).Value = fin.Date;
                cn.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw new Exception("No se pudo verificar los solapes. " + ex.Message, ex);
            }
            finally
            {
                if (cn != null) cn.Dispose();
            }
        }

        public void AprobarYDescontarSaldo(int idSolicitud, int idUsuario, string comentario, int diasADescontar, DateTime fechaReincorporacionPrevista)
        {
            SqlConnection cn = null;
            SqlTransaction tx = null;
            try
            {
                cn = Conexion.ObtenerConexion();
                cn.Open();
                tx = cn.BeginTransaction();

                SqlCommand c1 = new SqlCommand(
                    "UPDATE Solicitud SET IdEstado = 2 WHERE IdSolicitud = @Id AND IdEstado = 1", cn, tx);
                c1.Parameters.Add("@Id", SqlDbType.Int).Value = idSolicitud;
                if (c1.ExecuteNonQuery() == 0)
                    throw new Exception("La solicitud ya no está pendiente.");

                SqlCommand c2 = new SqlCommand(
                    @"INSERT INTO HistorialAprobacion (IdSolicitud, IdUsuario, Decision, Comentario)
                      VALUES (@Id, @IdUsuario, 'Aprobada', @Comentario)", cn, tx);
                c2.Parameters.Add("@Id", SqlDbType.Int).Value = idSolicitud;
                c2.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = idUsuario;
                c2.Parameters.Add("@Comentario", SqlDbType.VarChar).Value = (object)comentario ?? DBNull.Value;
                c2.ExecuteNonQuery();

                if (diasADescontar > 0)
                {
                    SqlCommand c3 = new SqlCommand(
                        @"UPDATE SaldoVacaciones
                          SET DiasTomados = DiasTomados + @Dias
                          WHERE IdPersonal = (SELECT IdPersonal FROM Solicitud WHERE IdSolicitud = @Id)
                            AND Anio = (SELECT YEAR(FechaInicio) FROM Solicitud WHERE IdSolicitud = @Id)", cn, tx);
                    c3.Parameters.Add("@Dias", SqlDbType.Int).Value = diasADescontar;
                    c3.Parameters.Add("@Id", SqlDbType.Int).Value = idSolicitud;
                    if (c3.ExecuteNonQuery() == 0)
                        throw new Exception("No existe saldo de vacaciones para descontar.");
                }

                SqlCommand c4 = new SqlCommand(
                    @"INSERT INTO Ausencia (IdSolicitud, FechaReincorporacionPrevista)
                      VALUES (@Id, @Fecha)", cn, tx);
                c4.Parameters.Add("@Id", SqlDbType.Int).Value = idSolicitud;
                c4.Parameters.Add("@Fecha", SqlDbType.Date).Value = fechaReincorporacionPrevista.Date;
                c4.ExecuteNonQuery();

                tx.Commit();
            }
            catch (Exception ex)
            {
                if (tx != null) tx.Rollback();
                throw new Exception("No se pudo aprobar la solicitud. " + ex.Message, ex);
            }
            finally
            {
                if (cn != null) cn.Dispose();
            }
        }

        public void Rechazar(int idSolicitud, int idUsuario, string comentario)
        {
            SqlConnection cn = null;
            SqlTransaction tx = null;
            try
            {
                cn = Conexion.ObtenerConexion();
                cn.Open();
                tx = cn.BeginTransaction();

                SqlCommand c1 = new SqlCommand(
                    "UPDATE Solicitud SET IdEstado = 3 WHERE IdSolicitud = @Id AND IdEstado = 1", cn, tx);
                c1.Parameters.Add("@Id", SqlDbType.Int).Value = idSolicitud;
                if (c1.ExecuteNonQuery() == 0)
                    throw new Exception("La solicitud ya no está pendiente.");

                SqlCommand c2 = new SqlCommand(
                    @"INSERT INTO HistorialAprobacion (IdSolicitud, IdUsuario, Decision, Comentario)
                      VALUES (@Id, @IdUsuario, 'Rechazada', @Comentario)", cn, tx);
                c2.Parameters.Add("@Id", SqlDbType.Int).Value = idSolicitud;
                c2.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = idUsuario;
                c2.Parameters.Add("@Comentario", SqlDbType.VarChar).Value = (object)comentario ?? DBNull.Value;
                c2.ExecuteNonQuery();

                tx.Commit();
            }
            catch (Exception ex)
            {
                if (tx != null) tx.Rollback();
                throw new Exception("No se pudo rechazar la solicitud. " + ex.Message, ex);
            }
            finally
            {
                if (cn != null) cn.Dispose();
            }
        }

        public void PasarAEnCurso(DateTime hoy)
        {
            SqlConnection cn = null;
            SqlTransaction tx = null;
            try
            {
                cn = Conexion.ObtenerConexion();
                cn.Open();
                tx = cn.BeginTransaction();

                SqlCommand c1 = new SqlCommand(
                    @"UPDATE a
                      SET a.FechaInicioReal = s.FechaInicio
                      FROM Ausencia a
                      INNER JOIN Solicitud s ON s.IdSolicitud = a.IdSolicitud
                      WHERE s.IdEstado = 2 AND s.FechaInicio <= @Hoy", cn, tx);
                c1.Parameters.Add("@Hoy", SqlDbType.Date).Value = hoy.Date;
                c1.ExecuteNonQuery();

                SqlCommand c2 = new SqlCommand(
                    @"UPDATE Solicitud
                      SET IdEstado = 4
                      WHERE IdEstado = 2 AND FechaInicio <= @Hoy", cn, tx);
                c2.Parameters.Add("@Hoy", SqlDbType.Date).Value = hoy.Date;
                c2.ExecuteNonQuery();

                tx.Commit();
            }
            catch (Exception ex)
            {
                if (tx != null) tx.Rollback();
                throw new Exception("No se pudieron pasar las solicitudes a En curso. " + ex.Message, ex);
            }
            finally
            {
                if (cn != null) cn.Dispose();
            }
        }
    }
}