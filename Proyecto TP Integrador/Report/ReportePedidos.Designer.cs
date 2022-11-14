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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProyectoPAVIDataSet = new Proyecto_TP_Integrador.ProyectoPAVIDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReporesYListados = new System.Windows.Forms.Label();
            this.pedidosTableAdapter = new Proyecto_TP_Integrador.ProyectoPAVIDataSetTableAdapters.pedidosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaHasta = new System.Windows.Forms.MaskedTextBox();
            this.reportPedidos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.estadisticaPedidos = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 81);
            this.panel1.TabIndex = 0;
            // 
            // lblReporesYListados
            // 
            this.lblReporesYListados.AutoSize = true;
            this.lblReporesYListados.Font = new System.Drawing.Font("Perpetua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporesYListados.Location = new System.Drawing.Point(153, 9);
            this.lblReporesYListados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReporesYListados.Name = "lblReporesYListados";
            this.lblReporesYListados.Size = new System.Drawing.Size(473, 55);
            this.lblReporesYListados.TabIndex = 65;
            this.lblReporesYListados.Text = "REPORTE DE PEDIDOS";
            // 
            // pedidosTableAdapter
            // 
            this.pedidosTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(364, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 70;
            this.label1.Text = "HASTA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(110, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 31);
            this.label2.TabIndex = 69;
            this.label2.Text = "DESDE:";
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaDesde.Location = new System.Drawing.Point(220, 112);
            this.txtFechaDesde.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaDesde.Mask = "00/00/0000";
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(124, 35);
            this.txtFechaDesde.TabIndex = 68;
            this.txtFechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaHasta.Location = new System.Drawing.Point(474, 112);
            this.txtFechaHasta.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaHasta.Mask = "00/00/0000";
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(124, 35);
            this.txtFechaHasta.TabIndex = 67;
            this.txtFechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // reportPedidos
            // 
            reportDataSource3.Name = "DatosPedidos";
            reportDataSource3.Value = this.pedidosBindingSource;
            this.reportPedidos.LocalReport.DataSources.Add(reportDataSource3);
            this.reportPedidos.LocalReport.ReportEmbeddedResource = "Proyecto_TP_Integrador.Listados.ListadoDePedidos.rdlc";
            this.reportPedidos.Location = new System.Drawing.Point(14, 230);
            this.reportPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.reportPedidos.Name = "reportPedidos";
            this.reportPedidos.ServerReport.BearerToken = null;
            this.reportPedidos.Size = new System.Drawing.Size(748, 358);
            this.reportPedidos.TabIndex = 66;
            this.reportPedidos.Load += new System.EventHandler(this.reportPedidos_Load);
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.Color.White;
            this.lblPuesto.Location = new System.Drawing.Point(129, 172);
            this.lblPuesto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(116, 31);
            this.lblPuesto.TabIndex = 65;
            this.lblPuesto.Text = "ESTADO:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(255, 172);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(135, 30);
            this.cmbEstado.TabIndex = 64;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFiltrar.Font = new System.Drawing.Font("Perpetua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(434, 169);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(164, 37);
            this.btnFiltrar.TabIndex = 63;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // estadisticaPedidos
            // 
            this.estadisticaPedidos.LocalReport.ReportEmbeddedResource = "Proyecto_TP_Integrador.Listados.EstadisticaPedidos.rdlc";
            this.estadisticaPedidos.Location = new System.Drawing.Point(14, 611);
            this.estadisticaPedidos.Name = "estadisticaPedidos";
            this.estadisticaPedidos.ServerReport.BearerToken = null;
            this.estadisticaPedidos.Size = new System.Drawing.Size(747, 438);
            this.estadisticaPedidos.TabIndex = 71;
            this.estadisticaPedidos.Load += new System.EventHandler(this.estadisticaPedidos_Load_1);
            // 
            // ReportePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(773, 1061);
            this.Controls.Add(this.estadisticaPedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFechaDesde);
            this.Controls.Add(this.txtFechaHasta);
            this.Controls.Add(this.reportPedidos);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label lblReporesYListados;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private ProyectoPAVIDataSet ProyectoPAVIDataSet;
        private ProyectoPAVIDataSetTableAdapters.pedidosTableAdapter pedidosTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtFechaDesde;
        private System.Windows.Forms.MaskedTextBox txtFechaHasta;
        private Microsoft.Reporting.WinForms.ReportViewer reportPedidos;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnFiltrar;
        private Microsoft.Reporting.WinForms.ReportViewer estadisticaPedidos;
    }
}