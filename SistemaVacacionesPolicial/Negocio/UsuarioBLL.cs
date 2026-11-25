using Datos;
using ENTIDADESS;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class UsuarioBLL
    {
        private readonly UsuarioDAL usuarioDal = new UsuarioDAL();
        private readonly BitacoraDAL bitacoraDal = new BitacoraDAL();

        public Usuario IniciarSesion(string nombreUsuario, string clave)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(clave))
                throw new ReglaNegocioException("Debe ingresar el usuario y la contraseña.");

            Usuario usuario = usuarioDal.ObtenerPorNombre(nombreUsuario.Trim());

            if (usuario == null || !SeguridadHelper.VerificarHash(clave, usuario.ClaveHash))
            {
                RegistrarBitacoraSafe(0, "Login fallido", $"Intento fallido para el usuario '{nombreUsuario.Trim()}'.");
                throw new ReglaNegocioException("Usuario o contraseña incorrectos.");
            }

            if (!usuario.Activo)
            {
                RegistrarBitacoraSafe(usuario.IdUsuario, "Login bloqueado", $"Usuario inactivo '{usuario.NombreUsuario}' intentó ingresar.");
                throw new ReglaNegocioException("El usuario se encuentra inactivo. Contacte al administrador.");
            }

            RegistrarBitacoraSafe(usuario.IdUsuario, "Login exitoso", $"Inicio de sesión correcto de {usuario.NombreUsuario}.");

            return usuario;
        }

        public DataTable ListarDetalle()
        {
            return usuarioDal.ListarDetalle();
        }

        public void Guardar(Usuario u, string claveNueva, int idUsuarioEjecutor)
        {
            if (u == null)
                throw new ReglaNegocioException("Los datos del usuario son obligatorios.");

            if (string.IsNullOrWhiteSpace(u.NombreUsuario))
                throw new ReglaNegocioException("El nombre de usuario es obligatorio.");

            if (string.IsNullOrWhiteSpace(u.NombreCompleto))
                throw new ReglaNegocioException("El nombre completo es obligatorio.");

            if (u.IdRol <= 0)
                throw new ReglaNegocioException("Debe seleccionar un rol válido.");

            u.NombreUsuario = u.NombreUsuario.Trim();
            u.NombreCompleto = u.NombreCompleto.Trim();

            if (u.IdUsuario == 0)
            {
                if (string.IsNullOrWhiteSpace(claveNueva) || claveNueva.Length < 8)
                    throw new ReglaNegocioException("Para un usuario nuevo, la contraseña debe tener al menos 8 caracteres.");

                u.ClaveHash = SeguridadHelper.GenerarHashSha256(claveNueva);
                u.Activo = true;

                usuarioDal.Insertar(u);
                RegistrarBitacoraSafe(idUsuarioEjecutor, "Crear usuario", $"Se creó el usuario '{u.NombreUsuario}'.");
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(claveNueva))
                {
                    if (claveNueva.Length < 8)
                        throw new ReglaNegocioException("La nueva contraseña debe tener al menos 8 caracteres.");

                    string nuevoHash = SeguridadHelper.GenerarHashSha256(claveNueva);
                    ActualizarClave(u.IdUsuario, nuevoHash, idUsuarioEjecutor);
                }

                usuarioDal.Actualizar(u);
                RegistrarBitacoraSafe(idUsuarioEjecutor, "Editar usuario", $"Se modificó el usuario '{u.NombreUsuario}'.");
            }
        }

        public void ActualizarClave(int idUsuario, string claveHash, int idUsuarioEjecutor)
        {
            if (idUsuario <= 0)
                throw new ReglaNegocioException("El identificador de usuario no es válido.");

            if (string.IsNullOrWhiteSpace(claveHash))
                throw new ReglaNegocioException("El hash de contraseña no puede estar vacío.");

            usuarioDal.ActualizarClave(idUsuario, claveHash);
            RegistrarBitacoraSafe(idUsuarioEjecutor, "Cambio de clave", $"Se actualizó la clave del usuario ID {idUsuario}.");
        }

        public void Desactivar(int idUsuario, int idUsuarioEjecutor)
        {
            if (idUsuario <= 0)
                throw new ReglaNegocioException("El identificador de usuario no es válido.");

            usuarioDal.Eliminar(idUsuario);
            RegistrarBitacoraSafe(idUsuarioEjecutor, "Desactivar usuario", $"Se desactivó el usuario ID {idUsuario}.");
        }

        private void RegistrarBitacoraSafe(int idUsuario, string accion, string detalle)
        {
            try
            {
                Bitacora registro = new Bitacora
                {
                    IdUsuario = idUsuario,
                    Accion = accion,
                    Detalle = detalle,
                    Fecha = DateTime.Now
                };

                bitacoraDal.Insertar(registro);
            }
            catch
            {
                // No bloquear la operación principal si falla el registro de bitácora
            }
        }
    }
}