using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace CapaPresentacion.Clases
{
    class conexiondDB
    {
        private string Base;
        private string Servidor;
        private static conexiondDB Con = null;
            
        private conexiondDB() {

<<<<<<< HEAD
            this.Servidor = "(localdb)\\MSSQLLocalDB"; 
            this.Base = "Test_Apha01"; 
=======
            this.Servidor = "NAHUM";
            this.Base = "Test_Apha01";
>>>>>>> 70aba8eafe3f3c38a84f0a6397916a3591aabae8
        }
 
    
        public SqlConnection crearConexion()
        {
            SqlConnection cadena = new SqlConnection();

            try
            {
                cadena.ConnectionString = "Server=" + this.Servidor +
                                          ";DataBase=" + this.Base +
                                          ";Integrated Security = True";

            }
            catch (Exception e)
            { 
                cadena = null;
                throw e;
            }


            return cadena;
        }

        public static conexiondDB getInstancia()
        {
            if (Con == null) { 
                Con = new conexiondDB();
            }
            return Con;
        }
    }
}
