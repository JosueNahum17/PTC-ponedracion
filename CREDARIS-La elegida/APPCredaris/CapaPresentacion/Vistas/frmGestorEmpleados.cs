                       using CapaPresentacion.Clases;
using CapaPresentacion.Conexion;
using CapaPresentacion.Vistas.Poppers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Vistas
{
    public partial class frmGestorEmpleados : Form
    {
        private object conexionDB;

        public frmGestorEmpleados()
        {
            InitializeComponent();
        }

        #region
        private void CargarEmpleados(string cBusqueda) {
            D_Empleados Datos = new D_Empleados();
            dgvEmpleados.DataSource = Datos.Listar_Empleados(cBusqueda);
        
        }

        #endregion
        /**
                private void frmGestorEmpleados_Load(object sender, EventArgs e)
                {
                    CargarEmpleados("%");
                }

                private void CargarEmpleados()
                {
                    try
                    {
                        using (SqlConnection conn = conexiondDB.getInstancia().crearConexion())
                        {
                            SqlDataAdapter da = new SqlDataAdapter("SP_BUSCAR_USUARIOS", conn);
                            da.SelectCommand.CommandType = CommandType.StoredProcedure;
                            da.SelectCommand.Parameters.AddWithValue("@cBusqueda", ""); // búsqueda vacía = todos

                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            // asigna directamente el DataTable al DataGridView
                            dgvEmpleados.AutoGenerateColumns = true;
                            dgvEmpleados.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar empleados: " + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
                
                }
*/



        private void btnAñadir_Click(object sender, EventArgs e)

        {
            frmAñadirEmpleadobtn AñadirEmpleado = new frmAñadirEmpleadobtn();
            AñadirEmpleado.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarEmpleadobtn frm = new frmEditarEmpleadobtn();

        frm.Show();
            

            if (dgvEmpleados.SelectedRows.Count >0) {

              

            }
            
        }







        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }







        private void EliminarEmpleado(int idUsuario)
        {
            
        
        
        }








        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmGestorEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados("%");
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            CargarEmpleados(txtBuscar.Text);
        }
    }
}
