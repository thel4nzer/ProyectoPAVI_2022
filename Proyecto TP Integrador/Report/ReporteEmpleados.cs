using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
    public partial class ReporteEmpleados : Form
    {
        public ReporteEmpleados()
        {
            InitializeComponent();
            CargarComboBoxPuestos();
        }

        private void ReporteEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ProyectoPAVIDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            //this.usuariosTableAdapter.Fill(this.ProyectoPAVIDataSet.usuarios);

            this.reportEmpleados.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = CargarEmpleados();
            ReportDataSource ds = new ReportDataSource("DatosEmpleados", tabla);
            reportEmpleados.LocalReport.DataSources.Clear();
            reportEmpleados.LocalReport.DataSources.Add(ds);
            reportEmpleados.LocalReport.Refresh();
        }

        public static DataTable CargarEmpleados()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM usuarios";
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
            if (cmbPuestoEmpleado.Text == "")
            {
                
            }
            else
            {
                DataTable tabla = new DataTable();
                string puesto = Convert.ToString(cmbPuestoEmpleado.SelectedIndex + 1);
                tabla = CargarEmpleadosFiltro(puesto);
                //reportEmpleados.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("@pu", puesto)});

                //DATASOURCE
                reportEmpleados.LocalReport.DataSources.Clear();
                reportEmpleados.LocalReport.DataSources.Add(new ReportDataSource("DatosEmpleados", tabla));
                reportEmpleados.RefreshReport();
            

            }


        }

        public static DataTable CargarEmpleadosFiltro(string var)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM usuarios WHERE IdPuesto like @pu";
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

        private void CargarComboBoxPuestos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT NomPuesto FROM puestos";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr != null && dr.Read())
                {
                    cmbPuestoEmpleado.Items.Add(dr["NomPuesto"].ToString());
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
    }
}
