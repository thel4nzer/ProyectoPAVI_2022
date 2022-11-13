namespace Proyecto_TP_Integrador
{
    partial class Reportes
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
            this.lblReporesYListados = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReporteEmpleados = new System.Windows.Forms.Button();
            this.btnReportePedidos = new System.Windows.Forms.Button();
            this.btnReporteFacturas = new System.Windows.Forms.Button();
            this.btnReporteClientes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblReporesYListados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 81);
            this.panel1.TabIndex = 0;
            // 
            // lblReporesYListados
            // 
            this.lblReporesYListados.AutoSize = true;
            this.lblReporesYListados.Font = new System.Drawing.Font("Perpetua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporesYListados.Location = new System.Drawing.Point(113, 15);
            this.lblReporesYListados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReporesYListados.Name = "lblReporesYListados";
            this.lblReporesYListados.Size = new System.Drawing.Size(484, 55);
            this.lblReporesYListados.TabIndex = 2;
            this.lblReporesYListados.Text = "LISTADOS Y REPORTES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnReporteEmpleados);
            this.panel2.Controls.Add(this.btnReportePedidos);
            this.panel2.Controls.Add(this.btnReporteFacturas);
            this.panel2.Controls.Add(this.btnReporteClientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 292);
            this.panel2.TabIndex = 1;
            // 
            // btnReporteEmpleados
            // 
            this.btnReporteEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReporteEmpleados.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnReporteEmpleados.Location = new System.Drawing.Point(65, 82);
            this.btnReporteEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporteEmpleados.Name = "btnReporteEmpleados";
            this.btnReporteEmpleados.Size = new System.Drawing.Size(126, 91);
            this.btnReporteEmpleados.TabIndex = 12;
            this.btnReporteEmpleados.Text = "REPORTE DE EMPLEADOS";
            this.btnReporteEmpleados.UseVisualStyleBackColor = false;
            this.btnReporteEmpleados.Click += new System.EventHandler(this.btnReporteEmpleados_Click);
            // 
            // btnReportePedidos
            // 
            this.btnReportePedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReportePedidos.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportePedidos.ForeColor = System.Drawing.Color.White;
            this.btnReportePedidos.Location = new System.Drawing.Point(213, 82);
            this.btnReportePedidos.Margin = new System.Windows.Forms.Padding(2);
            this.btnReportePedidos.Name = "btnReportePedidos";
            this.btnReportePedidos.Size = new System.Drawing.Size(116, 91);
            this.btnReportePedidos.TabIndex = 11;
            this.btnReportePedidos.Text = "REPORTE DE PEDIDOS";
            this.btnReportePedidos.UseVisualStyleBackColor = false;
            this.btnReportePedidos.Click += new System.EventHandler(this.btnReportePedidos_Click);
            // 
            // btnReporteFacturas
            // 
            this.btnReporteFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReporteFacturas.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteFacturas.ForeColor = System.Drawing.Color.White;
            this.btnReporteFacturas.Location = new System.Drawing.Point(359, 82);
            this.btnReporteFacturas.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporteFacturas.Name = "btnReporteFacturas";
            this.btnReporteFacturas.Size = new System.Drawing.Size(122, 91);
            this.btnReporteFacturas.TabIndex = 10;
            this.btnReporteFacturas.Text = "REPORTE DE FACTURAS";
            this.btnReporteFacturas.UseVisualStyleBackColor = false;
            this.btnReporteFacturas.Click += new System.EventHandler(this.btnReporteFacturas_Click);
            // 
            // btnReporteClientes
            // 
            this.btnReporteClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReporteClientes.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteClientes.ForeColor = System.Drawing.Color.White;
            this.btnReporteClientes.Location = new System.Drawing.Point(511, 82);
            this.btnReporteClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporteClientes.Name = "btnReporteClientes";
            this.btnReporteClientes.Size = new System.Drawing.Size(109, 91);
            this.btnReporteClientes.TabIndex = 9;
            this.btnReporteClientes.Text = "REPORTE DE CLIENTES";
            this.btnReporteClientes.UseVisualStyleBackColor = false;
            this.btnReporteClientes.Click += new System.EventHandler(this.btnReporteClientes_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 373);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReporteEmpleados;
        private System.Windows.Forms.Button btnReportePedidos;
        private System.Windows.Forms.Button btnReporteFacturas;
        private System.Windows.Forms.Button btnReporteClientes;
        private System.Windows.Forms.Label lblReporesYListados;
    }
}