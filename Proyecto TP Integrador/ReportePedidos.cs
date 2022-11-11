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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cmbEstado.Text == "")
            {

            }
            else
            {
                DataTable tabla = new DataTable();
                string puesto = Convert.ToString(cmbEstado.SelectedIndex + 1);
                tabla = CargarPedidosFiltro(puesto);
                //reportEmpleados.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("@pu", puesto)});

                //DATASOURCE
                reportPedidos.LocalReport.DataSources.Clear();
                reportPedidos.LocalReport.DataSources.Add(new ReportDataSource("DatosPedidos", tabla));
                reportPedidos.RefreshReport();


            }
        }

        public static DataTable CargarPedidosFiltro(string var)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM pedidos WHERE IdEstado like @pu";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@pu", var);
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
                string consulta = "SELECT * FROM pedidos";
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
