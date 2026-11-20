using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADESS
{
    // Ayudante estatico para contar dias habiles.
    // Dia habil = no sabado, no domingo y no feriado.
    public static class CalculoDias
    {
        // Indica si una fecha corresponde a un dia habil.
        public static bool EsDiaHabil(DateTime fecha, List<DateTime> feriados)
        {
            if (fecha.DayOfWeek == DayOfWeek.Saturday || fecha.DayOfWeek == DayOfWeek.Sunday)
            {
                return false;
            }

            if (feriados == null)
            {
                return true;
            }

            return !feriados.Any(f => f.Date == fecha.Date);
        }

        // Cuenta los dias habiles entre dos fechas (ambas incluidas).
        public static int DiasHabiles(DateTime inicio, DateTime fin, List<DateTime> feriados)
        {
            int total = 0;
            for (DateTime dia = inicio.Date; dia <= fin.Date; dia = dia.AddDays(1))
            {
                if (EsDiaHabil(dia, feriados))
                {
                    total++;
                }
            }
            return total;
        }

        // Primer dia habil DESPUES de la fecha fin (dia de reincorporacion).
        public static DateTime SiguienteDiaHabil(DateTime fechaFin, List<DateTime> feriados)
        {
            DateTime dia = fechaFin.Date.AddDays(1);
            while (!EsDiaHabil(dia, feriados))
            {
                dia = dia.AddDays(1);
            }
            return dia;
        }
    }
}
