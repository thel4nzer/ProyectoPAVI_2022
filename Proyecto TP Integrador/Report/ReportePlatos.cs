using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_TP_Integrador
{
    public partial class ReportePlatos : Form
    {
        public ReportePlatos()
        {
            InitializeComponent();
        }

        private void ReportePlatos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ProyectoPAVIDataSet.platos' Puede moverla o quitarla según sea necesario.
            //this.platosTableAdapter.Fill(this.ProyectoPAVIDataSet.platos);

            this.reportPlatos.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            int precio;
            if (int.TryParse(txtPrecio.Text, out precio))
            {
                int PrecioBase = int.Parse(txtPrecio.Text);
                DataTable tabla = new DataTable();
                tabla = CargarPlatosFiltro(PrecioBase);
                //reportEmpleados.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("@pu", puesto)});
                //DATASOURCE}
                reportPlatos.LocalReport.DataSources.Clear();
                reportPlatos.LocalReport.DataSources.Add(new ReportDataSource("DatosPlatos", tabla));
                reportPlatos.RefreshReport();
            }
            else
            {
                MessageBox.Show("Debe ingresar correctamente UN NUMERO");
            }
        }

        public static DataTable CargarPlatosFiltro(int desde)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM platos WHERE PrecioPlato >= @desd";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@desd", desde);
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

        private void reportPlatos_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = CargarPlatos();
            ReportDataSource ds = new ReportDataSource("DatosPlatos", tabla);
            reportPlatos.LocalReport.DataSources.Clear();
            reportPlatos.LocalReport.DataSources.Add(ds);
            reportPlatos.LocalReport.Refresh();
        }

        public static DataTable CargarPlatos()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM platos";
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
