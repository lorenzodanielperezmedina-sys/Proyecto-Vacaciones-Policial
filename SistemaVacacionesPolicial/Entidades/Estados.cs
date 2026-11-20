using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADESS
{
    // Numeros fijos de los estados de una solicitud.
    // Todos los proyectos los usan igual: nunca escribas 1, 2, 3... a mano.
    public static class Estados
    {
        public const int Pendiente = 1;   // Recien registrada, espera decision
        public const int Aprobada = 2;    // RRHH la aprobo
        public const int Rechazada = 3;   // RRHH la rechazo (estado final)
        public const int EnCurso = 4;     // Llego la fecha de inicio
        public const int Finalizada = 5;  // Ya se registro la reincorporacion (estado final)
    }
}
