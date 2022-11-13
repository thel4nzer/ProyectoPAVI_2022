namespace Proyecto_TP_Integrador
{
    partial class PrincipalForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPuestos = new System.Windows.Forms.Button();
            this.btnCobros = new System.Windows.Forms.Button();
            this.btnPlatos = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBienv = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnActualizarGrilla = new System.Windows.Forms.Button();
            this.grillaPedidos = new System.Windows.Forms.DataGridView();
            this.btnEliminarTodosPedidos = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.IdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPlato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnReportes);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnPuestos);
            this.panel1.Controls.Add(this.btnCobros);
            this.panel1.Controls.Add(this.btnPlatos);
            this.panel1.Controls.Add(this.btnPedidos);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnEmpleado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 567);
            this.panel1.TabIndex = 0;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReportes.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Location = new System.Drawing.Point(25, 489);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(193, 46);
            this.btnReportes.TabIndex = 13;
            this.btnReportes.Text = "REPORTE";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(25, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "SUCURSALES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPuestos
            // 
            this.btnPuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPuestos.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuestos.ForeColor = System.Drawing.Color.White;
            this.btnPuestos.Location = new System.Drawing.Point(25, 294);
            this.btnPuestos.Name = "btnPuestos";
            this.btnPuestos.Size = new System.Drawing.Size(193, 46);
            this.btnPuestos.TabIndex = 11;
            this.btnPuestos.Text = "PUESTOS";
            this.btnPuestos.UseVisualStyleBackColor = false;
            this.btnPuestos.Click += new System.EventHandler(this.btnPuestos_Click);
            // 
            // btnCobros
            // 
            this.btnCobros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCobros.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobros.ForeColor = System.Drawing.Color.White;
            this.btnCobros.Location = new System.Drawing.Point(25, 423);
            this.btnCobros.Name = "btnCobros";
            this.btnCobros.Size = new System.Drawing.Size(193, 46);
            this.btnCobros.TabIndex = 10;
            this.btnCobros.Text = "COBROS";
            this.btnCobros.UseVisualStyleBackColor = false;
            this.btnCobros.Click += new System.EventHandler(this.btnCobros_Click);
            // 
            // btnPlatos
            // 
            this.btnPlatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPlatos.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlatos.ForeColor = System.Drawing.Color.White;
            this.btnPlatos.Location = new System.Drawing.Point(25, 225);
            this.btnPlatos.Name = "btnPlatos";
            this.btnPlatos.Size = new System.Drawing.Size(193, 46);
            this.btnPlatos.TabIndex = 9;
            this.btnPlatos.Text = "MENU";
            this.btnPlatos.UseVisualStyleBackColor = false;
            this.btnPlatos.Click += new System.EventHandler(this.btnPlatos_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPedidos.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.Color.White;
            this.btnPedidos.Location = new System.Drawing.Point(25, 161);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(193, 46);
            this.btnPedidos.TabIndex = 8;
            this.btnPedidos.Text = "PEDIDOS";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_TP_Integrador.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(37, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEmpleado.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEmpleado.Location = new System.Drawing.Point(25, 100);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(193, 44);
            this.btnEmpleado.TabIndex = 0;
            this.btnEmpleado.Text = "EMPLEADOS";
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.lblBienv);
            this.panel2.Controls.Add(this.lblBienvenido);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(245, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 100);
            this.panel2.TabIndex = 1;
            // 
            // lblBienv
            // 
            this.lblBienv.AutoSize = true;
            this.lblBienv.Font = new System.Drawing.Font("Perpetua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienv.Location = new System.Drawing.Point(73, 18);
            this.lblBienv.Name = "lblBienv";
            this.lblBienv.Size = new System.Drawing.Size(355, 69);
            this.lblBienv.TabIndex = 1;
            this.lblBienv.Text = "BIENVENIDO";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Perpetua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(434, 18);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(131, 69);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "label";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btnActualizarGrilla);
            this.panel3.Controls.Add(this.grillaPedidos);
            this.panel3.Controls.Add(this.btnEliminarTodosPedidos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(245, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(863, 467);
            this.panel3.TabIndex = 2;
            // 
            // btnActualizarGrilla
            // 
            this.btnActualizarGrilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActualizarGrilla.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarGrilla.ForeColor = System.Drawing.Color.White;
            this.btnActualizarGrilla.Location = new System.Drawing.Point(474, 332);
            this.btnActualizarGrilla.Name = "btnActualizarGrilla";
            this.btnActualizarGrilla.Size = new System.Drawing.Size(315, 33);
            this.btnActualizarGrilla.TabIndex = 18;
            this.btnActualizarGrilla.Text = "ACTUALIZAR GRILLA";
            this.btnActualizarGrilla.UseVisualStyleBackColor = false;
            this.btnActualizarGrilla.Click += new System.EventHandler(this.btnActualizarGrilla_Click);
            // 
            // grillaPedidos
            // 
            this.grillaPedidos.AllowUserToAddRows = false;
            this.grillaPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPedido,
            this.IdPlato,
            this.IdBebida,
            this.IdMesa,
            this.IdEstado});
            this.grillaPedidos.EnableHeadersVisualStyles = false;
            this.grillaPedidos.GridColor = System.Drawing.Color.White;
            this.grillaPedidos.Location = new System.Drawing.Point(45, 16);
            this.grillaPedidos.Name = "grillaPedidos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grillaPedidos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            this.grillaPedidos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grillaPedidos.RowTemplate.Height = 24;
            this.grillaPedidos.Size = new System.Drawing.Size(788, 298);
            this.grillaPedidos.TabIndex = 17;
            this.grillaPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaPedidos_CellContentClick_1);
            // 
            // btnEliminarTodosPedidos
            // 
            this.btnEliminarTodosPedidos.BackColor = System.Drawing.Color.Red;
            this.btnEliminarTodosPedidos.Enabled = false;
            this.btnEliminarTodosPedidos.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTodosPedidos.ForeColor = System.Drawing.Color.White;
            this.btnEliminarTodosPedidos.Location = new System.Drawing.Point(45, 332);
            this.btnEliminarTodosPedidos.Name = "btnEliminarTodosPedidos";
            this.btnEliminarTodosPedidos.Size = new System.Drawing.Size(315, 33);
            this.btnEliminarTodosPedidos.TabIndex = 16;
            this.btnEliminarTodosPedidos.Text = "ELIMINAR TODOS LOS PEDIDOS";
            this.btnEliminarTodosPedidos.UseVisualStyleBackColor = false;
            this.btnEliminarTodosPedidos.Click += new System.EventHandler(this.btnEliminarTodosPedidos_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // IdPedido
            // 
            this.IdPedido.DataPropertyName = "IdPedido";
            this.IdPedido.HeaderText = "Pedido";
            this.IdPedido.MinimumWidth = 6;
            this.IdPedido.Name = "IdPedido";
            // 
            // IdPlato
            // 
            this.IdPlato.DataPropertyName = "NombrePlato";
            this.IdPlato.HeaderText = "Plato";
            this.IdPlato.MinimumWidth = 6;
            this.IdPlato.Name = "IdPlato";
            // 
            // IdBebida
            // 
            this.IdBebida.DataPropertyName = "NombreBebida";
            this.IdBebida.HeaderText = "Bebida";
            this.IdBebida.MinimumWidth = 6;
            this.IdBebida.Name = "IdBebida";
            // 
            // IdMesa
            // 
            this.IdMesa.DataPropertyName = "IdMesa";
            this.IdMesa.HeaderText = "Mesa";
            this.IdMesa.MinimumWidth = 6;
            this.IdMesa.Name = "IdMesa";
            // 
            // IdEstado
            // 
            this.IdEstado.DataPropertyName = "NomEstado";
            this.IdEstado.HeaderText = "Estado";
            this.IdEstado.MinimumWidth = 6;
            this.IdEstado.Name = "IdEstado";
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 567);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grillaPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminarTodosPedidos;
        private System.Windows.Forms.DataGridView grillaPedidos;
        private System.Windows.Forms.Button btnActualizarGrilla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblBienv;
        private System.Windows.Forms.Button btnPlatos;
        private System.Windows.Forms.Button btnCobros;
        private System.Windows.Forms.Button btnPuestos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPlato;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado;
    }
}