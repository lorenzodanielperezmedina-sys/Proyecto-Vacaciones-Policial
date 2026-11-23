using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class SeguridadHelper
    {
        public static string GenerarHashSha256(string textoPlano)
        {
            if (string.IsNullOrEmpty(textoPlano))
                return string.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(textoPlano);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder(64);
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        public static bool VerificarHash(string textoPlano, string hashAlmacenado)
        {
            if (string.IsNullOrWhiteSpace(textoPlano) || string.IsNullOrWhiteSpace(hashAlmacenado))
                return false;

            string hashCalculado = GenerarHashSha256(textoPlano);
            return string.Equals(hashCalculado, hashAlmacenado.Trim(), StringComparison.OrdinalIgnoreCase);
        }
    }
}