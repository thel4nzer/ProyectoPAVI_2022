namespace Proyecto_TP_Integrador
{
    partial class Puestos
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.txtIdPuesto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcionPuesto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombrePuesto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizarPuestos = new System.Windows.Forms.Button();
            this.btnEliminarPuesto = new System.Windows.Forms.Button();
            this.btnAgregarPuesto = new System.Windows.Forms.Button();
            this.grillaPuestos = new System.Windows.Forms.DataGridView();
            this.IdPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPuestos)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(281, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADMINISTRADOR DE PUESTOS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnLimpiarCampos);
            this.panel2.Controls.Add(this.txtIdPuesto);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDescripcionPuesto);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtNombrePuesto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnActualizarPuestos);
            this.panel2.Controls.Add(this.btnEliminarPuesto);
            this.panel2.Controls.Add(this.btnAgregarPuesto);
            this.panel2.Controls.Add(this.grillaPuestos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 453);
            this.panel2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Perpetua", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(163, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "*Campo obligatorio";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(166, 235);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(215, 38);
            this.btnLimpiarCampos.TabIndex = 22;
            this.btnLimpiarCampos.Text = "LIMPIAR CAMPOS";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // txtIdPuesto
            // 
            this.txtIdPuesto.Enabled = false;
            this.txtIdPuesto.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPuesto.Location = new System.Drawing.Point(29, 138);
            this.txtIdPuesto.Name = "txtIdPuesto";
            this.txtIdPuesto.Size = new System.Drawing.Size(74, 42);
            this.txtIdPuesto.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 35);
            this.label5.TabIndex = 20;
            this.label5.Text = "ID:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescripcionPuesto
            // 
            this.txtDescripcionPuesto.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionPuesto.Location = new System.Drawing.Point(319, 41);
            this.txtDescripcionPuesto.Multiline = true;
            this.txtDescripcionPuesto.Name = "txtDescripcionPuesto";
            this.txtDescripcionPuesto.Size = new System.Drawing.Size(349, 139);
            this.txtDescripcionPuesto.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(313, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 35);
            this.label3.TabIndex = 16;
            this.label3.Text = "Descripcion del puesto:";
            // 
            // txtNombrePuesto
            // 
            this.txtNombrePuesto.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePuesto.Location = new System.Drawing.Point(29, 41);
            this.txtNombrePuesto.Name = "txtNombrePuesto";
            this.txtNombrePuesto.Size = new System.Drawing.Size(232, 42);
            this.txtNombrePuesto.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 35);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre del puesto:";
            // 
            // btnActualizarPuestos
            // 
            this.btnActualizarPuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActualizarPuestos.Enabled = false;
            this.btnActualizarPuestos.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPuestos.ForeColor = System.Drawing.Color.White;
            this.btnActualizarPuestos.Location = new System.Drawing.Point(769, 379);
            this.btnActualizarPuestos.Name = "btnActualizarPuestos";
            this.btnActualizarPuestos.Size = new System.Drawing.Size(120, 38);
            this.btnActualizarPuestos.TabIndex = 12;
            this.btnActualizarPuestos.Text = "MODIFICAR";
            this.btnActualizarPuestos.UseVisualStyleBackColor = false;
            this.btnActualizarPuestos.Click += new System.EventHandler(this.btnActualizarPuesto_Click);
            // 
            // btnEliminarPuesto
            // 
            this.btnEliminarPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminarPuesto.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPuesto.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPuesto.Location = new System.Drawing.Point(916, 379);
            this.btnEliminarPuesto.Name = "btnEliminarPuesto";
            this.btnEliminarPuesto.Size = new System.Drawing.Size(116, 38);
            this.btnEliminarPuesto.TabIndex = 11;
            this.btnEliminarPuesto.Text = "ELIMINAR";
            this.btnEliminarPuesto.UseVisualStyleBackColor = false;
            this.btnEliminarPuesto.Click += new System.EventHandler(this.btnEliminarPuesto_Click);
            // 
            // btnAgregarPuesto
            // 
            this.btnAgregarPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregarPuesto.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPuesto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPuesto.Location = new System.Drawing.Point(612, 379);
            this.btnAgregarPuesto.Name = "btnAgregarPuesto";
            this.btnAgregarPuesto.Size = new System.Drawing.Size(120, 38);
            this.btnAgregarPuesto.TabIndex = 10;
            this.btnAgregarPuesto.Text = "AGREGAR";
            this.btnAgregarPuesto.UseVisualStyleBackColor = false;
            this.btnAgregarPuesto.Click += new System.EventHandler(this.btnAgregarPuesto_Click);
            // 
            // grillaPuestos
            // 
            this.grillaPuestos.AllowUserToAddRows = false;
            this.grillaPuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaPuestos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grillaPuestos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaPuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPuesto,
            this.NomPuesto,
            this.DescripcionPuesto});
            this.grillaPuestos.EnableHeadersVisualStyles = false;
            this.grillaPuestos.GridColor = System.Drawing.Color.White;
            this.grillaPuestos.Location = new System.Drawing.Point(488, 201);
            this.grillaPuestos.Name = "grillaPuestos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaPuestos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grillaPuestos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Perpetua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            this.grillaPuestos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grillaPuestos.RowTemplate.Height = 24;
            this.grillaPuestos.Size = new System.Drawing.Size(666, 150);
            this.grillaPuestos.TabIndex = 9;
            this.grillaPuestos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaPuestos_CellClick);
            this.grillaPuestos.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.grillaPuestos_UserDeletingRow);
            // 
            // IdPuesto
            // 
            this.IdPuesto.DataPropertyName = "IdPuesto";
            this.IdPuesto.FillWeight = 40F;
            this.IdPuesto.HeaderText = "IdPuesto";
            this.IdPuesto.MinimumWidth = 6;
            this.IdPuesto.Name = "IdPuesto";
            // 
            // NomPuesto
            // 
            this.NomPuesto.DataPropertyName = "NomPuesto";
            this.NomPuesto.FillWeight = 123.6251F;
            this.NomPuesto.HeaderText = "Puesto";
            this.NomPuesto.MinimumWidth = 6;
            this.NomPuesto.Name = "NomPuesto";
            // 
            // DescripcionPuesto
            // 
            this.DescripcionPuesto.DataPropertyName = "DescripcionPuesto";
            this.DescripcionPuesto.FillWeight = 92.58804F;
            this.DescripcionPuesto.HeaderText = "Descripcion";
            this.DescripcionPuesto.MinimumWidth = 6;
            this.DescripcionPuesto.Name = "DescripcionPuesto";
            // 
            // Puestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Puestos";
            this.Text = "Puestos";
            this.Load += new System.EventHandler(this.Puestos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPuestos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaPuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionPuesto;
        private System.Windows.Forms.Button btnActualizarPuestos;
        private System.Windows.Forms.Button btnEliminarPuesto;
        private System.Windows.Forms.Button btnAgregarPuesto;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.TextBox txtIdPuesto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcionPuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombrePuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
    }
}