using CapaPresentacion.Clases;
using CapaPresentacion.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CapaPresentacion.Datos
{
    public class D_Pagos
    {
        public DataTable Listar_Pagos(string cBusqueda)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                SqlCon = conexiondDB.getInstancia().crearConexion();
                SqlCommand Comando = new SqlCommand("SP_BUSCAR_PAGOS", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add("@cBusqueda", SqlDbType.VarChar).Value = cBusqueda;
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
        public string Guardar_Pago(E_Pagos pago)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try 
            {
                SqlCon = conexiondDB.getInstancia().crearConexion();
                SqlCommand cmd = new SqlCommand("SP_GUARDAR_PAGOS", SqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                // 🔹 Los mismos parámetros que en el SP
                cmd.Parameters.Add("@cNombreCliente", SqlDbType.VarChar).Value = pago.NombreCliente;
                cmd.Parameters.Add("@cApellidoCliente", SqlDbType.VarChar).Value = pago.ApellidoCliente;
                cmd.Parameters.Add("@cMetodoPago", SqlDbType.VarChar).Value = pago.MetodoPago;
                //cmd.Parameters.Add("@nidPrestamo", SqlDbType.Int).Value = pago.idPrestamo;
                //cmd.Parameters.Add("@nidPago", SqlDbType.Int).Value = pago.IdPago;
                cmd.Parameters.Add("@cmontoPago", SqlDbType.Decimal).Value = pago.montoPago;
                cmd.Parameters.Add("@cfechaPago", SqlDbType.DateTime).Value = pago.fechaPago;
                SqlCon.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingresó el registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally 
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public string Editar_Pago(E_Pagos pago)
        {
            string rpta = "";
            using (SqlConnection SqlCon = conexiondDB.getInstancia().crearConexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITAR_PAGOS", SqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // 🔹 Los mismos parámetros que en el SP
                    //cmd.Parameters.AddWithValue("@nidPago", pago.IdPago);
                    cmd.Parameters.Add("@cNombreCliente", SqlDbType.VarChar).Value = pago.NombreCliente;
                    cmd.Parameters.Add("@cApellidoCliente", SqlDbType.VarChar).Value = pago.ApellidoCliente;
                    cmd.Parameters.Add("@cMetodoPago", SqlDbType.VarChar).Value = pago.MetodoPago;
                    cmd.Parameters.Add("@nidPrestamo", SqlDbType.Int).Value = pago.idPrestamo;
                    cmd.Parameters.Add("@montoPago", SqlDbType.Decimal).Value = pago.montoPago;
                    cmd.Parameters.Add("@cfechaPago", SqlDbType.DateTime).Value = pago.fechaPago;

                    SqlCon.Open();
                    rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó el registro";
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            }
            return rpta;
        }
    }
}
