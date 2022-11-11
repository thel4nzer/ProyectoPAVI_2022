using Microsoft.Reporting.WinForms;
using Proyecto_TP_Integrador.Entidades;
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
    public partial class ReporteFacturas: Form
    {
        public ReporteFacturas()
        {
            InitializeComponent();
        }

        private void ReporteFacturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ProyectoPAVIDataSet.facturas' Puede moverla o quitarla según sea necesario.
            //this.facturasTableAdapter.Fill(this.ProyectoPAVIDataSet.facturas);

            this.reportFacturas.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = CargarFacturas();
            ReportDataSource ds = new ReportDataSource("DatosFacturas", tabla);
            reportFacturas.LocalReport.DataSources.Clear();
            reportFacturas.LocalReport.DataSources.Add(ds);
            reportFacturas.LocalReport.Refresh();
        }

        public static DataTable CargarFacturas()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM facturas";
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime desde;
            DateTime hasta;

            if (DateTime.TryParse(txtFechaDesde.Text, out desde) && (DateTime.TryParse(txtFechaHasta.Text, out hasta)))
            {
                DateTime Fechadesde = DateTime.Parse(txtFechaDesde.Text);
                DateTime Fechahasta = DateTime.Parse(txtFechaHasta.Text);
                DataTable tabla = new DataTable();
                tabla = CargarFacturasFiltro(Fechadesde, Fechahasta);
                //reportEmpleados.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("@pu", puesto)});
                //DATASOURCE}
                reportFacturas.LocalReport.DataSources.Clear();
                reportFacturas.LocalReport.DataSources.Add(new ReportDataSource("DatosFacturas", tabla));
                reportFacturas.RefreshReport();
            }
            else
            {
                MessageBox.Show("Debe ingresar correctamente ambas fechas");
            }
        }

        public static DataTable CargarFacturasFiltro(DateTime desde, DateTime hasta)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM facturas WHERE Fecha between @desd AND @hast";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@desd", desde.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@hast", hasta.ToString("yyyy/MM/dd"));
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
