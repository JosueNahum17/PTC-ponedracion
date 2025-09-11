using CapaPresentacion.Clases;
using CapaPresentacion.Datos;
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

namespace CapaPresentacion.ADMIN
{
    public partial class frmGestorPagos : Form
    {
        public frmGestorPagos()
        {
            InitializeComponent();
        }

        #region "Metodods"

        private void CargarPagos(string cBusqueda) {

            D_Pagos Datos = new D_Pagos();
            dataGridView1.DataSource = Datos.Listar_Pagos(cBusqueda);
            FormatoListaPagos();
        }

        private void FormatoListaPagos() {

            dataGridView1.Columns[0].Width = 250;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
        }

        #endregion ""

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnMinimizar_Click(object sender, EventArgs e)
        {

        }

        //private void btnRestaurar_Click_1(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Normal;
        //    btnRestaurar.Visible = false;
        //    btnMaximizar.Visible = true;
        //}

        private void btnGestionEmpleados_Click(object sender, EventArgs e)
        {
            frmGestorPrestamos gestionEmpleados = new frmGestorPrestamos();
            gestionEmpleados.Show();
            this.Hide();

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            frmAñadir frmAñadir = new frmAñadir();
            frmAñadir.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GestionPagos_Load(object sender, EventArgs e)
        {
            CargarPagos("%");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarPagos(txtBuscar.Text);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            CargarPagos(txtBuscar.Text);

        }

        private void btnGestionPrestamos_Click(object sender, EventArgs e)
        {
            GestionPrestamos gestionPrestamos = new GestionPrestamos();
            gestionPrestamos.Show();
        }
    }
}
