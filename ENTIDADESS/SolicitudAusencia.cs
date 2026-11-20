using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADESS
{
    // Clase MADRE y ABSTRACTA: es la plantilla de toda solicitud.
    // No se puede crear con new; solo se crean sus hijas (Vacacion, Licencia, Permiso).
    // Las tres hijas se guardan en la misma tabla SQL: Solicitud.
    public abstract class SolicitudAusencia
    {
        public int IdSolicitud { get; set; }           // SQL: INT identidad
        public int IdPersonal { get; set; }            // SQL: INT
        public int IdTipo { get; set; }                // SQL: INT
        public DateTime FechaInicio { get; set; }      // SQL: DATE
        public DateTime FechaFin { get; set; }         // SQL: DATE (no menor que FechaInicio)
        public int DiasSolicitados { get; set; }       // SQL: INT (mayor que 0)
        public string Motivo { get; set; }             // SQL: NVARCHAR(300) Nulo
        public string ReferenciaDocumento { get; set; } // SQL: NVARCHAR(100) Nulo
        public int IdEstado { get; set; } = Estados.Pendiente; // SQL: INT (inicia en 1 = Pendiente)
        public int IdUsuarioRegistra { get; set; }     // SQL: INT

        // Cada hija DEBE escribir su propia validacion (polimorfismo).
        // Devuelve true si todo esta bien; si no, false y el mensaje para el usuario.
        public abstract bool Validar(out string mensaje);

        // Cada hija PUEDE cambiar esto. Por defecto NO descuenta saldo.
        // Es la unica propiedad de solo lectura de toda la capa.
        public virtual bool DescuentaSaldo
        {
            get { return false; }
        }

        // Cada hija PUEDE cambiar como cuenta los dias. Por defecto: dias habiles.
        public virtual int CalcularDias(List<DateTime> feriados)
        {
            return CalculoDias.DiasHabiles(FechaInicio, FechaFin, feriados);
        }
    }
}