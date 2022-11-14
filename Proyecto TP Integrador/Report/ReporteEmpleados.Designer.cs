namespace Proyecto_TP_Integrador
{
    partial class ReporteEmpleados
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProyectoPAVIDataSet = new Proyecto_TP_Integrador.ProyectoPAVIDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReporesYListados = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.estadisticaPuestos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaHasta = new System.Windows.Forms.MaskedTextBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.reportEmpleados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usuariosTableAdapter = new Proyecto_TP_Integrador.ProyectoPAVIDataSetTableAdapters.usuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoPAVIDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.ProyectoPAVIDataSet;
            // 
            // ProyectoPAVIDataSet
            // 
            this.ProyectoPAVIDataSet.DataSetName = "ProyectoPAVIDataSet";
            this.ProyectoPAVIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblReporesYListados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1331, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblReporesYListados
            // 
            this.lblReporesYListados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReporesYListados.AutoSize = true;
            this.lblReporesYListados.Font = new System.Drawing.Font("Perpetua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporesYListados.Location = new System.Drawing.Point(381, 18);
            this.lblReporesYListados.Name = "lblReporesYListados";
            this.lblReporesYListados.Size = new System.Drawing.Size(684, 69);
            this.lblReporesYListados.TabIndex = 66;
            this.lblReporesYListados.Text = "REPORTE DE EMPLEADOS";
            this.lblReporesYListados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.estadisticaPuestos);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtFechaDesde);
            this.panel2.Controls.Add(this.txtFechaHasta);
            this.panel2.Controls.Add(this.lblPuesto);
            this.panel2.Controls.Add(this.cmbSucursal);
            this.panel2.Controls.Add(this.btnFiltrar);
            this.panel2.Controls.Add(this.reportEmpleados);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1331, 586);
            this.panel2.TabIndex = 1;
            // 
            // estadisticaPuestos
            // 
            this.estadisticaPuestos.LocalReport.ReportEmbeddedResource = "Proyecto_TP_Integrador.Listados.EstadisticaEmpleados.rdlc";
            this.estadisticaPuestos.Location = new System.Drawing.Point(872, 162);
            this.estadisticaPuestos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estadisticaPuestos.Name = "estadisticaPuestos";
            this.estadisticaPuestos.ServerReport.BearerToken = null;
            this.estadisticaPuestos.Size = new System.Drawing.Size(447, 413);
            this.estadisticaPuestos.TabIndex = 74;
            this.estadisticaPuestos.ZoomPercent = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(529, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(423, 16);
            this.label3.TabIndex = 73;
            this.label3.Text = "*elegir una sucursal para visualizar el gráfico de puestos por sucursal*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(724, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 38);
            this.label1.TabIndex = 72;
            this.label1.Text = "HASTA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(386, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 38);
            this.label2.TabIndex = 71;
            this.label2.Text = "DESDE:";
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaDesde.Location = new System.Drawing.Point(532, 14);
            this.txtFechaDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFechaDesde.Mask = "00/00/0000";
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(164, 42);
            this.txtFechaDesde.TabIndex = 70;
            this.txtFechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaHasta.Location = new System.Drawing.Point(871, 14);
            this.txtFechaHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFechaHasta.Mask = "00/00/0000";
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(164, 42);
            this.txtFechaHasta.TabIndex = 69;
            this.txtFechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.Color.White;
            this.lblPuesto.Location = new System.Drawing.Point(324, 90);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(176, 38);
            this.lblPuesto.TabIndex = 68;
            this.lblPuesto.Text = "SUCURSAL:";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(522, 92);
            this.cmbSucursal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(224, 37);
            this.cmbSucursal.TabIndex = 67;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFiltrar.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(816, 87);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(219, 46);
            this.btnFiltrar.TabIndex = 66;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // reportEmpleados
            // 
            reportDataSource10.Name = "DatosEmpleados";
            reportDataSource10.Value = this.usuariosBindingSource;
            this.reportEmpleados.LocalReport.DataSources.Add(reportDataSource10);
            this.reportEmpleados.LocalReport.ReportEmbeddedResource = "Proyecto_TP_Integrador.Listados.ListadoDeEmpleados.rdlc";
            this.reportEmpleados.Location = new System.Drawing.Point(11, 162);
            this.reportEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportEmpleados.Name = "reportEmpleados";
            this.reportEmpleados.ServerReport.BearerToken = null;
            this.reportEmpleados.Size = new System.Drawing.Size(812, 416);
            this.reportEmpleados.TabIndex = 65;
            this.reportEmpleados.ZoomPercent = 75;
            this.reportEmpleados.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 686);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ReporteEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteEmpleados";
            this.Load += new System.EventHandler(this.ReporteEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoPAVIDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblReporesYListados;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private ProyectoPAVIDataSet ProyectoPAVIDataSet;
        private ProyectoPAVIDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer estadisticaPuestos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtFechaDesde;
        private System.Windows.Forms.MaskedTextBox txtFechaHasta;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Button btnFiltrar;
        private Microsoft.Reporting.WinForms.ReportViewer reportEmpleados;
    }
}