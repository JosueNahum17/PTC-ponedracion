// Agrega esta clase en tu proyecto
using System;
using System.Security.Cryptography;
using System.Text;

namespace CapaPresentacion.Clases
{
    public static class Encriptacion
    {
        public static string Encriptar(string texto)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(texto));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}