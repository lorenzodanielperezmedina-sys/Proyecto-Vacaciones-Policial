using ENTIDADESS;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class SaldoVacacionesDAL : RepositorioBase<SaldoVacaciones>
    {
        protected override string Tabla { get { return "SaldoVacaciones"; } }
        protected override string ColumnaId { get { return "IdSaldo"; } }

        protected override string SqlInsertar
        {
            get
            {
                return @"INSERT INTO SaldoVacaciones (IdPersonal, Anio, DiasCorrespondientes, DiasTomados)
                         VALUES (@IdPersonal, @Anio, @DiasCorrespondientes, @DiasTomados);
                         SELECT SCOPE_IDENTITY();";
            }
        }

        protected override string SqlActualizar
        {
            get
            {
                return @"UPDATE SaldoVacaciones
                         SET IdPersonal = @IdPersonal,
                             Anio = @Anio,
                             DiasCorrespondientes = @DiasCorrespondientes,
                             DiasTomados = @DiasTomados
                         WHERE IdSaldo = @Id";
            }
        }

        protected override SaldoVacaciones Mapear(SqlDataReader dr)
        {
            return new SaldoVacaciones
            {
                IdSaldo = (int)dr["IdSaldo"],
                IdPersonal = (int)dr["IdPersonal"],
                Anio = (int)dr["Anio"],
                DiasCorrespondientes = (int)dr["DiasCorrespondientes"],
                DiasTomados = (int)dr["DiasTomados"]
            };
        }

        protected override void CargarParametros(SqlCommand cmd, SaldoVacaciones entidad, bool esActualizacion)
        {
            cmd.Parameters.Add("@IdPersonal", SqlDbType.Int).Value = entidad.IdPersonal;
            cmd.Parameters.Add("@Anio", SqlDbType.Int).Value = entidad.Anio;
            cmd.Parameters.Add("@DiasCorrespondientes", SqlDbType.Int).Value = entidad.DiasCorrespondientes;
            cmd.Parameters.Add("@DiasTomados", SqlDbType.Int).Value = entidad.DiasTomados;

            if (esActualizacion)
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = entidad.IdSaldo;
        }

        public SaldoVacaciones ObtenerPorPersonalAnio(int idPersonal, int anio)
        {
            SqlConnection cn = null;
            try
            {
                cn = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(
                    SqlSeleccionar + " WHERE IdPersonal = @IdPersonal AND Anio = @Anio", cn);
                cmd.Parameters.Add("@IdPersonal", SqlDbType.Int).Value = idPersonal;
                cmd.Parameters.Add("@Anio", SqlDbType.Int).Value = anio;
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                        return Mapear(dr);
                    return null;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("No se pudo obtener el saldo de vacaciones. " + ex.Message, ex);
            }
            finally
            {
                if (cn != null) cn.Dispose();
            }
        }
    }
}