using ENTIDADESS;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class PersonalDAL : RepositorioBase<Personal>
    {
        protected override string Tabla { get { return "Personal"; } }
        protected override string ColumnaId { get { return "IdPersonal"; } }

        protected override string SqlInsertar
        {
            get
            {
                return @"INSERT INTO Personal (Cedula, Nombres, Apellidos, IdRango, IdDepartamento, IdCargo, FechaIngreso, Correo, Activo)
                         VALUES (@Cedula, @Nombres, @Apellidos, @IdRango, @IdDepartamento, @IdCargo, @FechaIngreso, @Correo, @Activo);
                         SELECT SCOPE_IDENTITY();";
            }
        }

        protected override string SqlActualizar
        {
            get
            {
                return @"UPDATE Personal
                         SET Cedula = @Cedula,
                             Nombres = @Nombres,
                             Apellidos = @Apellidos,
                             IdRango = @IdRango,
                             IdDepartamento = @IdDepartamento,
                             IdCargo = @IdCargo,
                             FechaIngreso = @FechaIngreso,
                             Correo = @Correo,
                             Activo = @Activo
                         WHERE IdPersonal = @Id";
            }
        }

        protected override Personal Mapear(SqlDataReader dr)
        {
            return new Personal
            {
                IdPersonal = (int)dr["IdPersonal"],
                Cedula = dr["Cedula"].ToString(),
                Nombres = dr["Nombres"].ToString(),
                Apellidos = dr["Apellidos"].ToString(),
                IdRango = (int)dr["IdRango"],
                IdDepartamento = (int)dr["IdDepartamento"],
                IdCargo = (int)dr["IdCargo"],
                FechaIngreso = (DateTime)dr["FechaIngreso"],
                Correo = dr["Correo"] == DBNull.Value ? null : dr["Correo"].ToString(),
                Activo = (bool)dr["Activo"]
            };
        }

        protected override void CargarParametros(SqlCommand cmd, Personal entidad, bool esActualizacion)
        {
            cmd.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = entidad.Cedula;
            cmd.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = entidad.Nombres;
            cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = entidad.Apellidos;
            cmd.Parameters.Add("@IdRango", SqlDbType.Int).Value = entidad.IdRango;
            cmd.Parameters.Add("@IdDepartamento", SqlDbType.Int).Value = entidad.IdDepartamento;
            cmd.Parameters.Add("@IdCargo", SqlDbType.Int).Value = entidad.IdCargo;
            cmd.Parameters.Add("@FechaIngreso", SqlDbType.Date).Value = entidad.FechaIngreso.Date;
            cmd.Parameters.Add("@Correo", SqlDbType.VarChar).Value = (object)entidad.Correo ?? DBNull.Value;
            cmd.Parameters.Add("@Activo", SqlDbType.Bit).Value = entidad.Activo;

            if (esActualizacion)
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = entidad.IdPersonal;
        }

        public override void Eliminar(int id)
        {
            SqlConnection cn = null;
            try
            {
                cn = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand("UPDATE Personal SET Activo = 0 WHERE IdPersonal = @Id", cn);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("No se pudo dar de baja al personal. " + ex.Message, ex);
            }
            finally
            {
                if (cn != null) cn.Dispose();
            }
        }

        public DataTable ListarDetalle()
        {
            DataTable tabla = new DataTable();
            SqlConnection cn = null;
            try
            {
                cn = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand("sp_PersonalDetalle", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                new SqlDataAdapter(cmd).Fill(tabla);
            }
            catch (SqlException ex)
            {
                throw new Exception("No se pudo consultar el detalle del personal. " + ex.Message, ex);
            }
            finally
            {
                if (cn != null) cn.Dispose();
            }
            return tabla;
        }
    }
}