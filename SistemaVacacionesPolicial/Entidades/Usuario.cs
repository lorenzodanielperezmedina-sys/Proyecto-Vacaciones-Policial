using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADESS
{
    // Tabla SQL: Usuario (quien inicia sesion en el sistema).
    public class Usuario
    {
        public int IdUsuario { get; set; }          // SQL: INT identidad
        public int IdRol { get; set; }              // SQL: INT apunta a Rol
        public string NombreUsuario { get; set; }   // SQL: NVARCHAR(50) unico
        public string NombreCompleto { get; set; }  // SQL: NVARCHAR(100)
        public string ClaveHash { get; set; }       // SQL: NVARCHAR(64) huella SHA-256, nunca la clave real
        public bool Activo { get; set; }            // SQL: BIT inicia en 1
        public string NombreRol { get; set; }       // SQL: no se guarda (solo para mostrar en pantalla)
        public DateTime? UltimoAcceso { get; set; } // SQL: no se guarda (solo para mostrar) Nulo
    }
}