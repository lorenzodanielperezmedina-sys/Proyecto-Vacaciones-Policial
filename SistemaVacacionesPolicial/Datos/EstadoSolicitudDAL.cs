using ENTIDADESS;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class EstadoSolicitudDAL : RepositorioBase<EstadoSolicitud>
    {
        protected override string Tabla { get { return "EstadoSolicitud"; } }
        protected override string ColumnaId { get { return "IdEstado"; } }

        protected override string SqlInsertar
        {
            get { return "INSERT INTO EstadoSolicitud (Nombre) VALUES (@Nombre); SELECT SCOPE_IDENTITY();"; }
        }

        protected override string SqlActualizar
        {
            get { return "UPDATE EstadoSolicitud SET Nombre = @Nombre WHERE IdEstado = @Id"; }
        }

        protected override EstadoSolicitud Mapear(SqlDataReader dr)
        {
            return new EstadoSolicitud
            {
                IdEstado = (int)dr["IdEstado"],
                Nombre = dr["Nombre"].ToString()
            };
        }

        protected override void CargarParametros(SqlCommand cmd, EstadoSolicitud entidad, bool esActualizacion)
        {
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = entidad.Nombre;
            if (esActualizacion)
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = entidad.IdEstado;
        }
    }
}