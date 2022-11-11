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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProyectoPAVIDataSet = new Proyecto_TP_Integrador.ProyectoPAVIDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReporesYListados = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cmbPuestoEmpleado = new System.Windows.Forms.ComboBox();
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
            this.panel1.Size = new System.Drawing.Size(1227, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblReporesYListados
            // 
            this.lblReporesYListados.AutoSize = true;
            this.lblReporesYListados.Font = new System.Drawing.Font("Perpetua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporesYListados.Location = new System.Drawing.Point(284, 18);
            this.lblReporesYListados.Name = "lblReporesYListados";
            this.lblReporesYListados.Size = new System.Drawing.Size(684, 69);
            this.lblReporesYListados.TabIndex = 66;
            this.lblReporesYListados.Text = "REPORTE DE EMPLEADOS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lblPuesto);
            this.panel2.Controls.Add(this.cmbPuestoEmpleado);
            this.panel2.Controls.Add(this.btnFiltrar);
            this.panel2.Controls.Add(this.reportEmpleados);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1227, 403);
            this.panel2.TabIndex = 1;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.Color.White;
            this.lblPuesto.Location = new System.Drawing.Point(322, 35);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(140, 38);
            this.lblPuesto.TabIndex = 17;
            this.lblPuesto.Text = "PUESTO:";
            // 
            // cmbPuestoEmpleado
            // 
            this.cmbPuestoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuestoEmpleado.FormattingEnabled = true;
            this.cmbPuestoEmpleado.Location = new System.Drawing.Point(469, 37);
            this.cmbPuestoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPuestoEmpleado.Name = "cmbPuestoEmpleado";
            this.cmbPuestoEmpleado.Size = new System.Drawing.Size(179, 37);
            this.cmbPuestoEmpleado.TabIndex = 16;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFiltrar.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(704, 34);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(219, 46);
            this.btnFiltrar.TabIndex = 15;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // reportEmpleados
            // 
            reportDataSource1.Name = "DatosEmpleados";
            reportDataSource1.Value = this.usuariosBindingSource;
            this.reportEmpleados.LocalReport.DataSources.Add(reportDataSource1);
            this.reportEmpleados.LocalReport.ReportEmbeddedResource = "Proyecto_TP_Integrador.Listados.ListadoDeEmpleados.rdlc";
            this.reportEmpleados.Location = new System.Drawing.Point(12, 114);
            this.reportEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportEmpleados.Name = "reportEmpleados";
            this.reportEmpleados.ServerReport.BearerToken = null;
            this.reportEmpleados.Size = new System.Drawing.Size(1203, 262);
            this.reportEmpleados.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(1227, 503);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private Microsoft.Reporting.WinForms.ReportViewer reportEmpleados;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cmbPuestoEmpleado;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblReporesYListados;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private ProyectoPAVIDataSet ProyectoPAVIDataSet;
        private ProyectoPAVIDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
    }
}