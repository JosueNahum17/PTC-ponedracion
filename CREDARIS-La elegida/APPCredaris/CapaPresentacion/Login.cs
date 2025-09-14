using CapaPresentacion.ADMIN;
using CapaPresentacion.Clases;
using System;
using System.Drawing;
using System.Windows.Forms;
using CapaPresentacion.Conexion;

namespace CapaPresentacion
{
    public partial class Login : Form
    {

        

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.White;
            pnlUsuario.BackColor = Color.White;
            pnlContrasena.BackColor = SystemColors.Control;
            txtContrasena.BackColor = SystemColors.Control;
        }

        private void txtContrasena_Click(object sender, EventArgs e)
        {
            txtContrasena.BackColor = Color.White;
            pnlContrasena.BackColor = Color.White;
            txtUsuario.BackColor = SystemColors.Control;
            pnlUsuario.BackColor = SystemColors.Control;
        }

        private void ptbImgContrasena_MouseDown(object sender, MouseEventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = false;
        }

        private void ptbImgContrasena_MouseUp(object sender, MouseEventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = false;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;

            // Validación de campos vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, complete todos los campos",
                               "Campos incompletos",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }

            //  ESTA ES LA PARTE IMPORTANTE QUE FALTA
            // Llama a tu clase Logincs para verificar en la BD
            if (Logincs.VerificarLogin(usuario, contrasena))
            {
                frmAContenedor dashboard = new frmAContenedor();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos",
                               "Error de inicio de sesión",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        

        private void ptbImgContrasena_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_MouseHover(object sender, EventArgs e)
        {
            closebtn.BackColor = Color.Red;
            closebtn.ForeColor = Color.White;
        }

        private void closebtn_MouseLeave(object sender, EventArgs e)
        {
            closebtn.BackColor = Color.White;
            closebtn.ForeColor = Color.Red;
        }
    }
}
