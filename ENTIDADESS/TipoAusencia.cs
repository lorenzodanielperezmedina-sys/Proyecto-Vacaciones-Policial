using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADESS
{
    // Tabla SQL: TipoAusencia (cada tipo de vacacion, licencia o permiso).
    public class TipoAusencia
    {
        public int IdTipo { get; set; }             // SQL: INT identidad
        public string Nombre { get; set; }          // SQL: NVARCHAR(80)
        public string Categoria { get; set; }       // SQL: NVARCHAR(20) Fijo: "Vacacion", "Licencia" o "Permiso"
        public int DiasMaximos { get; set; }        // SQL: INT mayor que 0
        public bool RequiereDocumento { get; set; } // SQL: BIT inicia en 0
    }
}