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
            CargarComboSucursales();
        }

        private void ReporteFacturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ProyectoPAVIDataSet.facturas' Puede moverla o quitarla según sea necesario.
            //this.facturasTableAdapter.Fill(this.ProyectoPAVIDataSet.facturas);

            this.reportFacturas.RefreshReport();
            this.estadisticaFactura.RefreshReport();

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



        private void estadisticaFactura_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = CargarEstadisticaFacturas();
            ReportDataSource ds = new ReportDataSource("DatosEstadisticosFacturas", tabla);
            estadisticaFactura.LocalReport.DataSources.Clear();
            estadisticaFactura.LocalReport.DataSources.Add(ds);
            estadisticaFactura.LocalReport.Refresh();
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

            string nombreSucu = cmbSucursal.Text;
            DataTable tablareporte = new DataTable();
            tablareporte = CargarFacturasSucursal(desde, hasta, nombreSucu);

            reportFacturas.LocalReport.DataSources.Clear();
            reportFacturas.LocalReport.DataSources.Add(new ReportDataSource("DatosFacturas", tablareporte));
            reportFacturas.RefreshReport();


            DataTable tablaGrafico = new DataTable();
            tablaGrafico = CargarEstadisticaSucursal(desde, hasta, nombreSucu);
            estadisticaFactura.LocalReport.DataSources.Clear();
            estadisticaFactura.LocalReport.DataSources.Add(new ReportDataSource("DatosEstadisticosFacturas", tablaGrafico));
            estadisticaFactura.RefreshReport();


        }


        public static DataTable CargarFacturasSucursal(DateTime? desde, DateTime? hasta, string nombre)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT suc.NomSucursal, f.IdFactura, f.IdCliente, f.IdMedioPago, f.Fecha, f.Total FROM sucursales suc INNER JOIN " +
                                    "facturas f ON suc.IdSucursal=f.IdSucursal WHERE f.IdFactura > 0";


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



        public static DataTable CargarEstadisticaFacturas()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT suc.NomSucursal as Nombre, SUM(f.Total) as Cantidad FROM sucursales suc INNER JOIN facturas f ON suc.IdSucursal=f.IdSucursal GROUP BY suc.NomSucursal";
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


        public static DataTable CargarEstadisticaSucursal(DateTime? desde, DateTime? hasta, string nombre)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT suc.NomSucursal as Nombre, SUM(f.Total) as Cantidad FROM sucursales suc " +
                                    "INNER JOIN facturas f ON suc.IdSucursal=f.IdSucursal WHERE IdFactura > 0";
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
                    consulta += " AND suc.NomSucursal like @name ";
                }

                consulta += "GROUP BY suc.NomSucursal";

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

