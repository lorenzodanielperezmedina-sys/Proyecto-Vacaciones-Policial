using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    public static class Estado
    {
        // Busca la ventana principal abierta y le envía el mensaje.
        public static void Mostrar(string mensaje)
        {
            frmPrincipal principal = Application.OpenForms
                .OfType<frmPrincipal>()
                .FirstOrDefault();

            if (principal != null)
            {
                principal.MostrarMensaje(mensaje);
            }
        }
    }
}