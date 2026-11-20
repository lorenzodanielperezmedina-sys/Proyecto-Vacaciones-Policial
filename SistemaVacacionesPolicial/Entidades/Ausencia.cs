using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADESS
{
    // Tabla SQL: Ausencia (la ausencia real de una solicitud aprobada).
    // Una sola por solicitud aprobada.
    public class Ausencia
    {
        public int IdAusencia { get; set; }                     // SQL: INT identidad
        public int IdSolicitud { get; set; }                    // SQL: INT apunta a Solicitud
        public DateTime? FechaInicioReal { get; set; }          // SQL: DATE Nulo hasta que ocurre
        public DateTime FechaReincorporacionPrevista { get; set; } // SQL: DATE
        public DateTime? FechaReincorporacionReal { get; set; } // SQL: DATE Nulo hasta que ocurre
    }
}