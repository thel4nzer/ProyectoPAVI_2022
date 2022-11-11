using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_TP_Integrador
{
    public partial class ReporteEstadisticaFacturas : Form
    {
        public ReporteEstadisticaFacturas()
        {
            InitializeComponent();
        }

        private void ReporteEstadisticaFacturas_Load(object sender, EventArgs e)
        {

            this.ReporteFactura.RefreshReport();
        }

        private void ReporteFactura_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = CargarEstadisticaFacturas();
            ReportDataSource ds = new ReportDataSource("DatosEstadisticosFacturas", tabla);
            ReporteFactura.LocalReport.DataSources.Clear();
            ReporteFactura.LocalReport.DataSources.Add(ds);
            ReporteFactura.LocalReport.Refresh();
        }

        public static DataTable CargarEstadisticaFacturas()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT suc.NomSucursal as Nombre, COUNT(f.IdFactura) as Cantidad FROM sucursales suc INNER JOIN facturas f ON suc.IdSucursal=f.IdSucursal WHERE f.EstadoBorrado ='false' GROUP BY suc.NomSucursal";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
