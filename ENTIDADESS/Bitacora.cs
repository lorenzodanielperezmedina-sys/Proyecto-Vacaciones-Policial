using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADESS
{
    // Tabla SQL: Bitacora (registro de las acciones del sistema).
    public class Bitacora
    {
        public int IdBitacora { get; set; } // SQL: INT identidad
        public int? IdUsuario { get; set; } // SQL: INT Nulo cuando un login falla con usuario desconocido
        public string Accion { get; set; }  // SQL: NVARCHAR(100)
        public string Detalle { get; set; } // SQL: NVARCHAR(300) Nulo
        public DateTime Fecha { get; set; } // SQL: DATETIME la pone SQL Server
    }
}