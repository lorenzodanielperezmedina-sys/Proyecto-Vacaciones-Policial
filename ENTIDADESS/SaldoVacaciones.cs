using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADESS
{
    // Tabla SQL: SaldoVacaciones (dias de vacaciones de un miembro en un anio).
    // Un solo saldo por miembro y anio.
    public class SaldoVacaciones
    {
        public int IdSaldo { get; set; }              // SQL: INT identidad
        public int IdPersonal { get; set; }           // SQL: INT apunta a Personal
        public int Anio { get; set; }                 // SQL: INT (sin enie ni tilde)
        public int DiasCorrespondientes { get; set; } // SQL: INT
        public int DiasTomados { get; set; }          // SQL: INT inicia en 0 nunca supera DiasCorrespondientes
    }
}