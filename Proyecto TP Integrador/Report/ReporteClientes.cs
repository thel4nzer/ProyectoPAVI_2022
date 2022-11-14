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
    public partial class ReporteClientes : Form
    {
        public ReporteClientes()
        {
            InitializeComponent();
            CargarComboSucursales();
        }

        private void CargarComboSucursales()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT NomSucursal FROM sucursales WHERE EstadoBorrado = 1";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr != null && dr.Read())
                {
                    cmbSucursal.Items.Add(dr["NomSucursal"].ToString());
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

        private void ReporteClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ProyectoPAVIDataSet.clientes' Puede moverla o quitarla según sea necesario.
            //this.clientesTableAdapter.Fill(this.ProyectoPAVIDataSet.clientes);

            this.reportClientes.RefreshReport();
            this.estadisticaClientes.RefreshReport();
        }

        private void reportClientes_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = CargarClientes();
            ReportDataSource ds = new ReportDataSource("DatosClientes", tabla);
            reportClientes.LocalReport.DataSources.Clear();
            reportClientes.LocalReport.DataSources.Add(ds);
            reportClientes.LocalReport.Refresh();
        }

        public static DataTable CargarClientes()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM clientes";
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


            DataTable tablareporte = new DataTable();
            string sucu = cmbSucursal.Text;
            tablareporte = CargarClientesFiltro(desde, hasta, sucu);

            reportClientes.LocalReport.DataSources.Clear();
            reportClientes.LocalReport.DataSources.Add(new ReportDataSource("DatosClientes", tablareporte));
            reportClientes.RefreshReport();


            DataTable tablaGrafico = new DataTable();
            
            tablaGrafico = CargarEstadisticaClientes(sucu);
            estadisticaClientes.LocalReport.DataSources.Clear();
            estadisticaClientes.LocalReport.DataSources.Add(new ReportDataSource("DatosEstadisticosClientes", tablaGrafico));
            estadisticaClientes.RefreshReport();


        }

        public static DataTable CargarClientesFiltro(DateTime? desde, DateTime? hasta, string nombre)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT c.IdCliente, c.NomCliente, c.ApeCliente, c.TipoDoc, c.NumeroDoc, c.IdLocalidad FROM clientes c INNER JOIN " +
                                    "facturas f ON c.IdCliente=f.IdCliente INNER JOIN sucursales suc ON f.IdSucursal = suc.IdSucursal WHERE f.IdFactura > 0";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", nombre);

                if (desde.HasValue)
                {
                    consulta += " AND f.Fecha >= CONVERT(char(10), '" + desde.ToString() + "', 111) ";
                }
                if (hasta.HasValue)
                {
                    consulta += " AND f.Fecha <= CONVERT(char(10), '" + hasta.ToString() + "', 111) ";
                }
                if (nombre != "")
                {
                    consulta += " AND suc.NomSucursal like @name";
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

        public static DataTable CargarEstadisticaClientes(string nombre)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT c.ApeCliente as Nombre, COUNT(f.IdFactura) as Cantidad FROM sucursales suc " +
                                    "INNER JOIN facturas f ON suc.IdSucursal=f.IdSucursal INNER JOIN clientes c ON c.IdCliente = f.IdCliente WHERE suc.NomSucursal LIKE @name " +
                                    "GROUP BY c.ApeCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", nombre);


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

        private void estadisticaClientes_Load(object sender, EventArgs e)
        {
            DataTable tablaGrafico = new DataTable();
            estadisticaClientes.LocalReport.DataSources.Clear();
            estadisticaClientes.LocalReport.DataSources.Add(new ReportDataSource("DatosEstadisticosClientes", tablaGrafico));
            estadisticaClientes.RefreshReport();
        }
    }
}

