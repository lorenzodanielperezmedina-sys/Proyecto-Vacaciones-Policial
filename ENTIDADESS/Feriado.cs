using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADESS
{
    // Tabla SQL: Feriado (dia que no cuenta como habil).
    public class Feriado
    {
        public int IdFeriado { get; set; }      // SQL: INT identidad
        public DateTime Fecha { get; set; }     // SQL: DATE unica
        public string Descripcion { get; set; } // SQL: NVARCHAR(100)
    }
}