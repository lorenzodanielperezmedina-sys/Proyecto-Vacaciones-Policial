using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADESS
{
    // Tabla SQL: Rango (rango policial).
    public class Rango
    {
        public int IdRango { get; set; }     // SQL: INT identidad
        public string Nombre { get; set; }   // SQL: NVARCHAR(50) unico
    }
}
