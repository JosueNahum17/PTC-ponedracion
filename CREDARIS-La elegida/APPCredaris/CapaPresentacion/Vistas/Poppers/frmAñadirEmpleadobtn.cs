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
using CapaPresentacion.Clases;

namespace CapaPresentacion.Vistas.Poppers
{
    public partial class frmAñadirEmpleadobtn : Form
    {
        private conexiondDB conexion;

        public frmAñadirEmpleadobtn()
        {
            InitializeComponent();
            conexion = conexiondDB.getInstancia();
            CargarRoles();

            // Configurar el campo de contraseña para mostrar asteriscos
            txtPassword.UseSystemPasswordChar = true;
        }

        private void CargarRoles()
        {
            try
            {
                using (SqlConnection connection = conexion.crearConexion())
                {
                    connection.Open();
                    string query = "SELECT idRol, nombreRol FROM Roles";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbRol.Items.Clear();
                    while (reader.Read())
                    {
                        cmbRol.Items.Add(new
                        {
                            Id = reader["idRol"],
                            Name = reader["nombreRol"].ToString()
                        });
                    }

                    cmbRol.DisplayMember = "Name";
                    cmbRol.ValueMember = "Id";

                    if (cmbRol.Items.Count > 0)
                        cmbRol.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message);
            }
        }

      

        private bool ValidarDatos()
        {
            if (cmbRol.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un rol");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Ingrese el apellido");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese el usuario");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Ingrese la contraseña");
                return false;
            }

            return true;
        }

        private void GuardarUsuario()
        {
            try
            {
                using (SqlConnection connection = conexion.crearConexion())
                {
                    connection.Open();

                    // Verificar si el usuario ya existe
                    string checkQuery = "SELECT COUNT(*) FROM Usuarios WHERE usuario = @usuario";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);

                    int userCount = (int)checkCmd.ExecuteScalar();

                    if (userCount > 0)
                    {
                        MessageBox.Show("El nombre de usuario ya existe. Por favor, elija otro.");
                        return;
                    }

                    // Insertar nuevo usuario
                    string query = @"INSERT INTO Usuarios (idRol, nombreUsuario, apellidoUsuario, usuario, direccion, contrasena, fechaRegistro)
                                   VALUES (@idRol, @nombre, @apellido, @usuario, @direccion, @password, GETDATE())";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idRol", ((dynamic)cmbRol.SelectedItem).Id);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@apellido", txtApellido.Text.Trim());
                    cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text.Trim());
                    cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text.Trim());

                    // Encriptar la contraseña antes de guardarla
                    string contraseñaEncriptada = Encriptacion.Encriptar(txtPassword.Text);
                    cmd.Parameters.AddWithValue("@password", contraseñaEncriptada);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Usuario guardado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar el usuario");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar usuario: " + ex.Message);
            }
        }

        

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                GuardarUsuario();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void frmAñadirEmpleadobtn_Load(object sender, EventArgs e)
        {

        }
    }
}
