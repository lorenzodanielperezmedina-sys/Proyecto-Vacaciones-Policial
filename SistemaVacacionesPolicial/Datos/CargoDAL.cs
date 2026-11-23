
using ENTIDADESS;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class CargoDAL : RepositorioBase<Cargo>
    {
        protected override string Tabla { get { return "Cargo"; } }
        protected override string ColumnaId { get { return "IdCargo"; } }

        protected override string SqlInsertar
        {
            get { return "INSERT INTO Cargo (Nombre) VALUES (@Nombre); SELECT SCOPE_IDENTITY();"; }
        }

        protected override string SqlActualizar
        {
            get { return "UPDATE Cargo SET Nombre = @Nombre WHERE IdCargo = @Id"; }
        }

        protected override Cargo Mapear(SqlDataReader dr)
        {
            return new Cargo
            {
                IdCargo = (int)dr["IdCargo"],
                Nombre = dr["Nombre"].ToString()
            };
        }

        protected override void CargarParametros(SqlCommand cmd, Cargo entidad, bool esActualizacion)
        {
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = entidad.Nombre;
            if (esActualizacion)
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = entidad.IdCargo;
        }
    }
}