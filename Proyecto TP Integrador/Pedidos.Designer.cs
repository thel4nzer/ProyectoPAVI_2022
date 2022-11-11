namespace Proyecto_TP_Integrador
{
    partial class Pedidos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdministrarPedidos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBorrarPedido = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnActualizarPedido = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grillaPedidos = new System.Windows.Forms.DataGridView();
            this.IdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPlato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGrillaPedidos = new System.Windows.Forms.Label();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.cmbMesa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecioBebida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecioPlato = new System.Windows.Forms.TextBox();
            this.cmbBebida = new System.Windows.Forms.ComboBox();
            this.cmbPlato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlatos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblAdministrarPedidos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1376, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblAdministrarPedidos
            // 
            this.lblAdministrarPedidos.AutoSize = true;
            this.lblAdministrarPedidos.Font = new System.Drawing.Font("Perpetua", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrarPedidos.Location = new System.Drawing.Point(243, 24);
            this.lblAdministrarPedidos.Name = "lblAdministrarPedidos";
            this.lblAdministrarPedidos.Size = new System.Drawing.Size(621, 54);
            this.lblAdministrarPedidos.TabIndex = 0;
            this.lblAdministrarPedidos.Text = "ADMINISTRADOR DE PEDIDOS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnBorrarPedido);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbEstado);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnActualizarPedido);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnAgregarPedido);
            this.panel2.Controls.Add(this.cmbMesa);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtPrecioBebida);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtPrecioPlato);
            this.panel2.Controls.Add(this.cmbBebida);
            this.panel2.Controls.Add(this.cmbPlato);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblPlatos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1376, 507);
            this.panel2.TabIndex = 1;
            // 
            // btnBorrarPedido
            // 
            this.btnBorrarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBorrarPedido.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarPedido.ForeColor = System.Drawing.Color.White;
            this.btnBorrarPedido.Location = new System.Drawing.Point(581, 442);
            this.btnBorrarPedido.Name = "btnBorrarPedido";
            this.btnBorrarPedido.Size = new System.Drawing.Size(254, 41);
            this.btnBorrarPedido.TabIndex = 37;
            this.btnBorrarPedido.Text = "BORRAR PEDIDO";
            this.btnBorrarPedido.UseVisualStyleBackColor = false;
            this.btnBorrarPedido.Click += new System.EventHandler(this.btnBorrarPedido_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(1081, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 36;
            this.label7.Text = "*Campo obligatorio";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Pendiente",
            "Preparacion",
            "Listo",
            "Entregado"});
            this.cmbEstado.Location = new System.Drawing.Point(77, 359);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(403, 39);
            this.cmbEstado.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(70, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 38);
            this.label5.TabIndex = 15;
            this.label5.Text = "ESTADO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(72, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "Pedido:";
            // 
            // btnActualizarPedido
            // 
            this.btnActualizarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActualizarPedido.Enabled = false;
            this.btnActualizarPedido.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPedido.ForeColor = System.Drawing.Color.White;
            this.btnActualizarPedido.Location = new System.Drawing.Point(154, 442);
            this.btnActualizarPedido.Name = "btnActualizarPedido";
            this.btnActualizarPedido.Size = new System.Drawing.Size(371, 41);
            this.btnActualizarPedido.TabIndex = 13;
            this.btnActualizarPedido.Text = "ACTUALIZAR PEDIDO";
            this.btnActualizarPedido.UseVisualStyleBackColor = false;
            this.btnActualizarPedido.Click += new System.EventHandler(this.btnActualizarPedido_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.LightGray;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Red;
            this.txtId.Location = new System.Drawing.Point(75, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(75, 38);
            this.txtId.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grillaPedidos);
            this.panel3.Controls.Add(this.lblGrillaPedidos);
            this.panel3.Location = new System.Drawing.Point(755, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(609, 338);
            this.panel3.TabIndex = 10;
            // 
            // grillaPedidos
            // 
            this.grillaPedidos.AllowUserToAddRows = false;
            this.grillaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPedido,
            this.IdPlato,
            this.IdBebida,
            this.IdMesa,
            this.IdEstado});
            this.grillaPedidos.Location = new System.Drawing.Point(0, 38);
            this.grillaPedidos.MultiSelect = false;
            this.grillaPedidos.Name = "grillaPedidos";
            this.grillaPedidos.RowHeadersWidth = 51;
            this.grillaPedidos.RowTemplate.Height = 24;
            this.grillaPedidos.Size = new System.Drawing.Size(575, 297);
            this.grillaPedidos.TabIndex = 1;
            this.grillaPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaPedidos_CellClick);
            this.grillaPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaPedidos_CellClick);
            // 
            // IdPedido
            // 
            this.IdPedido.DataPropertyName = "IdPedido";
            this.IdPedido.HeaderText = "Pedido";
            this.IdPedido.MinimumWidth = 6;
            this.IdPedido.Name = "IdPedido";
            this.IdPedido.Width = 125;
            // 
            // IdPlato
            // 
            this.IdPlato.DataPropertyName = "NombrePlato";
            this.IdPlato.HeaderText = "Plato";
            this.IdPlato.MinimumWidth = 6;
            this.IdPlato.Name = "IdPlato";
            this.IdPlato.Width = 125;
            // 
            // IdBebida
            // 
            this.IdBebida.DataPropertyName = "NombreBebida";
            this.IdBebida.HeaderText = "Bebida";
            this.IdBebida.MinimumWidth = 6;
            this.IdBebida.Name = "IdBebida";
            this.IdBebida.Width = 125;
            // 
            // IdMesa
            // 
            this.IdMesa.DataPropertyName = "IdMesa";
            this.IdMesa.HeaderText = "Mesa";
            this.IdMesa.MinimumWidth = 6;
            this.IdMesa.Name = "IdMesa";
            this.IdMesa.Width = 125;
            // 
            // IdEstado
            // 
            this.IdEstado.DataPropertyName = "NomEstado";
            this.IdEstado.HeaderText = "Estado";
            this.IdEstado.MinimumWidth = 6;
            this.IdEstado.Name = "IdEstado";
            this.IdEstado.Width = 125;
            // 
            // lblGrillaPedidos
            // 
            this.lblGrillaPedidos.AutoSize = true;
            this.lblGrillaPedidos.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrillaPedidos.ForeColor = System.Drawing.Color.White;
            this.lblGrillaPedidos.Location = new System.Drawing.Point(3, 0);
            this.lblGrillaPedidos.Name = "lblGrillaPedidos";
            this.lblGrillaPedidos.Size = new System.Drawing.Size(201, 35);
            this.lblGrillaPedidos.TabIndex = 0;
            this.lblGrillaPedidos.Text = "Grilla de pedidos";
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregarPedido.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPedido.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPedido.Location = new System.Drawing.Point(886, 442);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(275, 41);
            this.btnAgregarPedido.TabIndex = 9;
            this.btnAgregarPedido.Text = "AGREGAR PEDIDO";
            this.btnAgregarPedido.UseVisualStyleBackColor = false;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // cmbMesa
            // 
            this.cmbMesa.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMesa.FormattingEnabled = true;
            this.cmbMesa.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbMesa.Location = new System.Drawing.Point(1234, 44);
            this.cmbMesa.Name = "cmbMesa";
            this.cmbMesa.Size = new System.Drawing.Size(96, 39);
            this.cmbMesa.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1236, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "MESA:";
            // 
            // txtPrecioBebida
            // 
            this.txtPrecioBebida.Enabled = false;
            this.txtPrecioBebida.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioBebida.Location = new System.Drawing.Point(581, 265);
            this.txtPrecioBebida.Name = "txtPrecioBebida";
            this.txtPrecioBebida.Size = new System.Drawing.Size(72, 38);
            this.txtPrecioBebida.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(553, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "PRECIO:";
            // 
            // txtPrecioPlato
            // 
            this.txtPrecioPlato.Enabled = false;
            this.txtPrecioPlato.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioPlato.Location = new System.Drawing.Point(581, 140);
            this.txtPrecioPlato.Name = "txtPrecioPlato";
            this.txtPrecioPlato.Size = new System.Drawing.Size(72, 38);
            this.txtPrecioPlato.TabIndex = 4;
            // 
            // cmbBebida
            // 
            this.cmbBebida.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBebida.FormattingEnabled = true;
            this.cmbBebida.Location = new System.Drawing.Point(75, 265);
            this.cmbBebida.Name = "cmbBebida";
            this.cmbBebida.Size = new System.Drawing.Size(403, 39);
            this.cmbBebida.TabIndex = 3;
            this.cmbBebida.SelectedIndexChanged += new System.EventHandler(this.cmbBebida_SelectedIndexChanged);
            // 
            // cmbPlato
            // 
            this.cmbPlato.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlato.FormattingEnabled = true;
            this.cmbPlato.Location = new System.Drawing.Point(75, 140);
            this.cmbPlato.Name = "cmbPlato";
            this.cmbPlato.Size = new System.Drawing.Size(403, 39);
            this.cmbPlato.TabIndex = 2;
            this.cmbPlato.SelectedIndexChanged += new System.EventHandler(this.cmbPlato_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "BEBIDA:";
            // 
            // lblPlatos
            // 
            this.lblPlatos.AutoSize = true;
            this.lblPlatos.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlatos.ForeColor = System.Drawing.Color.White;
            this.lblPlatos.Location = new System.Drawing.Point(70, 96);
            this.lblPlatos.Name = "lblPlatos";
            this.lblPlatos.Size = new System.Drawing.Size(124, 38);
            this.lblPlatos.TabIndex = 0;
            this.lblPlatos.Text = "PLATO:";
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 607);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdministrarPedidos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbBebida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlatos;
        private System.Windows.Forms.TextBox txtPrecioBebida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecioPlato;
        private System.Windows.Forms.ComboBox cmbMesa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grillaPedidos;
        private System.Windows.Forms.Label lblGrillaPedidos;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnActualizarPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPlato;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado;
        private System.Windows.Forms.ComboBox cmbPlato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBorrarPedido;
    }
}