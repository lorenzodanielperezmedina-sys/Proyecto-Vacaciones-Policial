using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADESS
{
    // Tabla SQL: EstadoSolicitud. Sus 5 filas son fijas (ver la clase Estados).
    public class EstadoSolicitud
    {
        public int IdEstado { get; set; }    // SQL: INT SIN identidad (los numeros los fijamos nosotros)
        public string Nombre { get; set; }   // SQL: NVARCHAR(30) Fijo: Pendiente, Aprobada, Rechazada, En curso, Finalizada
    }
}