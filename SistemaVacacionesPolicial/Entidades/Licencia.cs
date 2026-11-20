using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADESS
{
    // Hija de SolicitudAusencia. Puede exigir un certificado (por ejemplo, medico).
    public class Licencia : SolicitudAusencia
    {
        // No se guarda en SQL: la llena Negocio (desde el tipo) justo antes de validar.
        public bool RequiereDocumento { get; set; }

        public override bool Validar(out string mensaje)
        {
            mensaje = "";
            if (RequiereDocumento && string.IsNullOrWhiteSpace(ReferenciaDocumento))
            {
                mensaje = "Este tipo de licencia exige el número o descripción del certificado.";
                return false;
            }
            return true;
        }
    }
}
