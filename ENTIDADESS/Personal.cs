using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADESS
{
    // Tabla SQL: Personal (miembro policial cuyas ausencias se controlan).
    // Abstraccion: solo guarda lo esencial de la persona.
    public class Personal
    {
        public int IdPersonal { get; set; }      // SQL: INT identidad
        public string Cedula { get; set; }       // SQL: NVARCHAR(13) unico formato 000-0000000-0
        public string Nombres { get; set; }      // SQL: NVARCHAR(100)
        public string Apellidos { get; set; }    // SQL: NVARCHAR(100)
        public int IdRango { get; set; }         // SQL: INT apunta a Rango
        public int IdDepartamento { get; set; }  // SQL: INT apunta a Departamento
        public int IdCargo { get; set; }         // SQL: INT apunta a Cargo
        public DateTime FechaIngreso { get; set; } // SQL: DATE no puede ser futura
        public string Correo { get; set; }       // SQL: NVARCHAR(100) Nulo
        public bool Activo { get; set; }         // SQL: BIT inicia en 1 (baja = 0)
    }
}
