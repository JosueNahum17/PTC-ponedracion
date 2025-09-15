namespace CapaPresentacion.ADMIN
{
    partial class frmAContenedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.btnhome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnGestionPagos = new System.Windows.Forms.Button();
            this.btnGestionPrestamos = new System.Windows.Forms.Button();
            this.btnGestionEmpleados = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.BarraTitulo.SuspendLayout();
            this.MenuVertical.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(98)))));
            this.BarraTitulo.Controls.Add(this.btnRestaurar);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnMaximizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1235, 28);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.Black;
            this.MenuVertical.Controls.Add(this.btnhome);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.btnCerrarSesion);
            this.MenuVertical.Controls.Add(this.panel3);
            this.MenuVertical.Controls.Add(this.btnGestionPagos);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.btnGestionPrestamos);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.btnGestionEmpleados);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MenuVertical.Location = new System.Drawing.Point(0, 34);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(264, 616);
            this.MenuVertical.TabIndex = 1;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 345);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 60);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(0, 279);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 60);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 213);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 60);
            this.panel1.TabIndex = 2;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.AliceBlue;
            this.panelContenedor.Controls.Add(this.lblfecha);
            this.panelContenedor.Controls.Add(this.lblhora);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(264, 34);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1261, 616);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.Gray;
            this.lblfecha.Location = new System.Drawing.Point(125, 228);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(147, 54);
            this.lblfecha.TabIndex = 1;
            this.lblfecha.Text = "label1";
            this.lblfecha.Click += new System.EventHandler(this.lblfecha_Click);
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblhora.Location = new System.Drawing.Point(118, 55);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(249, 91);
            this.lblhora.TabIndex = 0;
            this.lblhora.Text = "label1";
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.White;
            this.btnhome.Image = global::CapaPresentacion.Properties.Resources.icons8_casa_40;
            this.btnhome.Location = new System.Drawing.Point(78, 130);
            this.btnhome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(90, 61);
            this.btnhome.TabIndex = 8;
            this.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.imagen1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCerrarSesion.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = global::CapaPresentacion.Properties.Resources.icons8_logout_45;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(6, 547);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(252, 58);
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnGestionPagos
            // 
            this.btnGestionPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGestionPagos.FlatAppearance.BorderSize = 0;
            this.btnGestionPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGestionPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionPagos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionPagos.ForeColor = System.Drawing.Color.White;
            this.btnGestionPagos.Image = global::CapaPresentacion.Properties.Resources.icons8_fecha_de_pago_55;
            this.btnGestionPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionPagos.Location = new System.Drawing.Point(3, 345);
            this.btnGestionPagos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestionPagos.Name = "btnGestionPagos";
            this.btnGestionPagos.Size = new System.Drawing.Size(261, 60);
            this.btnGestionPagos.TabIndex = 5;
            this.btnGestionPagos.Text = "Gestion Pagos";
            this.btnGestionPagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionPagos.UseVisualStyleBackColor = false;
            this.btnGestionPagos.Click += new System.EventHandler(this.btnGestionPagos_Click);
            // 
            // btnGestionPrestamos
            // 
            this.btnGestionPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGestionPrestamos.FlatAppearance.BorderSize = 0;
            this.btnGestionPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGestionPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionPrestamos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionPrestamos.ForeColor = System.Drawing.Color.White;
            this.btnGestionPrestamos.Image = global::CapaPresentacion.Properties.Resources.icons8_coin_in_hand_55;
            this.btnGestionPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionPrestamos.Location = new System.Drawing.Point(3, 279);
            this.btnGestionPrestamos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestionPrestamos.Name = "btnGestionPrestamos";
            this.btnGestionPrestamos.Size = new System.Drawing.Size(261, 60);
            this.btnGestionPrestamos.TabIndex = 3;
            this.btnGestionPrestamos.Text = "Gestion Prestamos";
            this.btnGestionPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionPrestamos.UseVisualStyleBackColor = false;
            this.btnGestionPrestamos.Click += new System.EventHandler(this.btnGestionPrestamos_Click);
            // 
            // btnGestionEmpleados
            // 
            this.btnGestionEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGestionEmpleados.FlatAppearance.BorderSize = 0;
            this.btnGestionEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGestionEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionEmpleados.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnGestionEmpleados.Image = global::CapaPresentacion.Properties.Resources.icons8_usuarios_50__2_;
            this.btnGestionEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionEmpleados.Location = new System.Drawing.Point(3, 213);
            this.btnGestionEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestionEmpleados.Name = "btnGestionEmpleados";
            this.btnGestionEmpleados.Size = new System.Drawing.Size(261, 60);
            this.btnGestionEmpleados.TabIndex = 1;
            this.btnGestionEmpleados.Text = "Gestion Empleados";
            this.btnGestionEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionEmpleados.UseVisualStyleBackColor = false;
            this.btnGestionEmpleados.Click += new System.EventHandler(this.btnGestionEmpleados_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = global::CapaPresentacion.Properties.Resources.icons8_restaurar_abajo_32;
            this.btnRestaurar.Location = new System.Drawing.Point(1191, 2);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(19, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 1;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::CapaPresentacion.Properties.Resources.icons8_minimizar_24;
            this.btnMinimizar.Location = new System.Drawing.Point(1168, 3);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(19, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::CapaPresentacion.Properties.Resources.icons8_cuadrado_50;
            this.btnMaximizar.Location = new System.Drawing.Point(1191, 3);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(19, 20);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::CapaPresentacion.Properties.Resources.icons8_x_64;
            this.btnCerrar.Location = new System.Drawing.Point(1214, 3);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(19, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
<<<<<<< HEAD
=======
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.Black;
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.btnCerrarSesion);
            this.MenuVertical.Controls.Add(this.panel3);
            this.MenuVertical.Controls.Add(this.btnGestionPagos);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.btnGestionPrestamos);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.btnGestionEmpleados);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MenuVertical.Location = new System.Drawing.Point(0, 28);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(2);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(198, 500);
            this.MenuVertical.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.imagen1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCerrarSesion.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = global::CapaPresentacion.Properties.Resources.icons8_logout_45;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(4, 444);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(189, 47);
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 280);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 49);
            this.panel3.TabIndex = 6;
            // 
            // btnGestionPagos
            // 
            this.btnGestionPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGestionPagos.FlatAppearance.BorderSize = 0;
            this.btnGestionPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGestionPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionPagos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionPagos.ForeColor = System.Drawing.Color.White;
            this.btnGestionPagos.Image = global::CapaPresentacion.Properties.Resources.icons8_fecha_de_pago_55;
            this.btnGestionPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionPagos.Location = new System.Drawing.Point(2, 280);
            this.btnGestionPagos.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionPagos.Name = "btnGestionPagos";
            this.btnGestionPagos.Size = new System.Drawing.Size(196, 49);
            this.btnGestionPagos.TabIndex = 5;
            this.btnGestionPagos.Text = "Gestion Pagos";
            this.btnGestionPagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionPagos.UseVisualStyleBackColor = false;
            this.btnGestionPagos.Click += new System.EventHandler(this.btnGestionPagos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(0, 227);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 49);
            this.panel2.TabIndex = 4;
            // 
            // btnGestionPrestamos
            // 
            this.btnGestionPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGestionPrestamos.FlatAppearance.BorderSize = 0;
            this.btnGestionPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGestionPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionPrestamos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionPrestamos.ForeColor = System.Drawing.Color.White;
            this.btnGestionPrestamos.Image = global::CapaPresentacion.Properties.Resources.icons8_coin_in_hand_55;
            this.btnGestionPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionPrestamos.Location = new System.Drawing.Point(2, 227);
            this.btnGestionPrestamos.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionPrestamos.Name = "btnGestionPrestamos";
            this.btnGestionPrestamos.Size = new System.Drawing.Size(196, 49);
            this.btnGestionPrestamos.TabIndex = 3;
            this.btnGestionPrestamos.Text = "Gestion Prestamos";
            this.btnGestionPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionPrestamos.UseVisualStyleBackColor = false;
            this.btnGestionPrestamos.Click += new System.EventHandler(this.btnGestionPrestamos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 173);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 49);
            this.panel1.TabIndex = 2;
            // 
            // btnGestionEmpleados
            // 
            this.btnGestionEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGestionEmpleados.FlatAppearance.BorderSize = 0;
            this.btnGestionEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGestionEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionEmpleados.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnGestionEmpleados.Image = global::CapaPresentacion.Properties.Resources.icons8_usuarios_50__2_;
            this.btnGestionEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionEmpleados.Location = new System.Drawing.Point(2, 173);
            this.btnGestionEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionEmpleados.Name = "btnGestionEmpleados";
            this.btnGestionEmpleados.Size = new System.Drawing.Size(196, 49);
            this.btnGestionEmpleados.TabIndex = 1;
            this.btnGestionEmpleados.Text = "Gestion Empleados";
            this.btnGestionEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionEmpleados.UseVisualStyleBackColor = false;
            this.btnGestionEmpleados.Click += new System.EventHandler(this.btnGestionEmpleados_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.AliceBlue;
            this.panelContenedor.Controls.Add(this.lblfecha);
            this.panelContenedor.Controls.Add(this.lblhora);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(198, 28);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1037, 500);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblhora.Location = new System.Drawing.Point(118, 55);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(249, 91);
            this.lblhora.TabIndex = 0;
            this.lblhora.Text = "label1";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.Gray;
            this.lblfecha.Location = new System.Drawing.Point(125, 228);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(147, 54);
            this.lblfecha.TabIndex = 1;
            this.lblfecha.Text = "label1";
            this.lblfecha.Click += new System.EventHandler(this.lblfecha_Click);
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
>>>>>>> f9ecce5f19610cbe65ba69dd94eb324ff3cd910a
            // frmAContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 528);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAContenedor";
            this.Text = "Dashboard";
            this.BarraTitulo.ResumeLayout(false);
            this.MenuVertical.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Button btnGestionEmpleados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGestionPagos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGestionPrestamos;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Timer horaFecha;
        private System.Windows.Forms.Button btnhome;
    }
}