using ENTIDADESS;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class FeriadoDAL : RepositorioBase<Feriado>
    {
        protected override string Tabla { get { return "Feriado"; } }
        protected override string ColumnaId { get { return "IdFeriado"; } }

        protected override string SqlInsertar
        {
            get
            {
                return @"INSERT INTO Feriado (Fecha, Descripcion)
                         VALUES (@Fecha, @Descripcion);
                         SELECT SCOPE_IDENTITY();";
            }
        }

        protected override string SqlActualizar
        {
            get
            {
                return @"UPDATE Feriado
                         SET Fecha = @Fecha, Descripcion = @Descripcion
                         WHERE IdFeriado = @Id";
            }
        }

        protected override Feriado Mapear(SqlDataReader dr)
        {
            return new Feriado
            {
                IdFeriado = (int)dr["IdFeriado"],
                Fecha = (DateTime)dr["Fecha"],
                Descripcion = dr["Descripcion"].ToString()
            };
        }

        protected override void CargarParametros(SqlCommand cmd, Feriado entidad, bool esActualizacion)
        {
            cmd.Parameters.Add("@Fecha", SqlDbType.Date).Value = entidad.Fecha.Date;
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = entidad.Descripcion;

            if (esActualizacion)
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = entidad.IdFeriado;
        }
    }
}