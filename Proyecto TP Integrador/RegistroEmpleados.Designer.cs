namespace Proyecto_TP_Integrador
{
    partial class RegistroEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdministradorEmpleados = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.cmbProvincias = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVisualizarGrilla = new System.Windows.Forms.Button();
            this.btnActualizarEmpleado = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grillaEmpleados = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApeEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRepetirContrasena = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSucursalEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbPuestoEmpleado = new System.Windows.Forms.ComboBox();
            this.txtPaisEmpleado = new System.Windows.Forms.TextBox();
            this.txtAlturaEmpleado = new System.Windows.Forms.TextBox();
            this.txtCalleEmpleado = new System.Windows.Forms.TextBox();
            this.txtTelefonoEmpleado = new System.Windows.Forms.TextBox();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.btnRegistrarEmpleado = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPuestoEmpleado = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPaisEmpleado = new System.Windows.Forms.Label();
            this.lblLocalidadEmpleado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblAdministradorEmpleados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblAdministradorEmpleados
            // 
            this.lblAdministradorEmpleados.AutoSize = true;
            this.lblAdministradorEmpleados.Font = new System.Drawing.Font("Perpetua", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministradorEmpleados.Location = new System.Drawing.Point(247, 20);
            this.lblAdministradorEmpleados.Name = "lblAdministradorEmpleados";
            this.lblAdministradorEmpleados.Size = new System.Drawing.Size(690, 54);
            this.lblAdministradorEmpleados.TabIndex = 0;
            this.lblAdministradorEmpleados.Text = "ADMINISTRADOR DE EMPLEADOS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.cmbLocalidad);
            this.panel2.Controls.Add(this.cmbProvincias);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btnEliminarEmpleado);
            this.panel2.Controls.Add(this.btnAtras);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtIdUsuario);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnVisualizarGrilla);
            this.panel2.Controls.Add(this.btnActualizarEmpleado);
            this.panel2.Controls.Add(this.btnLimpiarCampos);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtRepetirContrasena);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Controls.Add(this.txtContrasena);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cmbSucursalEmpleado);
            this.panel2.Controls.Add(this.cmbPuestoEmpleado);
            this.panel2.Controls.Add(this.txtPaisEmpleado);
            this.panel2.Controls.Add(this.txtAlturaEmpleado);
            this.panel2.Controls.Add(this.txtCalleEmpleado);
            this.panel2.Controls.Add(this.txtTelefonoEmpleado);
            this.panel2.Controls.Add(this.txtApellidoEmpleado);
            this.panel2.Controls.Add(this.txtNombreEmpleado);
            this.panel2.Controls.Add(this.btnRegistrarEmpleado);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblPuestoEmpleado);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblPaisEmpleado);
            this.panel2.Controls.Add(this.lblLocalidadEmpleado);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1252, 582);
            this.panel2.TabIndex = 1;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(419, 240);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(248, 37);
            this.cmbLocalidad.TabIndex = 42;
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Location = new System.Drawing.Point(419, 156);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(248, 37);
            this.cmbProvincias.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(315, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 27);
            this.label13.TabIndex = 40;
            this.label13.Text = "Provincia:";
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminarEmpleado.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(709, 527);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(228, 43);
            this.btnEliminarEmpleado.TabIndex = 39;
            this.btnEliminarEmpleado.Text = "Eliminar empleado";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(1104, 6);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(94, 27);
            this.btnAtras.TabIndex = 38;
            this.btnAtras.Text = "ATRAS";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(47, 531);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 27);
            this.label10.TabIndex = 37;
            this.label10.Text = "ID:";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Enabled = false;
            this.txtIdUsuario.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.ForeColor = System.Drawing.Color.Red;
            this.txtIdUsuario.Location = new System.Drawing.Point(93, 528);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(66, 34);
            this.txtIdUsuario.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(364, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "*Campos obligatorios";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Perpetua", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(364, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "*Campos obligatorios";
            // 
            // btnVisualizarGrilla
            // 
            this.btnVisualizarGrilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVisualizarGrilla.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarGrilla.ForeColor = System.Drawing.Color.White;
            this.btnVisualizarGrilla.Location = new System.Drawing.Point(913, 57);
            this.btnVisualizarGrilla.Name = "btnVisualizarGrilla";
            this.btnVisualizarGrilla.Size = new System.Drawing.Size(228, 52);
            this.btnVisualizarGrilla.TabIndex = 32;
            this.btnVisualizarGrilla.Text = "Visualizar Grilla";
            this.btnVisualizarGrilla.UseVisualStyleBackColor = false;
            this.btnVisualizarGrilla.Click += new System.EventHandler(this.btnVisualizarGrilla_Click);
            // 
            // btnActualizarEmpleado
            // 
            this.btnActualizarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActualizarEmpleado.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnActualizarEmpleado.Location = new System.Drawing.Point(709, 463);
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(228, 52);
            this.btnActualizarEmpleado.TabIndex = 31;
            this.btnActualizarEmpleado.Text = "Actualizar Empleado";
            this.btnActualizarEmpleado.UseVisualStyleBackColor = false;
            this.btnActualizarEmpleado.Click += new System.EventHandler(this.btnActualizarEmpleado_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.Yellow;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(453, 524);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(169, 40);
            this.btnLimpiarCampos.TabIndex = 30;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.grillaEmpleados);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Location = new System.Drawing.Point(722, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(498, 269);
            this.panel3.TabIndex = 29;
            // 
            // grillaEmpleados
            // 
            this.grillaEmpleados.AllowUserToAddRows = false;
            this.grillaEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grillaEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NombreDeUsuario,
            this.Password,
            this.NomEmpleado,
            this.ApeEmpleado,
            this.IdPuesto,
            this.IdSucursal});
            this.grillaEmpleados.EnableHeadersVisualStyles = false;
            this.grillaEmpleados.GridColor = System.Drawing.Color.White;
            this.grillaEmpleados.Location = new System.Drawing.Point(0, 29);
            this.grillaEmpleados.Name = "grillaEmpleados";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grillaEmpleados.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            this.grillaEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grillaEmpleados.RowTemplate.Height = 24;
            this.grillaEmpleados.Size = new System.Drawing.Size(495, 237);
            this.grillaEmpleados.TabIndex = 31;
            this.grillaEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaEmpleados_CellClick);
            this.grillaEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaEmpleados_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IdUsuario";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 52;
            // 
            // NombreDeUsuario
            // 
            this.NombreDeUsuario.DataPropertyName = "NombreDeUsuario";
            this.NombreDeUsuario.HeaderText = "Usuario";
            this.NombreDeUsuario.MinimumWidth = 6;
            this.NombreDeUsuario.Name = "NombreDeUsuario";
            this.NombreDeUsuario.Width = 90;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Contraseña";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 112;
            // 
            // NomEmpleado
            // 
            this.NomEmpleado.DataPropertyName = "NomEmpleado";
            this.NomEmpleado.HeaderText = "Nombre";
            this.NomEmpleado.MinimumWidth = 6;
            this.NomEmpleado.Name = "NomEmpleado";
            this.NomEmpleado.Width = 93;
            // 
            // ApeEmpleado
            // 
            this.ApeEmpleado.DataPropertyName = "ApeEmpleado";
            this.ApeEmpleado.HeaderText = "Apellido";
            this.ApeEmpleado.MinimumWidth = 6;
            this.ApeEmpleado.Name = "ApeEmpleado";
            this.ApeEmpleado.Width = 93;
            // 
            // IdPuesto
            // 
            this.IdPuesto.DataPropertyName = "NomPuesto";
            this.IdPuesto.HeaderText = "Puesto";
            this.IdPuesto.MinimumWidth = 6;
            this.IdPuesto.Name = "IdPuesto";
            this.IdPuesto.Width = 82;
            // 
            // IdSucursal
            // 
            this.IdSucursal.DataPropertyName = "NomSucursal";
            this.IdSucursal.HeaderText = "Sucursal";
            this.IdSucursal.MinimumWidth = 6;
            this.IdSucursal.Name = "IdSucursal";
            this.IdSucursal.Width = 93;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(202, 35);
            this.label16.TabIndex = 30;
            this.label16.Text = "Grilla Empleados";
            // 
            // txtRepetirContrasena
            // 
            this.txtRepetirContrasena.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepetirContrasena.Location = new System.Drawing.Point(405, 475);
            this.txtRepetirContrasena.Name = "txtRepetirContrasena";
            this.txtRepetirContrasena.Size = new System.Drawing.Size(248, 34);
            this.txtRepetirContrasena.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(194, 475);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(196, 27);
            this.label15.TabIndex = 27;
            this.label15.Text = "REPETIR contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(139, 425);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(141, 34);
            this.txtUsuario.TabIndex = 10;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(405, 425);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(248, 34);
            this.txtContrasena.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(286, 429);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 27);
            this.label14.TabIndex = 24;
            this.label14.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(44, 428);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(84, 27);
            this.lblUsuario.TabIndex = 23;
            this.lblUsuario.Text = "Usuario:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(44, 388);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(285, 27);
            this.label12.TabIndex = 22;
            this.label12.Text = "INFORMACION DE INGRESO";
            // 
            // cmbSucursalEmpleado
            // 
            this.cmbSucursalEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSucursalEmpleado.FormattingEnabled = true;
            this.cmbSucursalEmpleado.Location = new System.Drawing.Point(419, 322);
            this.cmbSucursalEmpleado.Name = "cmbSucursalEmpleado";
            this.cmbSucursalEmpleado.Size = new System.Drawing.Size(248, 37);
            this.cmbSucursalEmpleado.TabIndex = 9;
            // 
            // cmbPuestoEmpleado
            // 
            this.cmbPuestoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuestoEmpleado.FormattingEnabled = true;
            this.cmbPuestoEmpleado.Location = new System.Drawing.Point(139, 322);
            this.cmbPuestoEmpleado.Name = "cmbPuestoEmpleado";
            this.cmbPuestoEmpleado.Size = new System.Drawing.Size(179, 37);
            this.cmbPuestoEmpleado.TabIndex = 8;
            // 
            // txtPaisEmpleado
            // 
            this.txtPaisEmpleado.Enabled = false;
            this.txtPaisEmpleado.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaisEmpleado.Location = new System.Drawing.Point(419, 200);
            this.txtPaisEmpleado.Name = "txtPaisEmpleado";
            this.txtPaisEmpleado.Size = new System.Drawing.Size(248, 34);
            this.txtPaisEmpleado.TabIndex = 7;
            this.txtPaisEmpleado.Text = "Argentina";
            // 
            // txtAlturaEmpleado
            // 
            this.txtAlturaEmpleado.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlturaEmpleado.Location = new System.Drawing.Point(139, 210);
            this.txtAlturaEmpleado.Name = "txtAlturaEmpleado";
            this.txtAlturaEmpleado.Size = new System.Drawing.Size(65, 34);
            this.txtAlturaEmpleado.TabIndex = 5;
            // 
            // txtCalleEmpleado
            // 
            this.txtCalleEmpleado.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalleEmpleado.Location = new System.Drawing.Point(139, 160);
            this.txtCalleEmpleado.Name = "txtCalleEmpleado";
            this.txtCalleEmpleado.Size = new System.Drawing.Size(141, 34);
            this.txtCalleEmpleado.TabIndex = 4;
            // 
            // txtTelefonoEmpleado
            // 
            this.txtTelefonoEmpleado.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoEmpleado.Location = new System.Drawing.Point(673, 67);
            this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            this.txtTelefonoEmpleado.Size = new System.Drawing.Size(141, 34);
            this.txtTelefonoEmpleado.TabIndex = 3;
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(419, 67);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(141, 34);
            this.txtApellidoEmpleado.TabIndex = 2;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpleado.Location = new System.Drawing.Point(139, 67);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(141, 34);
            this.txtNombreEmpleado.TabIndex = 1;
            // 
            // btnRegistrarEmpleado
            // 
            this.btnRegistrarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegistrarEmpleado.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarEmpleado.Location = new System.Drawing.Point(955, 463);
            this.btnRegistrarEmpleado.Name = "btnRegistrarEmpleado";
            this.btnRegistrarEmpleado.Size = new System.Drawing.Size(228, 52);
            this.btnRegistrarEmpleado.TabIndex = 12;
            this.btnRegistrarEmpleado.Text = "Registrar empleado";
            this.btnRegistrarEmpleado.UseVisualStyleBackColor = false;
            this.btnRegistrarEmpleado.Click += new System.EventHandler(this.btnRegistrarEmpleado_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(324, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 27);
            this.label11.TabIndex = 11;
            this.label11.Text = "Sucursal:";
            // 
            // lblPuestoEmpleado
            // 
            this.lblPuestoEmpleado.AutoSize = true;
            this.lblPuestoEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblPuestoEmpleado.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuestoEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblPuestoEmpleado.Location = new System.Drawing.Point(57, 329);
            this.lblPuestoEmpleado.Name = "lblPuestoEmpleado";
            this.lblPuestoEmpleado.Size = new System.Drawing.Size(76, 27);
            this.lblPuestoEmpleado.TabIndex = 10;
            this.lblPuestoEmpleado.Text = "Puesto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(44, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 27);
            this.label9.TabIndex = 9;
            this.label9.Text = "INFORMACION ADICIONAL";
            // 
            // lblPaisEmpleado
            // 
            this.lblPaisEmpleado.AutoSize = true;
            this.lblPaisEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblPaisEmpleado.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaisEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblPaisEmpleado.Location = new System.Drawing.Point(362, 198);
            this.lblPaisEmpleado.Name = "lblPaisEmpleado";
            this.lblPaisEmpleado.Size = new System.Drawing.Size(51, 27);
            this.lblPaisEmpleado.TabIndex = 8;
            this.lblPaisEmpleado.Text = "Pais:";
            // 
            // lblLocalidadEmpleado
            // 
            this.lblLocalidadEmpleado.AutoSize = true;
            this.lblLocalidadEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblLocalidadEmpleado.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidadEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblLocalidadEmpleado.Location = new System.Drawing.Point(313, 243);
            this.lblLocalidadEmpleado.Name = "lblLocalidadEmpleado";
            this.lblLocalidadEmpleado.Size = new System.Drawing.Size(100, 27);
            this.lblLocalidadEmpleado.TabIndex = 7;
            this.lblLocalidadEmpleado.Text = "Localidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(60, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "Altura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(44, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "DIRECCION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Calle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(572, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(321, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(44, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 27);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los siguientes datos:";
            // 
            // RegistroEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 682);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RegistroEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.RegistroEmpleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdministradorEmpleados;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarEmpleado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPuestoEmpleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPaisEmpleado;
        private System.Windows.Forms.Label lblLocalidadEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSucursalEmpleado;
        private System.Windows.Forms.ComboBox cmbPuestoEmpleado;
        private System.Windows.Forms.TextBox txtPaisEmpleado;
        private System.Windows.Forms.TextBox txtAlturaEmpleado;
        private System.Windows.Forms.TextBox txtCalleEmpleado;
        private System.Windows.Forms.TextBox txtTelefonoEmpleado;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRepetirContrasena;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grillaEmpleados;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApeEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSucursal;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnActualizarEmpleado;
        private System.Windows.Forms.Button btnVisualizarGrilla;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.ComboBox cmbProvincias;
        private System.Windows.Forms.Label label13;
    }
}