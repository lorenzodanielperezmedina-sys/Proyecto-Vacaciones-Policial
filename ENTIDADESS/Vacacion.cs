using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADESS
{
    // Hija de SolicitudAusencia. Es la UNICA que descuenta dias del saldo.
    public class Vacacion : SolicitudAusencia
    {
        // Siempre true: una vacacion gasta saldo.
        public override bool DescuentaSaldo
        {
            get { return true; }
        }

        public override bool Validar(out string mensaje)
        {
            mensaje = "";
            if (FechaInicio.Date < DateTime.Today)
            {
                mensaje = "Las vacaciones no pueden comenzar en una fecha pasada.";
                return false;
            }
            return true;
        }
    }
}
