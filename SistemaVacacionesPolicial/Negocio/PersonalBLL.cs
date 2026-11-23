using Datos;
using ENTIDADESS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Negocio
{
    public class PersonalBLL
    {
        private readonly PersonalDAL personalDal = new PersonalDAL();
        private readonly BitacoraDAL bitacoraDal = new BitacoraDAL();

        public DataTable ListarDetalle()
        {
            return personalDal.ListarDetalle();
        }

        public int ContarActivos()
        {
            return personalDal.ListarDetalle().Select("Activo = true").Length;
        }

        public void Guardar(Personal p, int idUsuarioEjecutor)
        {
            ValidarPersonal(p);

            p.Cedula = p.Cedula.Trim();
            p.Nombres = p.Nombres.Trim();
            p.Apellidos = p.Apellidos.Trim();
            p.Correo = string.IsNullOrWhiteSpace(p.Correo) ? null : p.Correo.Trim();

            if (p.IdPersonal == 0)
            {
                p.Activo = true;
                personalDal.Insertar(p);
                RegistrarBitacoraSafe(idUsuarioEjecutor, "Registrar personal", $"Se registró a {p.Nombres} {p.Apellidos} ({p.Cedula}).");
            }
            else
            {
                personalDal.Actualizar(p);
                RegistrarBitacoraSafe(idUsuarioEjecutor, "Editar personal", $"Se actualizó el personal ID {p.IdPersonal}.");
            }
        }

        public void Eliminar(int idPersonal, int idUsuarioEjecutor)
        {
            if (idPersonal <= 0)
                throw new ReglaNegocioException("El identificador del personal no es válido.");

            // Baja lógica para conservar el historial de solicitudes, saldos y ausencias
            personalDal.Eliminar(idPersonal);

            RegistrarBitacoraSafe(idUsuarioEjecutor, "Baja lógica personal", $"Se inactivó el personal ID {idPersonal}.");
        }

        private void ValidarPersonal(Personal p)
        {
            if (p == null)
                throw new ReglaNegocioException("Los datos del personal son obligatorios.");

            if (string.IsNullOrWhiteSpace(p.Cedula) || !Regex.IsMatch(p.Cedula.Trim(), @"^\d{3}-\d{7}-\d{1}$"))
                throw new ReglaNegocioException("La cédula debe tener el formato 000-0000000-0.");

            if (string.IsNullOrWhiteSpace(p.Nombres))
                throw new ReglaNegocioException("Los nombres son obligatorios.");

            if (string.IsNullOrWhiteSpace(p.Apellidos))
                throw new ReglaNegocioException("Los apellidos son obligatorios.");

            if (p.IdRango <= 0 || p.IdDepartamento <= 0 || p.IdCargo <= 0)
                throw new ReglaNegocioException("Debe seleccionar rango, departamento y cargo válidos.");

            if (p.FechaIngreso.Date > DateTime.Today)
                throw new ReglaNegocioException("La fecha de ingreso no puede ser posterior a la fecha actual.");
        }

        private void RegistrarBitacoraSafe(int idUsuario, string accion, string detalle)
        {
            try
            {
                Bitacora registro = new Bitacora
                {
                    IdUsuario = idUsuario,
                    Accion = accion,
                    Detalle = detalle,
                    Fecha = DateTime.Now
                };

                bitacoraDal.Insertar(registro);
            }
            catch
            {
                // No bloquear la operación principal si falla el registro de bitácora
            }
        }
    }
}