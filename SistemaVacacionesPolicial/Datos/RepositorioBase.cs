using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Datos
{
    public abstract class RepositorioBase<T> where T : class
    {
        // Información que cada repositorio hijo debe proporcionar.
        protected abstract string Tabla { get; }
        protected abstract string ColumnaId { get; }
        protected abstract string SqlInsertar { get; }
        protected abstract string SqlActualizar { get; }

        // Convierte una fila de SQL Server en un objeto C#.
        protected abstract T Mapear(SqlDataReader dr);

        // Carga los parámetros de cada consulta.
        protected abstract void CargarParametros(
            SqlCommand cmd, T entidad, bool esActualizacion);

        // Consulta utilizada para listar los registros.
        protected virtual string SqlSeleccionar
        {
            get { return "SELECT * FROM " + Tabla; }
        }

        // 1. LISTAR
        public virtual List<T> Listar()
        {
            List<T> lista = new List<T>();
            SqlConnection cn = null;

            try
            {
                cn = Conexion.ObtenerConexion();

                SqlCommand cmd = new SqlCommand(SqlSeleccionar, cn);

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(Mapear(dr));
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(
                    "No se pudo leer " + Tabla + ". " + ex.Message, ex);
            }
            finally
            {
                if (cn != null)
                    cn.Dispose();
            }

            return lista;
        }

        // 2. BUSCAR POR ID
        public virtual T ObtenerPorId(int id)
        {
            SqlConnection cn = null;

            try
            {
                cn = Conexion.ObtenerConexion();

                SqlCommand cmd = new SqlCommand(
                    SqlSeleccionar + " WHERE " + ColumnaId + " = @Id", cn);

                cmd.Parameters.AddWithValue("@Id", id);

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
                throw new Exception(
                    "No se pudo buscar en " + Tabla + ". " + ex.Message, ex);
            }
            finally
            {
                if (cn != null)
                    cn.Dispose();
            }
        }

        // 3. INSERTAR
        public virtual int Insertar(T entidad)
        {
            SqlConnection cn = null;

            try
            {
                cn = Conexion.ObtenerConexion();

                SqlCommand cmd = new SqlCommand(SqlInsertar, cn);

                CargarParametros(cmd, entidad, false);

                cn.Open();

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    throw new Exception("Ya existe un registro con ese valor único.", ex);

                throw new Exception(
                    "No se pudo guardar en " + Tabla + ". " + ex.Message, ex);
            }
            finally
            {
                if (cn != null)
                    cn.Dispose();
            }
        }

        // 4. ACTUALIZAR
        public virtual void Actualizar(T entidad)
        {
            SqlConnection cn = null;

            try
            {
                cn = Conexion.ObtenerConexion();

                SqlCommand cmd = new SqlCommand(SqlActualizar, cn);

                CargarParametros(cmd, entidad, true);

                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    throw new Exception("Ya existe un registro con ese valor único.", ex);

                throw new Exception(
                    "No se pudo actualizar " + Tabla + ". " + ex.Message, ex);
            }
            finally
            {
                if (cn != null)
                    cn.Dispose();
            }
        }

        // 5. ELIMINAR
        public virtual void Eliminar(int id)
        {
            SqlConnection cn = null;

            try
            {
                cn = Conexion.ObtenerConexion();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM " + Tabla + " WHERE " + ColumnaId + " = @Id", cn);

                cmd.Parameters.AddWithValue("@Id", id);

                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    throw new Exception(
                        "No se puede eliminar: el registro está en uso.", ex);

                throw new Exception(
                    "No se pudo eliminar de " + Tabla + ". " + ex.Message, ex);
            }
            finally
            {
                if (cn != null)
                    cn.Dispose();
            }
        }
    }
}