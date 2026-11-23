using ENTIDADESS;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class TipoAusenciaDAL : RepositorioBase<TipoAusencia>
    {
        protected override string Tabla { get { return "TipoAusencia"; } }
        protected override string ColumnaId { get { return "IdTipo"; } }

        protected override string SqlInsertar
        {
            get
            {
                return @"INSERT INTO TipoAusencia (Nombre, Categoria, DiasMaximos, RequiereDocumento)
                         VALUES (@Nombre, @Categoria, @DiasMaximos, @RequiereDocumento);
                         SELECT SCOPE_IDENTITY();";
            }
        }

        protected override string SqlActualizar
        {
            get
            {
                return @"UPDATE TipoAusencia
                         SET Nombre = @Nombre,
                             Categoria = @Categoria,
                             DiasMaximos = @DiasMaximos,
                             RequiereDocumento = @RequiereDocumento
                         WHERE IdTipo = @Id";
            }
        }

        protected override TipoAusencia Mapear(SqlDataReader dr)
        {
            return new TipoAusencia
            {
                IdTipo = (int)dr["IdTipo"],
                Nombre = dr["Nombre"].ToString(),
                Categoria = dr["Categoria"].ToString(),
                DiasMaximos = (int)dr["DiasMaximos"],
                RequiereDocumento = (bool)dr["RequiereDocumento"]
            };
        }

        protected override void CargarParametros(SqlCommand cmd, TipoAusencia entidad, bool esActualizacion)
        {
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = entidad.Nombre;
            cmd.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = entidad.Categoria;
            cmd.Parameters.Add("@DiasMaximos", SqlDbType.Int).Value = entidad.DiasMaximos;
            cmd.Parameters.Add("@RequiereDocumento", SqlDbType.Bit).Value = entidad.RequiereDocumento;

            if (esActualizacion)
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = entidad.IdTipo;
        }
    }
}