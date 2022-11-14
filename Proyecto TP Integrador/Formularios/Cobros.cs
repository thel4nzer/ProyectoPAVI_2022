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
using System.Drawing.Printing;

namespace Proyecto_TP_Integrador
{
    public partial class Cobros : Form
    {
        List<Localidad> lstLocalidades;
        List<Provincia> lstProvincias;
        List<Sucursal> lstSucursales;
        public Cobros()
        {
            InitializeComponent();
        }

        private void Cobros_Load(object sender, EventArgs e)
        {
            CargarComboBoxSucursales();
            CargarComboBoxProvincias();
            txtIdFactura.Text = Servicios.ServicioCobro.Next().ToString();
        }

        private void CargarComboBoxLocalidades()
        {
            lstLocalidades = Servicios.ServiciosEmpleado.GetLocalidades(lstProvincias[cmbProvincias.SelectedIndex].IdProvincia);
            cmbLocalidad.DataSource = lstLocalidades;
            cmbLocalidad.DisplayMember = "Nombre";
            cmbLocalidad.ValueMember = "IdLocalidad";
        }
        private void CargarComboBoxProvincias()
        {
            lstProvincias = Servicios.ServiciosEmpleado.GetProvincias();
            cmbProvincias.DataSource = lstProvincias;
            cmbProvincias.DisplayMember = "Nombre";
            cmbProvincias.ValueMember = "IdProvincia";
            cmbProvincias.SelectedIndex = 0;
            CargarComboBoxLocalidades();
        }


        private void CargarComboBoxSucursales()
        {
            lstSucursales = Servicios.ServiciosEmpleado.GetSucursales();
            cmbSucursalEmpleado.DataSource = lstSucursales;
            cmbSucursalEmpleado.DisplayMember = "nombreDeSucursal";
            cmbSucursalEmpleado.ValueMember = "idDeSucursal";
        }

        private void CargarGrilla(int mesa)
        {
            string cns = "SELECT IdPedido, NombrePlato, PrecioPlato, NombreBebida, PrecioBebida, IdMesa, NomEstado FROM pedidos, platos, bebidas, estados WHERE pedidos.IdBebida=bebidas.IdBebida AND pedidos.IdPlato=platos.IdPlato AND pedidos.IdEstado=4 AND pedidos.IdEstado=estados.IdEstado AND pedidos.IdMesa=" + mesa + " AND pedidos.EstadoBorrado=1";
            DataTable tabla = Servicios.ServiciosEmpleado.CargarGrilla(cns);
            grillaPedidos.DataSource = tabla;
        }

        private void CargarGrillaFacturas(int dni)
        {
            string consulta = "SELECT IdFactura, facturas.IdCliente, Fecha FROM facturas, clientes WHERE facturas.IdCliente = clientes.IdCliente AND clientes.NumeroDoc=" + dni;
            DataTable tabla = Servicios.ServiciosEmpleado.CargarGrilla(consulta);
            grillaFacturas.DataSource = tabla;
        }

