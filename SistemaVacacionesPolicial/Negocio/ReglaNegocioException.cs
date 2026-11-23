using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Negocio
{
    public class ReglaNegocioException : Exception
    {
        public ReglaNegocioException(string mensaje)
            : base(mensaje)
        {
        }

        public ReglaNegocioException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {
        }
    }
}