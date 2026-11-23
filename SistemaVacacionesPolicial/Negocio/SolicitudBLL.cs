using Datos;
using ENTIDADESS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class SolicitudBLL
    {
        private readonly SolicitudDAL solicitudDal = new SolicitudDAL();
        private readonly SaldoVacacionesDAL saldoDal = new SaldoVacacionesDAL();
        private readonly FeriadoDAL feriadoDal = new FeriadoDAL();
        private readonly BitacoraDAL bitacoraDal = new BitacoraDAL();

        private List<DateTime> ObtenerFeriados()
        {
            // Ajusta "Listar" si tu RepositorioBase<T> nombra este metodo "ObtenerTodos"
            var lista = feriadoDal.Listar();
            if (lista == null)
                return new List<DateTime>();

            return lista.Select(f => f.Fecha.Date).ToList();
        }

        public int CalcularDiasHabiles(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaFin.Date < fechaInicio.Date)
                throw new ReglaNegocioException("La fecha fin no puede ser anterior a la fecha inicio.");

            return ENTIDADESS.CalculoDias.DiasHabiles(fechaInicio, fechaFin, ObtenerFeriados());
        }

        public DateTime CalcularFechaReincorporacionPrevista(DateTime fechaFin)
        {
            return ENTIDADESS .CalculoDias.SiguienteDiaHabil(fechaFin, ObtenerFeriados());
        }

        public SolicitudAusencia ObtenerPorId(int idSolicitud)
        {
            if (idSolicitud <= 0)
                throw new ReglaNegocioException("El identificador de la solicitud no es válido.");

            return solicitudDal.ObtenerPorId(idSolicitud);
        }

        public void RegistrarSolicitud(SolicitudAusencia solicitud, int idUsuarioEjecutor)
        {
            if (solicitud == null)
                throw new ReglaNegocioException("Los datos de la solicitud son obligatorios.");

            if (solicitud.IdPersonal <= 0)
                throw new ReglaNegocioException("Debe seleccionar un miembro del personal válido.");

            if (solicitud.IdTipo <= 0)
                throw new ReglaNegocioException("Debe seleccionar un tipo de ausencia válido.");

            if (solicitud.FechaFin.Date < solicitud.FechaInicio.Date)
                throw new ReglaNegocioException("La fecha de fin no puede ser anterior a la fecha de inicio.");

            if (solicitud.FechaInicio.Date < DateTime.Today)
                throw new ReglaNegocioException("La fecha de inicio no puede ser anterior a la fecha actual.");

            List<DateTime> feriados = ObtenerFeriados();
            int diasHabiles = ENTIDADESS.CalculoDias.DiasHabiles(solicitud.FechaInicio, solicitud.FechaFin, feriados);

            if (diasHabiles <= 0)
                throw new ReglaNegocioException("El rango seleccionado no contiene días hábiles.");

            solicitud.DiasSolicitados = diasHabiles;

            int solapes = solicitudDal.ContarSolapes(solicitud.IdPersonal, solicitud.FechaInicio, solicitud.FechaFin);
            if (solapes > 0)
                throw new ReglaNegocioException("Ya existe una solicitud activa o aprobada que se solapa con el rango de fechas.");

            if (solicitud is Vacacion)
            {
                SaldoVacaciones saldo = saldoDal.ObtenerPorPersonalAnio(solicitud.IdPersonal, solicitud.FechaInicio.Year);
                if (saldo == null)
                    throw new ReglaNegocioException("El personal no tiene saldo de vacaciones registrado para el año de la solicitud.");

                int disponibles = saldo.DiasCorrespondientes - saldo.DiasTomados;
                if (diasHabiles > disponibles)
                    throw new ReglaNegocioException($"Saldo insuficiente. Días disponibles: {disponibles}, solicitados: {diasHabiles}.");
            }

            solicitud.IdEstado = Estados.Pendiente;
            solicitud.IdUsuarioRegistra = idUsuarioEjecutor;

            solicitudDal.Insertar(solicitud);
            RegistrarBitacoraSafe(idUsuarioEjecutor, "Registrar solicitud", $"Se registró la solicitud de personal ID {solicitud.IdPersonal} ({diasHabiles} días hábiles).");
        }

        public void AprobarSolicitud(int idSolicitud, int idUsuarioAprobador, string comentario)
        {
            if (idSolicitud <= 0)
                throw new ReglaNegocioException("El identificador de la solicitud no es válido.");

            if (idUsuarioAprobador <= 0)
                throw new ReglaNegocioException("El usuario aprobador no es válido.");

            SolicitudAusencia solicitud = solicitudDal.ObtenerPorId(idSolicitud);
            if (solicitud == null)
                throw new ReglaNegocioException("La solicitud no existe.");

            if (solicitud.IdEstado != Estados.Pendiente)
                throw new ReglaNegocioException("Solo se pueden aprobar solicitudes en estado Pendiente.");

            int diasADescontar = (solicitud is Vacacion) ? solicitud.DiasSolicitados : 0;

            if (diasADescontar > 0)
            {
                SaldoVacaciones saldo = saldoDal.ObtenerPorPersonalAnio(solicitud.IdPersonal, solicitud.FechaInicio.Year);
                if (saldo == null)
                    throw new ReglaNegocioException("No existe saldo de vacaciones para el año de la solicitud.");

                int disponibles = saldo.DiasCorrespondientes - saldo.DiasTomados;
                if (diasADescontar > disponibles)
                    throw new ReglaNegocioException($"Saldo insuficiente para aprobar. Disponibles: {disponibles}, requeridos: {diasADescontar}.");
            }

            DateTime fechaReincorporacion = ENTIDADESS.CalculoDias.SiguienteDiaHabil(solicitud.FechaFin, ObtenerFeriados());

            solicitudDal.AprobarYDescontarSaldo(idSolicitud, idUsuarioAprobador, comentario, diasADescontar, fechaReincorporacion);
            RegistrarBitacoraSafe(idUsuarioAprobador, "Aprobar solicitud", $"Se aprobó la solicitud ID {idSolicitud}.");
        }

        public void RechazarSolicitud(int idSolicitud, int idUsuarioRechaza, string comentario)
        {
            if (idSolicitud <= 0)
                throw new ReglaNegocioException("El identificador de la solicitud no es válido.");

            if (idUsuarioRechaza <= 0)
                throw new ReglaNegocioException("El usuario que rechaza no es válido.");

            if (string.IsNullOrWhiteSpace(comentario))
                throw new ReglaNegocioException("Debe indicar un comentario o motivo al rechazar la solicitud.");

            solicitudDal.Rechazar(idSolicitud, idUsuarioRechaza, comentario.Trim());
            RegistrarBitacoraSafe(idUsuarioRechaza, "Rechazar solicitud", $"Se rechazó la solicitud ID {idSolicitud}.");
        }

        public void ActualizarSolicitudesEnCurso(DateTime fechaReferencia, int idUsuarioEjecutor)
        {
            solicitudDal.PasarAEnCurso(fechaReferencia.Date);
            RegistrarBitacoraSafe(idUsuarioEjecutor, "Actualizar a En curso", $"Proceso ejecutado para la fecha {fechaReferencia:yyyy-MM-dd}.");
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
