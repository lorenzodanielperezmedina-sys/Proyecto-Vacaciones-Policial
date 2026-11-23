using ENTIDADESS;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class HistorialAprobacionDAL : RepositorioBase<HistorialAprobacion>
    {
        protected override string Tabla { get { return "HistorialAprobacion"; } }
        protected override string ColumnaId { get { return "IdHistorial"; } }

        protected override string SqlInsertar
        {
            get
            {
                return @"INSERT INTO HistorialAprobacion (IdSolicitud, IdUsuario, Decision, Comentario, Fecha)
                         VALUES (@IdSolicitud, @IdUsuario, @Decision, @Comentario, @Fecha);
                         SELECT SCOPE_IDENTITY();";
            }
        }

        protected override string SqlActualizar
        {
            get
            {
                return @"UPDATE HistorialAprobacion
                         SET IdSolicitud = @IdSolicitud,
                             IdUsuario = @IdUsuario,
                             Decision = @Decision,
                             Comentario = @Comentario,
                             Fecha = @Fecha
                         WHERE IdHistorial = @Id";
            }
        }

        protected override HistorialAprobacion Mapear(SqlDataReader dr)
        {
            return new HistorialAprobacion
            {
                IdHistorial = (int)dr["IdHistorial"],
                IdSolicitud = (int)dr["IdSolicitud"],
                IdUsuario = (int)dr["IdUsuario"],
                Decision = dr["Decision"].ToString(),
                Comentario = dr["Comentario"] == DBNull.Value ? null : dr["Comentario"].ToString(),
                Fecha = (DateTime)dr["Fecha"]
            };
        }

        protected override void CargarParametros(SqlCommand cmd, HistorialAprobacion entidad, bool esActualizacion)
        {
            cmd.Parameters.Add("@IdSolicitud", SqlDbType.Int).Value = entidad.IdSolicitud;
            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = entidad.IdUsuario;
            cmd.Parameters.Add("@Decision", SqlDbType.VarChar).Value = entidad.Decision;
            cmd.Parameters.Add("@Comentario", SqlDbType.VarChar).Value = (object)entidad.Comentario ?? DBNull.Value;
            cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = entidad.Fecha == default(DateTime) ? DateTime.Now : entidad.Fecha;

            if (esActualizacion)
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = entidad.IdHistorial;
        }
    }
}