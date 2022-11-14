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
    public partial class ReportePedidos : Form
    {
        public ReportePedidos()
        {
            InitializeComponent();
            CargarComboEstado();
        }

        public static DateTime? TryParse(string text)
        {
            DateTime date;
            if (DateTime.TryParse(text, out date))
            {
                return date;
            }
            else
            {
                return null;
            }
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime? desde = TryParse(txtFechaDesde.Text);
            DateTime? hasta = TryParse(txtFechaHasta.Text);

            if (desde == null)
            {
                txtFechaDesde.Text = "";
            }

            if (hasta == null)
            {
                txtFechaHasta.Text = "";
            }

            DataTable tabla = new DataTable();
            string estado = cmbEstado.Text;
            tabla = CargarPedidosFiltro(desde, hasta, estado);
            //reportEmpleados.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("@pu", puesto)});

            //DATASOURCE
            reportPedidos.LocalReport.DataSources.Clear();
            reportPedidos.LocalReport.DataSources.Add(new ReportDataSource("DatosPedidos", tabla));
            reportPedidos.RefreshReport();



        }

        public static DataTable CargarPedidosFiltro(DateTime? desde, DateTime? hasta, string var)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT p.IdPedido, p.IdMesa, p.IdPlato, p.IdBebida, p.IdFactura, p.FechaPedido FROM pedidos p INNER JOIN " +
                                  "estados e ON p.IdEstado = e.IdEstado WHERE p.IdPedido > 0";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@pu", var);

                if (desde.HasValue)
                {
                    consulta += " AND p.FechaPedido >= CONVERT(char(10), '" + desde.ToString() + "', 111) ";
                }
                if (hasta.HasValue)
                {
                    consulta += " AND p.FechaPedido <= CONVERT(char(10), '" + hasta.ToString() + "', 111) ";
                }

                if (var != "")
                {
                    consulta += " AND e.NomEstado like @pu ";
                }

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

        private void CargarComboEstado()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT NomEstado FROM estados";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr != null && dr.Read())
                {
                    cmbEstado.Items.Add(dr["NomEstado"].ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private void ReportePedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ProyectoPAVIDataSet.pedidos' Puede moverla o quitarla según sea necesario.
            //this.pedidosTableAdapter.Fill(this.ProyectoPAVIDataSet.pedidos);

            this.reportPedidos.RefreshReport();

            this.estadisticaPedidos.RefreshReport();
        }

        private void reportPedidos_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = CargarPedidos();
            ReportDataSource ds = new ReportDataSource("DatosPedidos", tabla);
            reportPedidos.LocalReport.DataSources.Clear();
            reportPedidos.LocalReport.DataSources.Add(ds);
            reportPedidos.LocalReport.Refresh();
        }

        public static DataTable CargarPedidos()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM pedidos p";
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
        public static DataTable CargarEstadisticaPedidos()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT suc.NomSucursal as Nombre, COUNT(p.IdEstado) as Cantidad FROM sucursales suc INNER JOIN " +
                                  "facturas f ON suc.IdSucursal=f.IdSucursal INNER JOIN pedidos p ON p.IdFactura = f.IdFactura WHERE p.IdEstado = 4 GROUP BY suc.NomSucursal";
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

        private void estadisticaPedidos_Load_1(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = CargarEstadisticaPedidos();
            ReportDataSource ds = new ReportDataSource("DatosEstadisticosPedidos", tabla);
            estadisticaPedidos.LocalReport.DataSources.Clear();
            estadisticaPedidos.LocalReport.DataSources.Add(ds);
            estadisticaPedidos.LocalReport.Refresh();
        }

    }
}
