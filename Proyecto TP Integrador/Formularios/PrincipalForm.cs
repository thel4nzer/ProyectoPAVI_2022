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
    public partial class PrincipalForm : Form
    {
        public PrincipalForm(Usuario usu)
        {
            InitializeComponent();
            lblBienvenido.Text = usu.NombreDeUsuario;
            lblBienvenido.Visible = true;
            btnEmpleado.Enabled = false;
            CargarGrillaPedidosPrincipal();
            bool tienePermiso = PermisosEmpleados(usu);
            if (tienePermiso)
            {
                btnEmpleado.Enabled = true;
            }
            else
            {
                btnEmpleado.Enabled = false;
            }
        }
        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            Timer t1 = new Timer();
            t1.Interval = 60000;
            t1.Tick += timer1_Tick_1;
            t1.Start();
        }

        private void CargarGrillaPedidosPrincipal()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT IdPedido, NombrePlato, NombreBebida, IdMesa, NomEstado FROM pedidos, platos, bebidas, estados WHERE pedidos.IdBebida=bebidas.IdBebida AND pedidos.IdPlato=platos.IdPlato AND estados.IdEstado=3 AND pedidos.IdEstado=estados.IdEstado AND pedidos.EstadoBorrado=1";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grillaPedidos.DataSource = tabla;

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

        private bool PermisosEmpleados(Usuario usu)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT IdPuesto FROM usuarios WHERE NombreDeUsuario like @usua";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usua", usu.NombreDeUsuario);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                string nombre = Convert.ToString(cmd.ExecuteScalar());
                if (nombre == "1")
                {
                    return true;
                };
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();

            }
            return false;
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            RegistroEmpleados ventana = new RegistroEmpleados();
            ventana.ShowDialog();
        }
        private Usuario ObtenerPuesto(string nomusu)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Usuario usu = new Usuario();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT IdPuesto FROM usuarios WHERE NombreDeUsuario like @nomusu";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nomusu", nomusu);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    usu.PuestoEmpleado = int.Parse(dr["IdPuesto"].ToString());
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
            return usu;
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Usuario usu = ObtenerPuesto(lblBienvenido.Text);
            Pedidos ventana = new Pedidos(usu);
            ventana.ShowDialog();
        }

        private void grillaPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool EliminarTodosPedidos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "DELETE FROM pedidos";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        private Pedido ObtenerPedido()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Pedido ped = new Pedido();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM pedidos";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return ped;
        }

        private void grillaEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grillaPedidos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizarGrilla_Click(object sender, EventArgs e)
        {
            CargarGrillaPedidosPrincipal();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            CargarGrillaPedidosPrincipal();
        }

        private void btnPlatos_Click(object sender, EventArgs e)
        {
            Platos ventana = new Platos();
            ventana.ShowDialog();
        }

        private void btnCobros_Click(object sender, EventArgs e)
        {
            Cobros ventana = new Cobros();
            ventana.ShowDialog();
        }

        private void btnPuestos_Click(object sender, EventArgs e)
        {
            Puestos ventana = new Puestos();
            ventana.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sucursales ventana = new Sucursales();
            ventana.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes ventana = new Reportes();
            ventana.ShowDialog();
        }
    }
}
