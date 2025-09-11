using CapaPresentacion.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CapaPresentacion.Conexion
{
    public class D_MetodoDePago
    {
        public DataTable Listar_MetodosPagos()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                SqlCon = conexiondDB.getInstancia().crearConexion();
                SqlCommand Comando = new SqlCommand("SP_BUSCAR_METODOS_PAGO", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                
                SqlCon.Open();

                resultado = Comando.ExecuteReader();
                tabla.Load(resultado);

                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }
        }
    }
}
