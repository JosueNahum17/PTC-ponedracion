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
    public partial class frmGestorPrestamos : Form
    {
        public frmGestorPrestamos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int msg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGestionEmpleados_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(224, 224, 224);
            btnGestionEmpleados.BackColor = Color.White;
        }

        private void btnGestionPrestamos_Click(object sender, EventArgs e)
        {
            GestionPrestamos gestionPrestamos = new GestionPrestamos();
            gestionPrestamos.Show();
            this.Hide();
        }

        private void btnGestionPagos_Click(object sender, EventArgs e)
        {
            frmGestorPagos gestionPagos = new frmGestorPagos();
            gestionPagos.Show();
            this.Hide();
        }

        private void btnGestionEmpleados01_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
