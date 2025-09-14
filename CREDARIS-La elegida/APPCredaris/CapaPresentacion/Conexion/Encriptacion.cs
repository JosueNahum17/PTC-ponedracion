using System;
using System.Security.Cryptography;
using System.Text;

namespace CapaPresentacion.Clases
{
    public static class Encriptacion
    {
        public static string Encriptar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return string.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto);
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder result = new StringBuilder();

                foreach (byte b in hash)
                {
                    result.Append(b.ToString("x2"));
                }

                return result.ToString();
            }
        }
    }
}
