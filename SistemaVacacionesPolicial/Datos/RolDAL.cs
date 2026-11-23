
using ENTIDADESS;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class RolDAL : RepositorioBase<Rol>
    {
        protected override string Tabla { get { return "Rol"; } }
        protected override string ColumnaId { get { return "IdRol"; } }

        protected override string SqlInsertar
        {
            get { return "INSERT INTO Rol (Nombre) VALUES (@Nombre); SELECT SCOPE_IDENTITY();"; }
        }

        protected override string SqlActualizar
        {
            get { return "UPDATE Rol SET Nombre = @Nombre WHERE IdRol = @Id"; }
        }

        protected override Rol Mapear(SqlDataReader dr)
        {
            return new Rol
            {
                IdRol = (int)dr["IdRol"],
                Nombre = dr["Nombre"].ToString()
            };
        }

        protected override void CargarParametros(SqlCommand cmd, Rol entidad, bool esActualizacion)
        {
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = entidad.Nombre;
            if (esActualizacion)
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = entidad.IdRol;
        }
    }
}