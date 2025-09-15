using CapaPresentacion.Clases;
using CapaPresentacion.Conexion;
using CapaPresentacion.Datos;
using CapaPresentacion.Entidades;
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

        #region "Variables"
        int iCodigosPagos = 0;
        bool bEstadoGuardar = true; // true = guardar, false = editar
        bool bEstadoEditar = true; 
        #endregion

        #region "Metodos"

        private void CargarPagos(string cBusqueda)
        {

            D_Pagos Datos = new D_Pagos();
            dataGridView1.DataSource = Datos.Listar_Pagos(cBusqueda);
            FormatoListaPagos();
        }

        private void FormatoListaPagos()
        {

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[4].Width = 163;
            dataGridView1.Columns[5].Width = 150;

        }

        private void SeleccionarPago()
        {
            
                iCodigosPagos = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idPago"].Value);

                txtIdPago.Text = dataGridView1.CurrentRow.Cells["idPago"].Value.ToString();
                txtIdPrestamo.Text = dataGridView1.CurrentRow.Cells["idPrestamo"].Value.ToString();
                txtNombreCliente.Text = dataGridView1.CurrentRow.Cells["NombreCliente"].Value.ToString();
                txtApellidoCliente.Text = dataGridView1.CurrentRow.Cells["ApellidoCliente"].Value.ToString();
                txtMontoPago.Text = dataGridView1.CurrentRow.Cells["montoPago"].Value.ToString();
                cbMetodoPago.Text = dataGridView1.CurrentRow.Cells["MetodoPago"].Value.ToString();
                dtpFechaPago.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["fechaPago"].Value);
   
            

        }

        private void CargarMetodosDePago()
        {
            D_MetodoDePago Datos = new D_MetodoDePago();
            cbMetodoPago.DataSource = Datos.Listar_MetodosPagos();
            cbMetodoPago.ValueMember = "idMetodoPago";
            cbMetodoPago.DisplayMember = "nombreMetodo";
        }

        private void ActivarTextos(bool bEstado)
        {
            txtIdPago.Enabled = bEstado;
            txtIdPrestamo.Enabled = bEstado;
            txtNombreCliente.Enabled = bEstado;
            txtApellidoCliente.Enabled = bEstado;
            txtMontoPago.Enabled = bEstado;
            cbMetodoPago.Enabled = bEstado;
            dtpFechaPago.Enabled = bEstado;

            txtBuscar.Enabled = !bEstado;
        }

        private void ActivarBotones(bool bEstado)
        {
            btnAñadir.Enabled = bEstado;
            btnEditar.Enabled = bEstado;
            btnEliminar.Enabled = bEstado;

            btnGuardar.Visible = !bEstado;
            btnCancelar.Visible = !bEstado;
        }

        private void Limpiar() 
        {
            txtNombreCliente.Clear();
            txtApellidoCliente.Clear();
            txtMontoPago.Clear();
            txtIdPago.Clear();
            txtIdPrestamo.Clear();
            cbMetodoPago.SelectedIndex = -1;
            dtpFechaPago.Value = DateTime.Now;

            iCodigosPagos = 0;
        }

        private void GuardarPagos() { 
        E_Pagos pago = new E_Pagos();   
        pago.NombreCliente = txtNombreCliente.Text.Trim();
        pago.ApellidoCliente = txtApellidoCliente.Text.Trim();
        pago.montoPago = Convert.ToDecimal(txtMontoPago.Text.Trim());
        pago.MetodoPago = cbMetodoPago.Text;
        pago.fechaPago = dtpFechaPago.Value;
        //pago.idPrestamo = Convert.ToInt32(txtIdPrestamo.Text.Trim());
        //pago.IdPago = 0;

         D_Pagos Datos = new D_Pagos(); 
         string rpta = Datos.Guardar_Pago(pago);

            if (rpta.Equals("OK"))
            {
                MessageBox.Show("El pago se guardó correctamente.", "Sistema de Gestión de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPagos("%");
                Limpiar();
                ActivarTextos(false);
                ActivarBotones(true);
            }
            else
            {
                MessageBox.Show(rpta, "Sistema de Gestión de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarTextos() 
        {
            bool hayTexto = false;
            if (string.IsNullOrEmpty(txtNombreCliente.Text)) hayTexto = true;
            if (string.IsNullOrEmpty(txtApellidoCliente.Text)) hayTexto = true;
            if (string.IsNullOrEmpty(txtMetodoPago.Text)) hayTexto = true;
            if (string.IsNullOrEmpty(txtMontoPago.Text)) hayTexto = true;
            if(string.IsNullOrEmpty(dtpFechaPago.Text)) hayTexto = true;
            //if (cbMetodoPago.SelectedIndex == -1) hayTexto = true;
            return hayTexto;
        }

        private void EditarPagos() {
            E_Pagos pago = new E_Pagos();
            txtIdPago.Text = iCodigosPagos.ToString();

            pago.NombreCliente = txtNombreCliente.Text.Trim();
            pago.ApellidoCliente = txtApellidoCliente.Text.Trim();
            pago.montoPago = Convert.ToDecimal(txtMontoPago.Text.Trim());
            pago.MetodoPago = cbMetodoPago.Text;
            pago.fechaPago = dtpFechaPago.Value;
            pago.idPrestamo = Convert.ToInt32(txtIdPrestamo.Text.Trim());
            pago.IdPago = 0;

            D_Pagos Datos = new D_Pagos();
            string rpta = Datos.Editar_Pago(pago);

            if (rpta.Equals("OK"))
            {
                MessageBox.Show("El pago se editó correctamente.", "Sistema de Gestión de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPagos("%");
                Limpiar();
                ActivarTextos(false);
                ActivarBotones(true);
            }
            else
            {
                MessageBox.Show(rpta, "Sistema de Gestión de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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



        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            bEstadoGuardar = true;
            iCodigosPagos = 0;


            bEstadoGuardar = true;

            ActivarTextos(true);
            ActivarBotones(false);

            txtNombreCliente.Select();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (iCodigosPagos == 0)
            {
                MessageBox.Show("Seleccinar un registro.", "Sistema de Gestion de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ActivarTextos(true);
                ActivarBotones(false);

                txtNombreCliente.Select();

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ActivarTextos(true);
            ActivarBotones(false);
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GestionPagos_Load(object sender, EventArgs e)
        {
            CargarPagos("%");
            CargarMetodosDePago();

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

        private void txtIdPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdPrestamo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMontoPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarPago();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bEstadoEditar = false;
            if (ValidarTextos())
            {
                MessageBox.Show("Debes de llenar todos los campos (*) obligatorios", "Sitema Gestion de Pagos.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else

            {
                if (bEstadoGuardar)
                {
                    GuardarPagos();

                }
                else {
                    EditarPagos();
                    ActivarTextos(false);
                    ActivarBotones(true);
                    Limpiar();
                    txtNombreCliente.Select();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bEstadoGuardar = true;
            iCodigosPagos = 0;

            ActivarTextos(false);
            ActivarBotones(true);
            Limpiar();
            txtNombreCliente.Select();

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
