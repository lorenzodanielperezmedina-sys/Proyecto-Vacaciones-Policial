using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADESS
{
    // Tabla SQL: Departamento (unidad donde trabaja el personal).
    public class Departamento
    {
        public int IdDepartamento { get; set; } // SQL: INT identidad
        public string Nombre { get; set; }      // SQL: NVARCHAR(80) unico
    }
}