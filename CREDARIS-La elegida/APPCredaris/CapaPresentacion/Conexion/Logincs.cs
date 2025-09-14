using System;
using System.Data.SqlClient;

namespace CapaPresentacion.Clases
{
    public class Logincs
    {
        public static bool VerificarLogin(string usuario, string contrasena)
        {
            bool resultado = false;

            SqlConnection cn = null;
            try
            {
                // Abro conexión
                cn = conexiondDB.getInstancia().crearConexion();
                cn.Open();

                // Consulta
                string query = "SELECT COUNT(*) FROM Usuarios WHERE usuario = @usuario AND contrasena = @contrasena";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                // Si encontró al menos 1 fila, login válido
                if (count > 0)
                    resultado = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar login: " + ex.Message);
            }
            finally
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                    cn.Close();
            }

            return resultado;
        }
    }
}
