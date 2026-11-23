
using ENTIDADESS;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DepartamentoDAL : RepositorioBase<Departamento>
    {
        protected override string Tabla { get { return "Departamento"; } }
        protected override string ColumnaId { get { return "IdDepartamento"; } }

        protected override string SqlInsertar
        {
            get { return "INSERT INTO Departamento (Nombre) VALUES (@Nombre); SELECT SCOPE_IDENTITY();"; }
        }

        protected override string SqlActualizar
        {
            get { return "UPDATE Departamento SET Nombre = @Nombre WHERE IdDepartamento = @Id"; }
        }

        protected override Departamento Mapear(SqlDataReader dr)
        {
            return new Departamento
            {
                IdDepartamento = (int)dr["IdDepartamento"],
                Nombre = dr["Nombre"].ToString()
            };
        }

        protected override void CargarParametros(SqlCommand cmd, Departamento entidad, bool esActualizacion)
        {
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = entidad.Nombre;
            if (esActualizacion)
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = entidad.IdDepartamento;
        }
    }
}
