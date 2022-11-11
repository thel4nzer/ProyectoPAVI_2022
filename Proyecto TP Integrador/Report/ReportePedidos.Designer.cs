namespace Proyecto_TP_Integrador
{
    partial class ReportePedidos
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
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProyectoPAVIDataSet = new Proyecto_TP_Integrador.ProyectoPAVIDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReporesYListados = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.reportPedidos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pedidosTableAdapter = new Proyecto_TP_Integrador.ProyectoPAVIDataSetTableAdapters.pedidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoPAVIDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pedidosBindingSource
            // 
            this.pedidosBindingSource.DataMember = "pedidos";
            this.pedidosBindingSource.DataSource = this.ProyectoPAVIDataSet;
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
            this.panel1.Size = new System.Drawing.Size(897, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblReporesYListados
            // 
            this.lblReporesYListados.AutoSize = true;
            this.lblReporesYListados.Font = new System.Drawing.Font("Perpetua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporesYListados.Location = new System.Drawing.Point(167, 21);
            this.lblReporesYListados.Name = "lblReporesYListados";
            this.lblReporesYListados.Size = new System.Drawing.Size(597, 69);
            this.lblReporesYListados.TabIndex = 65;
            this.lblReporesYListados.Text = "REPORTE DE PEDIDOS";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.Color.White;
            this.lblPuesto.Location = new System.Drawing.Point(124, 124);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(143, 38);
            this.lblPuesto.TabIndex = 20;
            this.lblPuesto.Text = "ESTADO:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(301, 126);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(179, 37);
            this.cmbEstado.TabIndex = 19;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFiltrar.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(545, 117);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(219, 46);
            this.btnFiltrar.TabIndex = 18;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // reportPedidos
            // 
            reportDataSource1.Name = "DatosPedidos";
            reportDataSource1.Value = this.pedidosBindingSource;
            this.reportPedidos.LocalReport.DataSources.Add(reportDataSource1);
            this.reportPedidos.LocalReport.ReportEmbeddedResource = "Proyecto_TP_Integrador.Listados.ListadoDePedidos.rdlc";
            this.reportPedidos.Location = new System.Drawing.Point(115, 201);
            this.reportPedidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportPedidos.Name = "reportPedidos";
            this.reportPedidos.ServerReport.BearerToken = null;
            this.reportPedidos.Size = new System.Drawing.Size(661, 246);
            this.reportPedidos.TabIndex = 21;
            this.reportPedidos.Load += new System.EventHandler(this.reportPedidos_Load);
            // 
            // pedidosTableAdapter
            // 
            this.pedidosTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(897, 502);
            this.Controls.Add(this.reportPedidos);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFiltrar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReportePedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportePedidos";
            this.Load += new System.EventHandler(this.ReportePedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoPAVIDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnFiltrar;
        private Microsoft.Reporting.WinForms.ReportViewer reportPedidos;
        private System.Windows.Forms.Label lblReporesYListados;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private ProyectoPAVIDataSet ProyectoPAVIDataSet;
        private ProyectoPAVIDataSetTableAdapters.pedidosTableAdapter pedidosTableAdapter;
    }
}