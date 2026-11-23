using ENTIDADESS;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class UsuarioDAL : RepositorioBase<Usuario>
    {
        protected override string Tabla { get { return "Usuario"; } }
        protected override string ColumnaId { get { return "IdUsuario"; } }

        protected override string SqlInsertar
        {
            get
            {
                return @"INSERT INTO Usuario (IdRol, NombreUsuario, NombreCompleto, ClaveHash, Activo)
                         VALUES (@IdRol, @NombreUsuario, @NombreCompleto, @ClaveHash, @Activo);
                         SELECT SCOPE_IDENTITY();";
            }
        }

        protected override string SqlActualizar
        {
            get
            {
                return @"UPDATE Usuario
                         SET IdRol = @IdRol,
                             NombreUsuario = @NombreUsuario,
                             NombreCompleto = @NombreCompleto,
                             Activo = @Activo
                         WHERE IdUsuario = @Id";
            }
        }

        protected override Usuario Mapear(SqlDataReader dr)
        {
            return new Usuario
            {
                IdUsuario = (int)dr["IdUsuario"],
                IdRol = (int)dr["IdRol"],
                NombreUsuario = dr["NombreUsuario"].ToString(),
                NombreCompleto = dr["NombreCompleto"] == DBNull.Value ? null : dr["NombreCompleto"].ToString(),
                ClaveHash = dr["ClaveHash"].ToString(),
                Activo = (bool)dr["Activo"],
                UltimoAcceso = dr["UltimoAcceso"] == DBNull.Value ? (DateTime?)null : (DateTime)dr["UltimoAcceso"]
            };
        }

        protected override void CargarParametros(SqlCommand cmd, Usuario entidad, bool esActualizacion)
        {
            cmd.Parameters.Add("@IdRol", SqlDbType.Int).Value = entidad.IdRol;
            cmd.Parameters.Add("@NombreUsuario", SqlDbType.VarChar).Value = entidad.NombreUsuario;
            cmd.Parameters.Add("@NombreCompleto", SqlDbType.VarChar).Value = (object)entidad.NombreCompleto ?? DBNull.Value;
            cmd.Parameters.Add("@Activo", SqlDbType.Bit).Value = entidad.Activo;

            if (esActualizacion)
            {
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = entidad.IdUsuario;
            }
            else
            {
                cmd.Parameters.Add("@ClaveHash", SqlDbType.VarChar).Value = entidad.ClaveHash;
            }
        }

        public override void Eliminar(int id)
        {
            SqlConnection cn = null;
            try
            {
                cn = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand("UPDATE Usuario SET Activo = 0 WHERE IdUsuario = @Id", cn);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("No se pudo desactivar el usuario. " + ex.Message, ex);
            }
            finally
            {
                if (cn != null) cn.Dispose();
            }
        }

        public void ActualizarClave(int idUsuario, string claveHash)
        {
            SqlConnection cn = null;
            try
            {
                cn = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand("UPDATE Usuario SET ClaveHash = @Hash WHERE IdUsuario = @Id", cn);
                cmd.Parameters.Add("@Hash", SqlDbType.VarChar).Value = claveHash;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = idUsuario;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("No se pudo actualizar la clave. " + ex.Message, ex);
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
                SqlCommand cmd = new SqlCommand("sp_UsuarioDetalle", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                new SqlDataAdapter(cmd).Fill(tabla);
            }
            catch (SqlException ex)
            {
                throw new Exception("No se pudo consultar el detalle de usuarios. " + ex.Message, ex);
            }
            finally
            {
                if (cn != null) cn.Dispose();
            }

            return tabla;
        }

        public Usuario ObtenerPorNombre(string nombreUsuario)
        {
            SqlConnection cn = null;
            try
            {
                cn = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(
                    SqlSeleccionar + " WHERE NombreUsuario = @NombreUsuario", cn);
                cmd.Parameters.Add("@NombreUsuario", SqlDbType.VarChar).Value = nombreUsuario;
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
                throw new Exception("No se pudo buscar el usuario. " + ex.Message, ex);
            }
            finally
            {
                if (cn != null) cn.Dispose();
            }
        }
    }
}