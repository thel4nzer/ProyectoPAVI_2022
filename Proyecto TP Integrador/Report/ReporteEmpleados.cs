using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
    public partial class ReporteEmpleados : Form
    {
        List<Sucursal>lstSucursales;


        public ReporteEmpleados()
        {
            InitializeComponent();
        }

        private void ReporteEmpleados_Load(object sender, EventArgs e)
        {
            CargarComboSucursales();
            // TODO: esta línea de código carga datos en la tabla 'ProyectoPAVIDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.ProyectoPAVIDataSet.usuarios);
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

        private void CargarComboSucursales()
        {
            lstSucursales = Servicios.ServiciosEmpleado.GetSucursales();
            cmbSucursal.DataSource = lstSucursales;
            cmbSucursal.DisplayMember = "nombreDeSucursal";
            cmbSucursal.ValueMember = "idDeSucursal";
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
            tablareporte = CargarEmpleadosFiltro(desde, hasta, nombreSucu);

            reportEmpleados.LocalReport.DataSources.Clear();
            reportEmpleados.LocalReport.DataSources.Add(new ReportDataSource("DatosEmpleados", tablareporte));
            reportEmpleados.RefreshReport();
            if (cmbSucursal.Text != "")
            {
                DataTable tablaGrafico = new DataTable();
                tablaGrafico = CargarEstadisticaPuestos(nombreSucu);
                estadisticaPuestos.LocalReport.DataSources.Clear();
                estadisticaPuestos.LocalReport.DataSources.Add(new ReportDataSource("DatosEstadisticasEmpleados", tablaGrafico));
                estadisticaPuestos.RefreshReport();
            }


        }

        public static DataTable CargarEmpleadosFiltro(DateTime? desde, DateTime? hasta, string nombre)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT suc.NomSucursal, u.IdUsuario, u.NombreDeUsuario, u.ApeEmpleado, u.IdPuesto, u.IdSucursal, u.FechaIngreso FROM sucursales suc INNER JOIN " +
                                    "usuarios u ON suc.IdSucursal=u.IdSucursal WHERE u.IdUsuario > 0";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", nombre);  //fac.fechaPago.ToString("yyyy/MM/dd")
                if (desde.HasValue)
                {
                    consulta += " AND u.FechaIngreso >= CONVERT(char(10), '" + desde.ToString() + "', 111) ";
                }
                if (hasta.HasValue)
                {
                    consulta += " AND u.FechaIngreso <= CONVERT(char(10), '" + hasta.ToString() + "', 111) ";
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

        public static DataTable CargarEstadisticaPuestos(string nombre)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT p.NomPuesto as Nombre, COUNT(u.IdPuesto) as Cantidad FROM sucursales suc " +
                                    "INNER JOIN usuarios u ON suc.IdSucursal=u.IdSucursal INNER JOIN puestos p ON p.IdPuesto = u.IdPuesto WHERE suc.NomSucursal LIKE @name " +
                                    "GROUP BY p.NomPuesto";
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

    }
}
