using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CapaPresentacion.ADMIN
{
    public partial class GestionPrestamos : Form
    {
        public GestionPrestamos()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int msg, int wParam, int lParam);
        private void btnRestaurar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionPrestamos_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionPagos_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionEmpleados01_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
     
        }

        private void btnGestionEmpleados_Click_1(object sender, EventArgs e)
        {
            frmGestorPrestamos gestionEmpleados = new frmGestorPrestamos();
            gestionEmpleados.Show();
            this.Hide();
        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {
           
        }




    }
}
