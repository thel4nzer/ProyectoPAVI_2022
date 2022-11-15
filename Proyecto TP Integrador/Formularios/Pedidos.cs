using Proyecto_TP_Integrador.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_TP_Integrador
{
    public partial class Pedidos : Form
    {
        List<Plato> lstPlatos;
        List<Bebida> lstBebidas;
        List<Estado> lstEstados;
        public Pedidos(Usuario usu)
        {
            InitializeComponent();
            if (usu.PuestoEmpleado == 4)
            {
                btnAgregarPedido.Enabled = false;
                cmbBebida.Enabled = false;
                cmbMesa.Enabled = false;
                cmbPlato.Enabled = false;
            }
            else
            {
                btnAgregarPedido.Enabled = true;
            }
        }



        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            if (cmbPlato.SelectedIndex != -1 && cmbBebida.SelectedIndex != -1)
            {
                if (cmbEstado.SelectedIndex + 1 == 4)
                {
                    MessageBox.Show("No puede crear un pedido con el primer estado como ENTREGADO", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cmbMesa.SelectedIndex != -1)
                    {
                        Pedido p = new Pedido();
                        p.IdPlatoPedido = lstPlatos[cmbPlato.SelectedIndex].idDelPlato; //dp.Articulo = lstArticulos[cboArticulo.SelectedIndex]
                        p.IdBebidaPedido = lstBebidas[cmbBebida.SelectedIndex].idDeBebida;  //cmbBebida.SelectedIndex + 1;
                        p.IdMesaPedido = cmbMesa.SelectedIndex + 1;
                        p.IdEstadoPedido = lstEstados[cmbEstado.SelectedIndex].IdEstado;
                        p.FechaDelPedido = DateTime.Now;
                        bool resultado = InsertarPedidoBD(p);
                        if (resultado)
                        {
                            MessageBox.Show("Pedido agregado con exito!!!", "PEDIDO AGREGADO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarGrillaPedidos();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar el pedido", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Olvido seleccionar una mesa", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un plato o una bebida", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool InsertarDetallePlato(DetalleFactura pla)
        {
            string consulta = "INSERT INTO detalleFactura (Precio, Descripcion, EstadoBorrado, Mesa) VALUES(" + pla.precio + ",'" + pla.descripcion + "'," + "1" + "," + pla.mesa + ")";
            bool result = Servicios.ServiciosPedido.AMBPedido(consulta);
            return result;

        }

        private bool InsertarDetalleBebida(DetalleFactura beb)
        {
            string consulta = "INSERT INTO detalleFactura (Precio, Descripcion, EstadoBorrado, Mesa) VALUES(" + beb.precio + ",'" + beb.descripcion + "'," + "1" + "," + beb.mesa + ")";
            bool result = Servicios.ServiciosPedido.AMBPedido(consulta);
            return result;
        }

        private bool InsertarPedidoBD(Pedido p)
        {
            string consulta = "INSERT INTO pedidos (IdMesa, IdPlato, IdBebida, IdEstado, EstadoBorrado, FechaPedido) VALUES(" + p.IdMesaPedido + "," + p.IdPlatoPedido + "," + p.IdBebidaPedido + "," + p.IdEstadoPedido + ", 1,'" + p.FechaDelPedido + "')";
            bool result = Servicios.ServiciosPedido.AMBPedido(consulta);
            return result;
        }
        private void CargarGrillaPedidos()
        {
            string cns = "SELECT IdPedido, NombrePlato, NombreBebida, IdMesa, NomEstado FROM pedidos, platos, bebidas, estados WHERE pedidos.IdBebida=bebidas.IdBebida AND pedidos.IdPlato=platos.IdPlato AND pedidos.IdEstado=estados.IdEstado AND pedidos.EstadoBorrado=1";
            DataTable tabla = Servicios.ServiciosPedido.CargarGrilla(cns);
            grillaPedidos.DataSource = tabla;
        }
        private Pedido ObtenerPedido(string id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Pedido ped = new Pedido();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM pedidos WHERE IdPedido like @ideped";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ideped", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    ped.IdDelPedido = int.Parse(dr["IdPedido"].ToString());
                    ped.IdPlatoPedido = int.Parse(dr["IdPlato"].ToString());
                    ped.IdBebidaPedido = int.Parse(dr["IdBebida"].ToString());
                    ped.IdMesaPedido = int.Parse(dr["IdMesa"].ToString());
                    ped.IdEstadoPedido = int.Parse(dr["IdEstado"].ToString());
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
            return ped;
        }

        private string ValidarPlato(Pedido ped)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT NombrePlato FROM platos WHERE IdPlato like @idPlato";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idPlato", ped.IdPlatoPedido);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                string nombre = Convert.ToString(cmd.ExecuteScalar());
                return nombre;
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

        private string ValidarBebida(Pedido ped)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT NombreBebida FROM bebidas WHERE IdBebida like @idBebi";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idBebi", ped.IdBebidaPedido);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                string nombre = Convert.ToString(cmd.ExecuteScalar());
                return nombre;
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

        private string ValidarEstado(Pedido ped)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT NomEstado FROM estados WHERE IdEstado like @idEst";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idEst", ped.IdEstadoPedido);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                string nombre = Convert.ToString(cmd.ExecuteScalar());
                return nombre;
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


        private void CargarCamposPedido(Pedido ped)
        {
            LimpiarCampos();
            txtId.Text = Convert.ToString(ped.IdDelPedido);
            cmbMesa.Text = Convert.ToString(ped.IdMesaPedido);
            //cmbBebida.Text = Convert.ToString(ped.IdBebidaPedido);
            string plato = ValidarPlato(ped);
            cmbPlato.Text = plato;
            string bebida = ValidarBebida(ped);
            cmbBebida.Text = bebida;
            string estado = ValidarEstado(ped);
            cmbEstado.Text = estado;
            txtPrecioBebida.Text = CargarPrecioBebida(ped.IdBebidaPedido);
            txtPrecioPlato.Text = CargarPrecioPlato(ped.IdPlatoPedido);
        }

        private void grillaPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice == -1)
            {
            }
            else
            {
                LimpiarCampos();
                btnActualizarPedido.Enabled = true;
                DataGridViewRow filaSeleccionada = grillaPedidos.Rows[indice];
                string id = filaSeleccionada.Cells["IdPedido"].Value.ToString();
                Pedido ped = ObtenerPedido(id);
                if (ped.IdEstadoPedido.Equals(4))
                {
                    MessageBox.Show("No puede modificar un pedido entregado", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CargarCamposPedido(ped);
                    btnBorrarPedido.Enabled = true;
                    btnActualizarPedido.Enabled = true;
                    btnAgregarPedido.Enabled = false;
                }
            }

        }

        private void LimpiarCampos()
        {
            cmbPlato.Text = "";
            cmbBebida.Text = "";
            cmbMesa.Text = "";
            cmbEstado.Text = "";
            txtId.Text = Servicios.ServiciosPedido.Next().ToString();
            txtPrecioBebida.Text = "";
            txtPrecioPlato.Text = "";
            btnAgregarPedido.Enabled = true;
        }

        private void btnActualizarPedido_Click(object sender, EventArgs e)
        {
            if (cmbEstado.SelectedIndex + 1 == 4)
            {
                DialogResult dialogResult = MessageBox.Show("Atencion, el estado ENTREGADO permitira facturar el pedido. Esta seguro que quiere actualizarlo???", "ATENCION!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Pedido p = new Pedido();
                    p.IdDelPedido = Convert.ToInt32(txtId.Text);
                    p.IdPlatoPedido = lstPlatos[cmbPlato.SelectedIndex].idDelPlato; //dp.Articulo = lstArticulos[cboArticulo.SelectedIndex]
                    p.IdBebidaPedido = lstBebidas[cmbBebida.SelectedIndex].idDeBebida;  //cmbBebida.SelectedIndex + 1;
                    p.IdEstadoPedido = lstEstados[cmbEstado.SelectedIndex].IdEstado;
                    p.IdMesaPedido = Convert.ToInt32(cmbMesa.Text);
                    bool resultado = ActualizarPedido(p);
                    if (resultado)
                    {
                        MessageBox.Show("Pedido actualizado con exito!!!", "PEDIDO ACTUALIZADO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DetalleFactura pla = new DetalleFactura();
                        pla.descripcion = cmbPlato.Text;
                        pla.precio = CargarPrecioPlato(lstPlatos[cmbPlato.SelectedIndex].idDelPlato);
                        pla.mesa = cmbMesa.SelectedIndex + 1;
                        InsertarDetallePlato(pla);
                        DetalleFactura beb = new DetalleFactura();
                        beb.descripcion = cmbBebida.Text;
                        beb.precio = CargarPrecioBebida(lstBebidas[cmbBebida.SelectedIndex].idDeBebida);
                        beb.mesa = cmbMesa.SelectedIndex + 1;
                        InsertarDetalleBebida(beb);
                        CargarGrillaPedidos();
                        LimpiarCampos();
                        btnActualizarPedido.Enabled = false;
                        btnBorrarPedido.Enabled = false;
                        
                    }
                    else
                    {
                        MessageBox.Show("No fue posible actualizar el pedido", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    cmbEstado.Text = "";
                }
            }
            else
            {
                Pedido p = new Pedido();
                p.IdDelPedido = Convert.ToInt32(txtId.Text);
                p.IdPlatoPedido = lstPlatos[cmbPlato.SelectedIndex].idDelPlato; //dp.Articulo = lstArticulos[cboArticulo.SelectedIndex]
                p.IdBebidaPedido = lstBebidas[cmbBebida.SelectedIndex].idDeBebida;  //cmbBebida.SelectedIndex + 1;
                p.IdEstadoPedido = lstEstados[cmbEstado.SelectedIndex].IdEstado;
                p.IdMesaPedido = Convert.ToInt32(cmbMesa.Text);
                bool resultado = ActualizarPedido(p);
                if (resultado)
                {
                    MessageBox.Show("Pedido actualizado con exito!!!", "PEDIDO ACTUALIZADO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrillaPedidos();
                    LimpiarCampos();
                    btnActualizarPedido.Enabled = false;
                    btnBorrarPedido.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No fue posible actualizar el pedido", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private bool ActualizarPedido(Pedido p)
        {
            string consulta = "UPDATE pedidos SET IdPlato= " + p.IdPlatoPedido + ", IdBebida=" + p.IdBebidaPedido + ", IdMesa=" + p.IdMesaPedido + ", IdEstado=" + p.IdEstadoPedido + " WHERE IdPedido=" + p.IdDelPedido;
            bool result = Servicios.ServiciosPedido.AMBPedido(consulta);
            return result;
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            CargarPlatos();
            CargarBebidas();
            CargarEstados();
            CargarGrillaPedidos();
            btnBorrarPedido.Enabled = false;
            txtId.Text = Convert.ToString(Servicios.ServiciosPedido.Next());
            cmbMesa.SelectedIndex = 0;
        }

        private void CargarPlatos()
        {
            lstPlatos = Servicios.ServiciosPedido.GetPlatos();
            cmbPlato.DataSource = lstPlatos;
            cmbPlato.DisplayMember = "nombreDelPlato";
            cmbPlato.ValueMember = "idDelPlato";
            cmbPlato.SelectedIndex = 0;
        }

        private void CargarBebidas()
        {
            lstBebidas = Servicios.ServiciosPedido.GetBebidas();
            cmbBebida.DataSource = lstBebidas;
            cmbBebida.DisplayMember = "nombreDeBebida";
            cmbBebida.ValueMember = "idDeBebida";
            cmbBebida.SelectedIndex = 0;
        }

        private void CargarEstados()
        {
            lstEstados = Servicios.ServiciosPedido.GetEstados();
            cmbEstado.DataSource = lstEstados;
            cmbEstado.DisplayMember = "Nombre";
            cmbEstado.ValueMember = "IdEstado";
            cmbEstado.SelectedIndex = 0;
        }

        private void btnBorrarPedido_Click(object sender, EventArgs e)
        {
            if (grillaPedidos.CurrentRow is null)
            {
                MessageBox.Show("No ha seleccionado ninguna fila...", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(grillaPedidos.CurrentRow.Cells["IdPedido"].Value.ToString() != "Entregado")
                {
                    eliminarPedido(grillaPedidos.CurrentRow.Cells["IdPedido"].Value.ToString());
                    MessageBox.Show("Pedido eliminado con éxito...", "PEDIDO ELIMINADO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrillaPedidos();
                    btnBorrarPedido.Enabled = false;
                    btnAgregarPedido.Enabled = true;
                }
                else
                {
                    MessageBox.Show("NO puede eliminar un pedido entregado", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void eliminarPedido(string idPedido)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "bajaPedido";
                cmd.Parameters.AddWithValue("@id", SqlDbType.BigInt).Value = Int64.Parse(idPedido);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
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

        private void grillaPedidos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow fila = (DataGridViewRow)grillaPedidos.Rows[e.Row.Index];

            eliminarPedido(grillaPedidos.Rows[e.Row.Index].Cells["IdPedido"].Value.ToString());
            MessageBox.Show("Pedido eliminado con éxito...", "PEDIDO ELIMINADO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            grillaPedidos.Refresh();
        }

        private void cmbPlato_SelectedIndexChanged(object sender, EventArgs e)
        {
            int plato = lstPlatos[cmbPlato.SelectedIndex].idDelPlato;
            string precio = CargarPrecioPlato(plato);
            txtPrecioPlato.Text = precio;
        }

        private string CargarPrecioPlato(int plato)
        {
            string consulta = "SELECT PrecioPlato FROM platos WHERE IdPlato like " + plato;
            string precio = Servicios.ServiciosPedido.CargarPrecio(consulta);
            return precio;
        }

        private void cmbBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bebida = lstBebidas[cmbBebida.SelectedIndex].idDeBebida;
            string precio = CargarPrecioBebida(bebida);
            txtPrecioBebida.Text = precio;
        }

        private string CargarPrecioBebida(int bebi)
        {
            string consulta = "SELECT PrecioBebida FROM bebidas WHERE IdBebida like " + bebi;
            string precio = Servicios.ServiciosPedido.CargarPrecio(consulta);
            return precio;
        }
    }
}
