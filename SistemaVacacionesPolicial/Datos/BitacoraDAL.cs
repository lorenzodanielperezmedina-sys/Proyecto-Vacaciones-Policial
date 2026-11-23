using ENTIDADESS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class BitacoraDAL : RepositorioBase<Bitacora>
    {
        protected override string Tabla { get { return "Bitacora"; } }
        protected override string ColumnaId { get { return "IdBitacora"; } }

        protected override string SqlInsertar
        {
            get
            {
                return @"INSERT INTO Bitacora (IdUsuario, Accion, Detalle, Fecha)
                         VALUES (@IdUsuario, @Accion, @Detalle, @Fecha);
                         SELECT SCOPE_IDENTITY();";
            }
        }

        protected override string SqlActualizar
        {
            get
            {
                return @"UPDATE Bitacora
                         SET IdUsuario = @IdUsuario,
                             Accion = @Accion,
                             Detalle = @Detalle,
                             Fecha = @Fecha
                         WHERE IdBitacora = @Id";
            }
        }

        protected override Bitacora Mapear(SqlDataReader dr)
        {
            return new Bitacora
            {
                IdBitacora = (int)dr["IdBitacora"],
                IdUsuario = (int)dr["IdUsuario"],
                Accion = dr["Accion"].ToString(),
                Detalle = dr["Detalle"] == DBNull.Value ? null : dr["Detalle"].ToString(),
                Fecha = (DateTime)dr["Fecha"]
            };
        }

        protected override void CargarParametros(SqlCommand cmd, Bitacora entidad, bool esActualizacion)
        {
            cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = entidad.IdUsuario;
            cmd.Parameters.Add("@Accion", SqlDbType.VarChar).Value = entidad.Accion;
            cmd.Parameters.Add("@Detalle", SqlDbType.VarChar).Value = (object)entidad.Detalle ?? DBNull.Value;
            cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = entidad.Fecha == default(DateTime) ? DateTime.Now : entidad.Fecha;

            if (esActualizacion)
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = entidad.IdBitacora;
        }

        public List<Bitacora> ListarEntre(DateTime desde, DateTime hasta)
        {
            List<Bitacora> lista = new List<Bitacora>();
            SqlConnection cn = null;
            try
            {
                cn = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(
                    SqlSeleccionar + " WHERE Fecha >= @Desde AND Fecha <= @Hasta ORDER BY Fecha DESC", cn);
                cmd.Parameters.Add("@Desde", SqlDbType.DateTime).Value = desde;
                cmd.Parameters.Add("@Hasta", SqlDbType.DateTime).Value = hasta;
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                        lista.Add(Mapear(dr));
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("No se pudo consultar la bitácora. " + ex.Message, ex);
            }
            finally
            {
                if (cn != null) cn.Dispose();
            }
            return lista;
        }
    }
}