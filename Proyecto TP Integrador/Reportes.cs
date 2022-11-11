using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_TP_Integrador
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void btnReporteClientes_Click(object sender, EventArgs e)
        {
            ReporteClientes ventana = new ReporteClientes();
            ventana.ShowDialog();
        }

        private void btnReporteEmpleados_Click(object sender, EventArgs e)
        {
            ReporteEmpleados ventana = new ReporteEmpleados();
            ventana.ShowDialog();
        }

        private void btnReporteFacturas_Click(object sender, EventArgs e)
        {
            ReporteFacturas ventana = new ReporteFacturas();
            ventana.ShowDialog();
        }

        private void btnEstadisticaEmpleados_Click(object sender, EventArgs e)
        {
            ReporteEstadisticaEmpleados ventana = new ReporteEstadisticaEmpleados();
            ventana.ShowDialog();
        }

        private void btnReportePedidos_Click(object sender, EventArgs e)
        {
            ReportePedidos ventana = new ReportePedidos();
            ventana.ShowDialog();
        }

        private void btnReportePlatos_Click(object sender, EventArgs e)
        {
            ReportePlatos ventana = new ReportePlatos();
            ventana.ShowDialog();
        }
    }
}
