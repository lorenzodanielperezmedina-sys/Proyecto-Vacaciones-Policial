using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADESS
{
    // Tabla SQL: HistorialAprobacion (quien aprobo o rechazo y por que).
    public class HistorialAprobacion
    {
        public int IdHistorial { get; set; }   // SQL: INT identidad
        public int IdSolicitud { get; set; }   // SQL: INT apunta a Solicitud
        public int IdUsuario { get; set; }     // SQL: INT apunta a Usuario
        public string Decision { get; set; }   // SQL: NVARCHAR(20) Fijo: "Aprobada" o "Rechazada"
        public string Comentario { get; set; } // SQL: NVARCHAR(300) Nulo
        public DateTime Fecha { get; set; }    // SQL: DATETIME la pone SQL Server al guardar
    }
}