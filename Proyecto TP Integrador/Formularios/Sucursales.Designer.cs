namespace Proyecto_TP_Integrador
{
    partial class Sucursales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.txtIdSucusrsal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNombreSucursal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizarSucursales = new System.Windows.Forms.Button();
            this.btnEliminarPuesto = new System.Windows.Forms.Button();
            this.btnAgregarSucursal = new System.Windows.Forms.Button();
            this.grillaSucursales = new System.Windows.Forms.DataGridView();
            this.IdSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalleSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaisSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADMINISTRADOR DE SUCURSALES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtPais);
            this.panel2.Controls.Add(this.lblPais);
            this.panel2.Controls.Add(this.txtLocalidad);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtNumero);
            this.panel2.Controls.Add(this.lblNumero);
            this.panel2.Controls.Add(this.txtCalle);
            this.panel2.Controls.Add(this.lblCalle);
            this.panel2.Controls.Add(this.btnLimpiarCampos);
            this.panel2.Controls.Add(this.txtIdSucusrsal);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtTelefono);
            this.panel2.Controls.Add(this.lblTelefono);
            this.panel2.Controls.Add(this.txtNombreSucursal);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnActualizarSucursales);
            this.panel2.Controls.Add(this.btnEliminarPuesto);
            this.panel2.Controls.Add(this.btnAgregarSucursal);
            this.panel2.Controls.Add(this.grillaSucursales);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 453);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(158, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "*Campo obligatorio";
            // 
            // txtPais
            // 
            this.txtPais.Enabled = false;
            this.txtPais.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.Location = new System.Drawing.Point(314, 149);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(176, 42);
            this.txtPais.TabIndex = 41;
            this.txtPais.Text = "Argentina";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.BackColor = System.Drawing.Color.Transparent;
            this.lblPais.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.ForeColor = System.Drawing.Color.White;
            this.lblPais.Location = new System.Drawing.Point(308, 111);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(66, 35);
            this.lblPais.TabIndex = 40;
            this.lblPais.Text = "Pais:";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Enabled = false;
            this.txtLocalidad.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalidad.Location = new System.Drawing.Point(24, 149);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(232, 42);
            this.txtLocalidad.TabIndex = 39;
            this.txtLocalidad.Text = "Cordoba";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 35);
            this.label7.TabIndex = 38;
            this.label7.Text = "Localidad:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(733, 57);
            this.txtNumero.Multiline = true;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(107, 42);
            this.txtNumero.TabIndex = 4;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.White;
            this.lblNumero.Location = new System.Drawing.Point(724, 19);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(116, 35);
            this.lblNumero.TabIndex = 36;
            this.lblNumero.Text = "Numero:";
            // 
            // txtCalle
            // 
            this.txtCalle.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.Location = new System.Drawing.Point(521, 57);
            this.txtCalle.Multiline = true;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(169, 42);
            this.txtCalle.TabIndex = 3;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.BackColor = System.Drawing.Color.Transparent;
            this.lblCalle.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.ForeColor = System.Drawing.Color.White;
            this.lblCalle.Location = new System.Drawing.Point(515, 19);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(79, 35);
            this.lblCalle.TabIndex = 34;
            this.lblCalle.Text = "Calle:";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(587, 153);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(215, 38);
            this.btnLimpiarCampos.TabIndex = 33;
            this.btnLimpiarCampos.Text = "LIMPIAR CAMPOS";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // txtIdSucusrsal
            // 
            this.txtIdSucusrsal.Enabled = false;
            this.txtIdSucusrsal.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSucusrsal.Location = new System.Drawing.Point(1069, 57);
            this.txtIdSucusrsal.Name = "txtIdSucusrsal";
            this.txtIdSucusrsal.Size = new System.Drawing.Size(74, 42);
            this.txtIdSucusrsal.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1063, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 35);
            this.label5.TabIndex = 31;
            this.label5.Text = "ID:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(314, 57);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(169, 42);
            this.txtTelefono.TabIndex = 2;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(308, 19);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(122, 35);
            this.lblTelefono.TabIndex = 29;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtNombreSucursal
            // 
            this.txtNombreSucursal.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSucursal.Location = new System.Drawing.Point(24, 57);
            this.txtNombreSucursal.Name = "txtNombreSucursal";
            this.txtNombreSucursal.Size = new System.Drawing.Size(232, 42);
            this.txtNombreSucursal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 35);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre de sucursal:";
            // 
            // btnActualizarSucursales
            // 
            this.btnActualizarSucursales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActualizarSucursales.Enabled = false;
            this.btnActualizarSucursales.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarSucursales.ForeColor = System.Drawing.Color.White;
            this.btnActualizarSucursales.Location = new System.Drawing.Point(764, 395);
            this.btnActualizarSucursales.Name = "btnActualizarSucursales";
            this.btnActualizarSucursales.Size = new System.Drawing.Size(120, 38);
            this.btnActualizarSucursales.TabIndex = 26;
            this.btnActualizarSucursales.Text = "MODIFICAR";
            this.btnActualizarSucursales.UseVisualStyleBackColor = false;
            this.btnActualizarSucursales.Click += new System.EventHandler(this.btnActualizarSucursales_Click);
            // 
            // btnEliminarPuesto
            // 
            this.btnEliminarPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminarPuesto.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPuesto.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPuesto.Location = new System.Drawing.Point(911, 395);
            this.btnEliminarPuesto.Name = "btnEliminarPuesto";
            this.btnEliminarPuesto.Size = new System.Drawing.Size(116, 38);
            this.btnEliminarPuesto.TabIndex = 25;
            this.btnEliminarPuesto.Text = "ELIMINAR";
            this.btnEliminarPuesto.UseVisualStyleBackColor = false;
            this.btnEliminarPuesto.Click += new System.EventHandler(this.btnEliminarPuesto_Click);
            // 
            // btnAgregarSucursal
            // 
            this.btnAgregarSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregarSucursal.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSucursal.ForeColor = System.Drawing.Color.White;
            this.btnAgregarSucursal.Location = new System.Drawing.Point(607, 395);
            this.btnAgregarSucursal.Name = "btnAgregarSucursal";
            this.btnAgregarSucursal.Size = new System.Drawing.Size(120, 38);
            this.btnAgregarSucursal.TabIndex = 24;
            this.btnAgregarSucursal.Text = "AGREGAR";
            this.btnAgregarSucursal.UseVisualStyleBackColor = false;
            this.btnAgregarSucursal.Click += new System.EventHandler(this.btnAgregarSucursal_Click);
            // 
            // grillaSucursales
            // 
            this.grillaSucursales.AllowUserToAddRows = false;
            this.grillaSucursales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaSucursales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grillaSucursales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaSucursales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grillaSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaSucursales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSucursal,
            this.NomSucursal,
            this.TelSucursal,
            this.CalleSucursal,
            this.NroSucursal,
            this.LocSucursal,
            this.PaisSucursal});
            this.grillaSucursales.EnableHeadersVisualStyles = false;
            this.grillaSucursales.GridColor = System.Drawing.Color.White;
            this.grillaSucursales.Location = new System.Drawing.Point(24, 223);
            this.grillaSucursales.Name = "grillaSucursales";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaSucursales.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grillaSucursales.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            this.grillaSucursales.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grillaSucursales.RowTemplate.Height = 24;
            this.grillaSucursales.Size = new System.Drawing.Size(1125, 150);
            this.grillaSucursales.TabIndex = 23;
            this.grillaSucursales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaSucursales_CellClick);
            this.grillaSucursales.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.grillaSucursales_UserDeletingRow);
            // 
            // IdSucursal
            // 
            this.IdSucursal.DataPropertyName = "IdSucursal";
            this.IdSucursal.FillWeight = 40F;
            this.IdSucursal.HeaderText = "Id";
            this.IdSucursal.MinimumWidth = 6;
            this.IdSucursal.Name = "IdSucursal";
            // 
            // NomSucursal
            // 
            this.NomSucursal.DataPropertyName = "NomSucursal";
            this.NomSucursal.FillWeight = 123.6251F;
            this.NomSucursal.HeaderText = "Sucursal";
            this.NomSucursal.MinimumWidth = 6;
            this.NomSucursal.Name = "NomSucursal";
            // 
            // TelSucursal
            // 
            this.TelSucursal.DataPropertyName = "TelSucursal";
            this.TelSucursal.FillWeight = 92.58804F;
            this.TelSucursal.HeaderText = "Telefono";
            this.TelSucursal.MinimumWidth = 6;
            this.TelSucursal.Name = "TelSucursal";
            // 
            // CalleSucursal
            // 
            this.CalleSucursal.DataPropertyName = "CalleSucursal";
            this.CalleSucursal.HeaderText = "Calle";
            this.CalleSucursal.MinimumWidth = 6;
            this.CalleSucursal.Name = "CalleSucursal";
            // 
            // NroSucursal
            // 
            this.NroSucursal.DataPropertyName = "NroSucursal";
            this.NroSucursal.HeaderText = "Nro";
            this.NroSucursal.MinimumWidth = 6;
            this.NroSucursal.Name = "NroSucursal";
            // 
            // LocSucursal
            // 
            this.LocSucursal.DataPropertyName = "LocSucursal";
            this.LocSucursal.HeaderText = "Localidad";
            this.LocSucursal.MinimumWidth = 6;
            this.LocSucursal.Name = "LocSucursal";
            // 
            // PaisSucursal
            // 
            this.PaisSucursal.DataPropertyName = "PaisSucursal";
            this.PaisSucursal.HeaderText = "Pais";
            this.PaisSucursal.MinimumWidth = 6;
            this.PaisSucursal.Name = "PaisSucursal";
            // 
            // Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Sucursales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sucursales";
            this.Load += new System.EventHandler(this.Sucursales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSucursales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.TextBox txtIdSucusrsal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNombreSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActualizarSucursales;
        private System.Windows.Forms.Button btnEliminarPuesto;
        private System.Windows.Forms.Button btnAgregarSucursal;
        private System.Windows.Forms.DataGridView grillaSucursales;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalleSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaisSucursal;
        private System.Windows.Forms.Label label3;
    }
}