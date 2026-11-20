using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADESS
{
    // Tabla SQL: Cargo (puesto del personal).
    public class Cargo
    {
        public int IdCargo { get; set; }     // SQL: INT identidad
        public string Nombre { get; set; }   // SQL: NVARCHAR(80) unico
    }
}