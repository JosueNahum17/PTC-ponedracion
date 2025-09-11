using CapaPresentacion.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Vistas.Poppers
{
    public partial class frmAñadir : Form
    {
        public frmAñadir()
        {
            InitializeComponent();
        }

        #region "Metodos"

        private void CargarMetodosDePago() { 
            D_MetodoDePago Datos = new D_MetodoDePago();
            cbMetodoPago.DataSource = Datos.Listar_MetodosPagos();
            cbMetodoPago.ValueMember = "idMetodoPago";
            cbMetodoPago.DisplayMember = "nombreMetodo";
        }

        # endregion

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpNombreCliente_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void frmAñadir_Load(object sender, EventArgs e)
        {
            CargarMetodosDePago();
        }
    }
}
