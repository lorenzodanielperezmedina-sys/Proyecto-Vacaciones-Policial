using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADESS
{
    // Tabla SQL: Rol. Valores de prueba: 1 Administrador, 2 Operador RRHH.
    public class Rol
    {
        public int IdRol { get; set; }       // SQL: INT identidad
        public string Nombre { get; set; }   // SQL: NVARCHAR(50) unico
    }
}