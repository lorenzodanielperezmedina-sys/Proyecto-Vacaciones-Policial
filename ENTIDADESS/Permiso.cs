using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADESS
{
    // Hija de SolicitudAusencia. El motivo es obligatorio.
    public class Permiso : SolicitudAusencia
    {
        public override bool Validar(out string mensaje)
        {
            mensaje = "";
            if (string.IsNullOrWhiteSpace(Motivo))
            {
                mensaje = "Un permiso debe llevar el motivo.";
                return false;
            }
            return true;
        }
    }
}