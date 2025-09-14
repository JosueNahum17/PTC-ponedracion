using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CapaPresentacion.Vistas;

namespace CapaPresentacion.ADMIN
{
    public partial class frmAContenedor : Form
    {
        // Variables para mantener las instancias de los formularios secundarios
        private frmGestorPrestamos gestorPrestamosForm;
        private frmGestorPagos gestorPagosForm;
        private frmGestorEmpleados gestorEmpleadosForm;

        public frmAContenedor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método genérico para mostrar un formulario dentro de un panel contenedor.
        /// </summary>
        /// <typeparam name="T">El tipo de formulario a mostrar.</typeparam>
        /// <param name="form">La instancia del formulario.</param>
        private void MostrarFormularioEnPanel<T>(ref T form) where T : Form, new()
        {
            // Cierra el formulario anterior si existe
            if (form != null && !form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }

            // Limpia el panel contenedor
            panelContenedor.Controls.Clear();

            // Crea una nueva instancia del formulario
            form = new T();

            // Configura el formulario para que se comporte como un control dentro del panel
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Agrega el formulario al panel contenedor
            panelContenedor.Controls.Add(form);
            panelContenedor.Tag = form;

            // Muestra el formulario
            form.Show();
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

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {
            // Este es un buen lugar para mostrar un formulario de "Bienvenida"
        }

        // Los botones ahora solo necesitan llamar al método genérico
        private void btnGestionEmpleados_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(ref gestorEmpleadosForm);
        }

        private void btnGestionPrestamos_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(ref gestorPrestamosForm);
        }

        private void btnGestionPagos_Click(object sender, EventArgs e)
        {
            MostrarFormularioEnPanel(ref gestorPagosForm);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblfecha_Click(object sender, EventArgs e)
        {

        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