        private void btnBuscarPedidos_Click(object sender, EventArgs e)
        {
            int mesa = cmbMesa.SelectedIndex + 1;
            if (mesa != 0)
            {
                CargarGrilla(mesa);
                if (grillaPedidos.Rows.Count > 0)
                {
                    int resultadoPlatos = CalcularTotalPlatos(mesa);
                    txtTotalPlatos.Text = Convert.ToString(resultadoPlatos);
                    int resultadoBebidas = CalcularTotalBebidas(mesa);
                    txtTotalBebidas.Text = Convert.ToString(resultadoBebidas);
                    int total = resultadoPlatos + resultadoBebidas;
                    txtTotal.Text = Convert.ToString(total);
                }
                else
                {
                    MessageBox.Show("No se encontraron pedidos en esa mesa");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar una mesa!!");
            }
        }

        private int CalcularTotalPlatos(int mesa)
        {
            string consulta = "SELECT SUM(PrecioPlato) FROM pedidos, platos WHERE pedidos.IdMesa=" + mesa + " AND pedidos.IdPlato = platos.IdPlato AND pedidos.IdEstado=4 AND pedidos.EstadoBorrado=1";
            int TotalPlatos = Convert.ToInt32(Servicios.ServicioCobro.CargarTotal(consulta));
            return TotalPlatos;
        }

        private int CalcularTotalBebidas(int mesa)
        {
            string consulta = "SELECT SUM(PrecioBebida) FROM pedidos, bebidas WHERE pedidos.IdMesa=" + mesa + " AND pedidos.IdBebida = bebidas.IdBebida AND pedidos.IdEstado = 4 AND pedidos.EstadoBorrado = 1";
            int TotalBebidas = Convert.ToInt32(Servicios.ServicioCobro.CargarTotal(consulta));
            return TotalBebidas;
        }

        private void btnCobrar_Click_1(object sender, EventArgs e)
        {

            if (txtNombre.Text == "" || txtApellido.Text == "" || txtCalle.Text == "" || txtAltura.Text == "" || txtPais.Text == ""
                || cmbLocalidad.Text == "" || cmbProvincias.Text == "" || cmbTipoDoc.Text == "" || txtNumeroDoc.Text == "" ||
                cmbSucursalEmpleado.Text == "" || cmbMedioPago.Text == "" || cmbMesa.Text == "")
            {
                MessageBox.Show("Para generar una factura debe completar TODOS los campos", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime fecha;
                if (DateTime.TryParse(txtFecha.Text, out fecha))
                {
                    Cliente cli = new Cliente();
                    cli.nomDeCliente = txtNombre.Text.Trim();
                    cli.apeDeCliente = txtApellido.Text.Trim();
                    cli.calleDeCliente = txtCalle.Text.Trim();
                    cli.alturaCalle = txtAltura.Text.Trim();
                    cli.paisClient = txtPais.Text.Trim();
                    cli.localidadClient = lstLocalidades[cmbLocalidad.SelectedIndex].IdLocalidad;
                    cli.provClient = lstProvincias[cmbProvincias.SelectedIndex].IdProvincia;
                    cli.tipoDocumento = cmbTipoDoc.Text.Trim();
                    cli.numeroDoc = txtNumeroDoc.Text.Trim();
                    bool exist = ClienteExiste(cmbTipoDoc.Text, txtNumeroDoc.Text);
                    if (exist)
                    {
                        InsertarCliente(cli);
                    }
                    else
                    {
                        Cliente client = ObtenerCliente(cli.tipoDocumento, cli.numeroDoc);
                        Factura fac = new Factura();
                        fac.idDeCliente = client.idDeCliente;
                        fac.idDeMedioPago = cmbMedioPago.Text;
                        fac.idDeSucursal = lstSucursales[cmbSucursalEmpleado.SelectedIndex].idDeSucursal;
                        fac.fechaPago = DateTime.Parse(txtFecha.Text);
                        fac.idDeFactura = Convert.ToInt32(txtIdFactura.Text);
                        fac.total = Convert.ToInt32(txtTotal.Text);



                        //TransaccionHelper.getBDHelper().conectarConTransaccion();

                        InsertarFactura(fac);
                        int mesita = cmbMesa.SelectedIndex + 1;
                        bool resul = InsertarIdFactura(fac, mesita);

                        //TransaccionHelper.getBDHelper().desconectar();
                        ActualizarEstadoPedido(mesita, fac.idDeFactura);
                        printDocument1 = new PrintDocument();
                        PrinterSettings ps = new PrinterSettings();
                        printDocument1.PrinterSettings = ps;
                        printDocument1.PrintPage += imprimir;
                        printDocument1.Print();
                        CargarGrilla(mesita);
                        LimpiarCampos();
                        txtIdFactura.Text = Servicios.ServicioCobro.Next().ToString();
                        MessageBox.Show("Pedido facturado con exito!!!", "REGISTRO EXITOSO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El formato de la fecha no es correcto");
                }


            }

        }
        private bool ActualizarEstadoBorradoFac(Factura fac)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE facturas SET EstadoBorrado=0 WHERE IdFactura like @fac AND EstadoBorrado=1";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fac", fac.idDeFactura);
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

        private bool ClienteExiste(string tipo, string num)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT COUNT(*) FROM clientes WHERE TipoDoc like @tip AND NumeroDoc like @numero";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tip", tipo);
                cmd.Parameters.AddWithValue("@numero", num);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count >= 1)
                {
                    return false;
                }
                else
                {
                    return true;
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

        private void LimpiarCampos()
        {
            txtTotal.Text = "";
            txtTotalBebidas.Text = "";
            txtTotalPlatos.Text = "";
            txtAltura.Text = "";
            txtCalle.Text = "";
            txtFecha.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNumeroDoc.Text = "";
            txtBusquedaDni.Text = "";
            cmbLocalidad.SelectedIndex = 0;
            cmbMedioPago.Text = "";
            cmbSucursalEmpleado.SelectedIndex = 0;
            cmbTipoDoc.Text = "";
            cmbProvincias.SelectedIndex = 0;
            txtFactura.Text = "";
        }

        private bool ActualizarEstadoPedido(int mesita, int factura)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE pedidos SET EstadoBorrado=0, IdFactura = @id WHERE IdMesa like @mesa AND EstadoBorrado=1 AND IdEstado = 4";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@mesa", mesita);
                cmd.Parameters.AddWithValue("@id", factura);
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


