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
    public partial class frmEditar : Form
    {

        private DataGridView dgv;

        public Action SeleccionarPagoCallback { get; set; }
        public frmEditar(DataGridView dataGridView)
        {
            InitializeComponent();
            dgv = dataGridView;
        }

        #region "Variables"
        int iCodigoPagos = 0;
        #endregion

        #region "Metodos"
        //public void SeleccionarPago()
        //{
        //    iCodigoPagos = Convert.ToInt32(dgv.CurrentRow.Cells["ID"].Value);

        //    //txtIdPago.Text = dgv.CurrentRow.Cells["ID"].Value.ToString();   
        //    txtIdPrestamo.Text = dgv.CurrentRow.Cells["IDPrestamo"].Value.ToString();
        //    txtNombreCliente.Text = dgv.CurrentRow.Cells["Cliente"].Value.ToString();
        //    txtMontoPago.Text = dgv.CurrentRow.Cells["Monto"].Value.ToString();
        //    cbMetodoPago.Text = dgv.CurrentRow.Cells["MetododePago"].Value.ToString();
        //    dtpFechaPago.Value = Convert.ToDateTime(dgv.CurrentRow.Cells["FechadePago"].Value);

        //     SeleccionarPagoCallback?.Invoke();
        //}
        #endregion

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

        private void dtpFechaPago_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtIdPrestamo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void frmEditar_Load(object sender, EventArgs e)
        {
          
        }
    }
}
