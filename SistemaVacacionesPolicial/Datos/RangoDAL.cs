
using ENTIDADESS;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class RangoDAL : RepositorioBase<Rango>
    {
        protected override string Tabla
        {
            get { return "Rango"; }
        }

        protected override string ColumnaId
        {
            get { return "IdRango"; }
        }

        protected override string SqlInsertar
        {
            get
            {
                return "INSERT INTO Rango (Nombre) VALUES (@Nombre); SELECT SCOPE_IDENTITY();";
            }
        }

        protected override string SqlActualizar
        {
            get
            {
                return "UPDATE Rango SET Nombre = @Nombre WHERE IdRango = @Id";
            }
        }

        protected override Rango Mapear(SqlDataReader dr)
        {
            return new Rango
            {
                IdRango = (int)dr["IdRango"],
                Nombre = dr["Nombre"].ToString()
            };
        }

        protected override void CargarParametros(SqlCommand cmd, Rango entidad, bool esActualizacion)
        {
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = entidad.Nombre;

            if (esActualizacion)
            {
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = entidad.IdRango;
            }
        }
    }
}
