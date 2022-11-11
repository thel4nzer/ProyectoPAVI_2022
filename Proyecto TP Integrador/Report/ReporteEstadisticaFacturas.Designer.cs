
namespace Proyecto_TP_Integrador
{
    partial class ReporteEstadisticaFacturas
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
            this.ReporteFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReporteFactura
            // 
            this.ReporteFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReporteFactura.LocalReport.ReportEmbeddedResource = "Proyecto_TP_Integrador.Listados.EstadisticaFacturas.rdlc";
            this.ReporteFactura.Location = new System.Drawing.Point(0, 0);
            this.ReporteFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReporteFactura.Name = "ReporteFactura";
            this.ReporteFactura.ServerReport.BearerToken = null;
            this.ReporteFactura.Size = new System.Drawing.Size(1067, 554);
            this.ReporteFactura.TabIndex = 0;
            this.ReporteFactura.Load += new System.EventHandler(this.ReporteFactura_Load);
            // 
            // ReporteEstadisticaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ReporteFactura);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReporteEstadisticaFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de facturas emitidas por sucursal";
            this.Load += new System.EventHandler(this.ReporteEstadisticaFacturas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReporteFactura;
    }
}