        private Factura ObtenerIdFactura(int idCli, DateTime fechaPago)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Factura fac = new Factura();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT IdFactura FROM facturas WHERE IdCliente like @idcli AND Fecha like @fechita AND EstadoBorrado=1";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idcli", idCli);
                cmd.Parameters.AddWithValue("@fechita", fechaPago);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    fac.idDeFactura = int.Parse(dr["IdFactura"].ToString());
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
            return fac;
        }

        private Cliente ObtenerCliente(string tipo, string numero)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente cli = new Cliente();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT IdCliente FROM clientes WHERE TipoDoc like @tipoDoc AND NumeroDoc like @num";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoDoc", tipo);
                cmd.Parameters.AddWithValue("@num", numero);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    cli.idDeCliente = int.Parse(dr["IdCliente"].ToString());
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
            return cli;
        }

        private void cmbMedioPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMedioPago.SelectedItem.ToString() == "Debito") ;
            {

            }
        }

        private bool InsertarIdFactura(Factura fac, int mesita)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE detallefactura SET EstadoBorrado=0, IdFactura=" + fac.idDeFactura + " WHERE Mesa like " + mesita + " AND EstadoBorrado like 1";



                BDHelper.getBDHelper().EjecutarSQLConTransaccion(consulta);
                BDHelper.getBDHelper().desconectar();

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

        private bool InsertarCliente(Cliente usu)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO clientes (NomCliente, ApeCliente, TipoDoc, NumeroDoc, Calle, Altura, Pais, IdLocalidad, IdProvincia, EstadoBorrado) VALUES(@nom, @ape, @tipoDoc, @nroDoc, @calle, @altura, @pais, @loc, @prov, 1)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nom", usu.nomDeCliente);
                cmd.Parameters.AddWithValue("@ape", usu.apeDeCliente);
                cmd.Parameters.AddWithValue("@tipoDoc", usu.tipoDocumento);
                cmd.Parameters.AddWithValue("@nroDoc", usu.numeroDoc);
                cmd.Parameters.AddWithValue("@calle", usu.calleDeCliente);
                cmd.Parameters.AddWithValue("@altura", usu.alturaCalle);
                cmd.Parameters.AddWithValue("@loc", usu.localidadClient);
                cmd.Parameters.AddWithValue("@prov", usu.provClient);
                cmd.Parameters.AddWithValue("@pais", usu.paisClient);
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


        private void InsertarFactura(Factura fac)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO facturas (IdCliente, IdMedioPago, Fecha, IdSucursal, EstadoBorrado, Total) " +
                                    "VALUES(" + fac.idDeCliente + ",'" + fac.idDeMedioPago + "','" + fac.fechaPago + "'," + fac.idDeSucursal + ", 1," + fac.total +")";


                BDHelper.getBDHelper().conectarConTransaccion();
                BDHelper.getBDHelper().EjecutarSQLConTransaccion(consulta);
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void btnBuscarFactura_Click(object sender, EventArgs e)
        {
            int dni;
            if (txtBusquedaDni.Text != "" && Int32.TryParse(txtBusquedaDni.Text, out dni))
            {
                CargarGrillaFacturas(dni);
            }
        }

        private void imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14);
            int ancho = 300;
            int y = 20;

            e.Graphics.DrawString(cmbSucursalEmpleado.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("FACTURA#" + txtFactura.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("-----DATOS DEL CLIENTE-----", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Nombre:" + txtNombre.Text + "|  Apellido:" + txtApellido.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("DNI:" + txtNumeroDoc.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("TOTAL PLATOS: $" + txtTotalPlatos.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("TOTAL BEBIDAS: $" + txtTotalBebidas.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("TOTAL: $" + txtTotal.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));


        }

        private void grillaFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice == -1)
            {
            }
            else
            {
                DataGridViewRow filaSeleccionada = grillaFacturas.Rows[indice];
                int id = Convert.ToInt32(filaSeleccionada.Cells["dataGridViewTextBoxColumn1"].Value);
                CargarGrillaDetalleFactura(id);
                Factura fac = ObtenerFactura(id);
                Cliente cliente = ObtenerCliente(fac);
                CargarCamposCliente(cliente, fac);
                btnCobrar.Enabled = false;
                txtTotal.Text = CargarTotalFactura(fac.idDeFactura).ToString();
            }
        }

        private int CargarTotalFactura(int id)
        {
            string consulta = "SELECT SUM(Precio) FROM detallefactura WHERE detallefactura.IdFactura=" + id;
            int TotalPlatos = Convert.ToInt32(Servicios.ServicioCobro.CargarTotal(consulta));
            return TotalPlatos;
        }

        private void CargarCamposCliente(Cliente ped, Factura fac)
        {
            LimpiarCampos();
            txtNombre.Text = Convert.ToString(ped.nomDeCliente);
            txtApellido.Text = Convert.ToString(ped.apeDeCliente);
            cmbTipoDoc.Text = Convert.ToString(ped.tipoDocumento);
            txtNumeroDoc.Text = Convert.ToString(ped.numeroDoc);
            txtCalle.Text = Convert.ToString(ped.calleDeCliente);
            txtAltura.Text = Convert.ToString(ped.alturaCalle);
            string localidad = ValidarLocalidad(ped);
            cmbLocalidad.Text = localidad;
            string provincia = ValidarProvincia(ped);
            cmbProvincias.Text = provincia;
            cmbMedioPago.Text = Convert.ToString(fac.idDeMedioPago);
            txtFecha.Text = Convert.ToString(fac.fechaPago);
            string sucursal = ValidarSucursal(fac);
            cmbSucursalEmpleado.Text = sucursal;
            txtIdFactura.Text = Convert.ToString(fac.idDeFactura);

        }

        private string ValidarSucursal(Factura fac)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT NomSucursal FROM sucursales WHERE IdSucursal like @idSuc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idSuc", fac.idDeSucursal);
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

        private string ValidarProvincia(Cliente ped)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT NomProvincia FROM provincias WHERE IdProvincia like @idProv";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProv", ped.provClient);
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


        private string ValidarLocalidad(Cliente ped)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT NomLocalidad FROM localidades WHERE IdLocalidad like @idLoc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idLoc", ped.localidadClient);
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

        private Factura ObtenerFactura(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Factura fac = new Factura();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM facturas WHERE IdFactura like @ideFac";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ideFac", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    fac.idDeFactura = int.Parse(dr["IdFactura"].ToString());
                    fac.idDeMedioPago = dr["IdMedioPago"].ToString();
                    fac.idDeCliente = int.Parse(dr["IdCliente"].ToString());
                    fac.idDeSucursal = int.Parse(dr["IdSucursal"].ToString());
                    fac.fechaPago = DateTime.Parse(dr["Fecha"].ToString());
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
            return fac;
        }

        private Cliente ObtenerCliente(Factura fac)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente ped = new Cliente();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM clientes WHERE IdCliente like @ideCli";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ideCli", fac.idDeCliente);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    ped.nomDeCliente = dr["NomCliente"].ToString();
                    ped.apeDeCliente = dr["ApeCliente"].ToString();
                    ped.tipoDocumento = dr["TipoDoc"].ToString();
                    ped.numeroDoc = dr["NumeroDoc"].ToString();
                    ped.calleDeCliente = dr["Calle"].ToString();
                    ped.alturaCalle = dr["Altura"].ToString();
                    ped.paisClient = dr["Pais"].ToString();
                    ped.localidadClient = int.Parse(dr["IdLocalidad"].ToString());
                    ped.provClient = int.Parse(dr["IdProvincia"].ToString());
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


        private void CargarGrillaDetalleFactura(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT Descripcion, Precio FROM detallefactura WHERE detallefactura.IdFactura like @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grillaDetalleFactura.DataSource = tabla;

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

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnCobrar.Enabled = true;
            txtIdFactura.Text = Servicios.ServicioCobro.Next().ToString();
        }

        private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboBoxLocalidades();
        }
    }
}
