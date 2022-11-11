namespace Proyecto_TP_Integrador
{
    partial class ReportePlatos
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
            this.platosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProyectoPAVIDataSet = new Proyecto_TP_Integrador.ProyectoPAVIDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReporesYListados = new System.Windows.Forms.Label();
            this.reportPlatos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.platosTableAdapter = new Proyecto_TP_Integrador.ProyectoPAVIDataSetTableAdapters.platosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.platosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoPAVIDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // platosBindingSource
            // 
            this.platosBindingSource.DataMember = "platos";
            this.platosBindingSource.DataSource = this.ProyectoPAVIDataSet;
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
            this.panel1.Size = new System.Drawing.Size(940, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblReporesYListados
            // 
            this.lblReporesYListados.AutoSize = true;
            this.lblReporesYListados.Font = new System.Drawing.Font("Perpetua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporesYListados.Location = new System.Drawing.Point(193, 19);
            this.lblReporesYListados.Name = "lblReporesYListados";
            this.lblReporesYListados.Size = new System.Drawing.Size(570, 69);
            this.lblReporesYListados.TabIndex = 64;
            this.lblReporesYListados.Text = "REPORTE DE PLATOS";
            // 
            // reportPlatos
            // 
            reportDataSource1.Name = "DatosPlatos";
            reportDataSource1.Value = this.platosBindingSource;
            this.reportPlatos.LocalReport.DataSources.Add(reportDataSource1);
            this.reportPlatos.LocalReport.ReportEmbeddedResource = "Proyecto_TP_Integrador.Listados.ListadoDePlatos.rdlc";
            this.reportPlatos.Location = new System.Drawing.Point(33, 178);
            this.reportPlatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportPlatos.Name = "reportPlatos";
            this.reportPlatos.ServerReport.BearerToken = null;
            this.reportPlatos.Size = new System.Drawing.Size(871, 251);
            this.reportPlatos.TabIndex = 1;
            this.reportPlatos.Load += new System.EventHandler(this.reportPlatos_Load);
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.Color.White;
            this.lblPuesto.Location = new System.Drawing.Point(249, 118);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(119, 38);
            this.lblPuesto.TabIndex = 61;
            this.lblPuesto.Text = "DESDE:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Perpetua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(388, 122);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 34);
            this.txtPrecio.TabIndex = 62;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFiltrar.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(527, 116);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(219, 46);
            this.btnFiltrar.TabIndex = 63;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // platosTableAdapter
            // 
            this.platosTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePlatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(940, 478);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.reportPlatos);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReportePlatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportePlatos";
            this.Load += new System.EventHandler(this.ReportePlatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.platosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoPAVIDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportPlatos;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblReporesYListados;
        private System.Windows.Forms.BindingSource platosBindingSource;
        private ProyectoPAVIDataSet ProyectoPAVIDataSet;
        private ProyectoPAVIDataSetTableAdapters.platosTableAdapter platosTableAdapter;
    }
}