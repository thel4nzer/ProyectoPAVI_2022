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
        public Pedidos(Usuario usu)
        {
            InitializeComponent();
            CargarGrillaPedidos();
            CargarComboBoxPlato();
            CargarComboBoxBebida();
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
        private void CargarComboBoxBebida()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT NombreBebida FROM bebidas";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr != null && dr.Read())
                {
                    cmbBebida.Items.Add(dr["NombreBebida"].ToString());
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

        private void CargarComboBoxPlato()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT NombrePLato FROM platos";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr != null && dr.Read())
                {
                        cmbPlato.Items.Add(dr["NombrePlato"].ToString());
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

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            Pedido p = new Pedido();
            p.IdPlatoPedido = cmbPlato.SelectedIndex + 1;
            p.IdBebidaPedido = cmbBebida.SelectedIndex + 1;
            p.IdMesaPedido = cmbMesa.SelectedIndex + 1;
            p.IdEstadoPedido = cmbEstado.SelectedIndex + 1;
            if(p.IdMesaPedido == 0)
            {
                MessageBox.Show("Debe seleccionar una mesa");
            }
            else
            {
                if ((p.IdPlatoPedido == 0 & p.IdBebidaPedido == 0))
                {
                    MessageBox.Show("No puede crear un pedido sin ningun item. Debe seleccionar al menos una bebida o un plato");
                }
                else
                {
                    if (p.IdEstadoPedido == 4)
                    {
                        MessageBox.Show("No puede crear un pedido con el primer estado como ENTREGADO");
                    }
                    else
                    {
                        bool resultado = InsertarPedidoBD(p);
                        if (resultado)
                        {
                            MessageBox.Show("Pedido agregado correctamente");
                            CargarGrillaPedidos();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar el pedido");
                        }
                    }
                }
            }
            
        }

        private bool InsertarDetallePlato(DetalleFactura pla)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO detalleFactura (Precio, Descripcion, EstadoBorrado, Mesa) VALUES(@prec, @desc, 1, @mesita)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@prec", pla.precio);
                cmd.Parameters.AddWithValue("@desc", pla.descripcion);
                cmd.Parameters.AddWithValue("@mesita", pla.mesa);
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

        private bool InsertarDetalleBebida(DetalleFactura beb)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO detalleFactura (Precio, Descripcion, EstadoBorrado, Mesa) VALUES(@prec, @desc, 1, @mesita)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@prec", beb.precio);
                cmd.Parameters.AddWithValue("@desc", beb.descripcion);
                cmd.Parameters.AddWithValue("@mesita", beb.mesa);
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

        private bool InsertarPedidoBD(Pedido p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO pedidos (IdMesa, IdPlato, IdBebida, IdEstado, EstadoBorrado) VALUES(@idMesita, @idPlatito, @idBebi, @idEstadito, 1)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idMesita", p.IdMesaPedido);
                cmd.Parameters.AddWithValue("@idPlatito", p.IdPlatoPedido);
                cmd.Parameters.AddWithValue("@idBebi", p.IdBebidaPedido);
                cmd.Parameters.AddWithValue("@idEstadito", p.IdEstadoPedido);
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
        private void CargarGrillaPedidos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT IdPedido, NombrePlato, NombreBebida, IdMesa, NomEstado FROM pedidos, platos, bebidas, estados WHERE pedidos.IdBebida=bebidas.IdBebida AND pedidos.IdPlato=platos.IdPlato AND pedidos.IdEstado=estados.IdEstado AND pedidos.EstadoBorrado=1";
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
            string plato = ValidarPlato(ped);
            cmbPlato.Text = plato;
            string bebida = ValidarBebida(ped);
            cmbBebida.Text = bebida;
            string estado = ValidarEstado(ped);
            cmbEstado.Text = estado;
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
                    MessageBox.Show("No puede modificar un pedido entregado");
                }
                else
                {
                    CargarCamposPedido(ped);
                }
            }

        }

        private void LimpiarCampos()
        {
            cmbPlato.Text = "";
            cmbBebida.Text = "";
            cmbMesa.Text = "";
            cmbEstado.Text = "";
            txtId.Text = "";
            txtPrecioBebida.Text = "";
            txtPrecioPlato.Text = "";
        }

        private void btnActualizarPedido_Click(object sender, EventArgs e)
        {
            if (cmbEstado.SelectedIndex + 1 == 4)
            {
                DialogResult dialogResult = MessageBox.Show("Atencion, el estado ENTREGADO permitira facturar el pedido. Esta seguro que quiere actualizarlo?", "ATENCION!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Pedido p = new Pedido();
                    string id = txtId.Text;
                    p.IdPlatoPedido = cmbPlato.SelectedIndex + 1;
                    p.IdBebidaPedido = cmbBebida.SelectedIndex + 1;
                    p.IdEstadoPedido = cmbEstado.SelectedIndex + 1;
                    p.IdMesaPedido = Convert.ToInt32(cmbMesa.Text);
                    bool resultado = ActualizarPedido(id, p);
                    if (resultado)
                    {
                        MessageBox.Show("Pedido actualizado correctamente");
                        if (p.IdEstadoPedido == 4)
                        {
                            DetalleFactura pla = new DetalleFactura();
                            pla.descripcion = cmbPlato.SelectedItem.ToString();
                            pla.precio = CargarPrecioPlato(cmbPlato.SelectedItem.ToString());
                            pla.mesa = cmbMesa.SelectedIndex + 1;
                            InsertarDetallePlato(pla);
                            DetalleFactura beb = new DetalleFactura();
                            beb.descripcion = cmbBebida.SelectedItem.ToString();
                            beb.precio = CargarPrecioBebida(cmbBebida.SelectedItem.ToString());
                            beb.mesa = cmbMesa.SelectedIndex + 1;
                            InsertarDetalleBebida(beb);
                            CargarGrillaPedidos();
                            LimpiarCampos();
                            btnActualizarPedido.Enabled = false;
                        }
                        else
                        {
                            CargarGrillaPedidos();
                            LimpiarCampos();
                            btnActualizarPedido.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el pedido");
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
                string id = txtId.Text;
                p.IdPlatoPedido = cmbPlato.SelectedIndex + 1;
                p.IdBebidaPedido = cmbBebida.SelectedIndex + 1;
                p.IdEstadoPedido = cmbEstado.SelectedIndex + 1;
                p.IdMesaPedido = Convert.ToInt32(cmbMesa.Text);
                bool resultado = ActualizarPedido(id, p);
                if (resultado)
                {
                    MessageBox.Show("Pedido actualizado correctamente");
                    if (p.IdEstadoPedido == 4)
                    {
                        DetalleFactura pla = new DetalleFactura();
                        pla.descripcion = cmbPlato.SelectedItem.ToString();
                        pla.precio = CargarPrecioPlato(cmbPlato.SelectedItem.ToString());
                        pla.mesa = cmbMesa.SelectedIndex + 1;
                        InsertarDetallePlato(pla);
                        DetalleFactura beb = new DetalleFactura();
                        beb.descripcion = cmbBebida.SelectedItem.ToString();
                        beb.precio = CargarPrecioBebida(cmbBebida.SelectedItem.ToString());
                        beb.mesa = cmbMesa.SelectedIndex + 1;
                        InsertarDetalleBebida(beb);
                        CargarGrillaPedidos();
                        LimpiarCampos();
                        btnActualizarPedido.Enabled = false;
                    }
                    else
                    {
                        CargarGrillaPedidos();
                        LimpiarCampos();
                        btnActualizarPedido.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el pedido");
                }
            }
            
        }

        private bool ActualizarPedido(string id, Pedido p)
        {
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                bool resultado = false;
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    string consulta = "UPDATE pedidos SET IdPlato=@platito, IdBebida=@bebi, IdMesa=@mesita, IdEstado=@estadito WHERE IdPedido like @id";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@bebi", p.IdBebidaPedido);
                    cmd.Parameters.AddWithValue("@platito", p.IdPlatoPedido );
                    cmd.Parameters.AddWithValue("@mesita", p.IdMesaPedido);
                    cmd.Parameters.AddWithValue("@estadito", p.IdEstadoPedido);
                    cmd.Parameters.AddWithValue("@id", id);
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
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrarPedido_Click(object sender, EventArgs e)
        {
            if (grillaPedidos.CurrentRow is null)
            {
                MessageBox.Show("No ha seleccionado ninguna fila...");
            }
            else
            {
                eliminarPedido(grillaPedidos.CurrentRow.Cells["IdPedido"].Value.ToString());
                MessageBox.Show("Registro eliminado con éxito...");
                CargarGrillaPedidos();
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
            MessageBox.Show("Registro eliminado con éxito...");
            grillaPedidos.Refresh();
        }

        private void cmbPlato_SelectedIndexChanged(object sender, EventArgs e)
        {
            string plato = cmbPlato.SelectedItem.ToString();
            string precio = CargarPrecioPlato(plato);
            txtPrecioPlato.Text = precio;
        }

        private string CargarPrecioPlato(string plato)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT PrecioPlato FROM platos WHERE NombrePlato like @platito";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@platito", plato);
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

        private void cmbBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bebida = cmbBebida.SelectedItem.ToString();
            string precio = CargarPrecioBebida(bebida);
            txtPrecioBebida.Text = precio;
        }

        private string CargarPrecioBebida(string bebi)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT PrecioBebida FROM bebidas WHERE NombreBebida like @bebida";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@bebida", bebi);
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

    }
}
