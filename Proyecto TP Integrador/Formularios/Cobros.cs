﻿using Proyecto_TP_Integrador.Entidades;
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
        public Cobros()
        {
            InitializeComponent();
            CargarComboBoxLocalidades();
            CargarComboBoxProvincias();
            CargarComboBoxSucursales();
        }

        private void Cobros_Load(object sender, EventArgs e)
        {

        }

        

        private void CargarComboBoxSucursales()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT NomSucursal FROM sucursales";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr != null && dr.Read())
                {
                    cmbSucursalEmpleado.Items.Add(dr["NomSucursal"].ToString());
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
        private void CargarComboBoxProvincias()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT NomProvincia FROM provincias";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr != null && dr.Read())
                {
                    cmbProvincias.Items.Add(dr["NomProvincia"].ToString());
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

        private void CargarComboBoxLocalidades()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT NomLocalidad FROM localidades";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr != null && dr.Read())
                {
                    cmbLocalidad.Items.Add(dr["NomLocalidad"].ToString());
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



        private void CargarGrillaCobros(int mesa)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT IdPedido, NombrePlato, PrecioPlato, NombreBebida, PrecioBebida, IdMesa, NomEstado FROM pedidos, platos, bebidas, estados WHERE pedidos.IdBebida=bebidas.IdBebida AND pedidos.IdPlato=platos.IdPlato AND estados.NomEstado like @entre AND pedidos.IdMesa=@mesita AND pedidos.EstadoBorrado=1";
                cmd.Parameters.Clear();
                string entregado = "Entregado";
                cmd.Parameters.AddWithValue("@mesita", mesa);
                cmd.Parameters.AddWithValue("@entre", entregado);
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

        private void CargarGrillaFacturas(string dni)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT IdFactura, facturas.IdCliente, Fecha FROM facturas, clientes WHERE facturas.IdCliente = clientes.IdCliente AND clientes.NumeroDoc = @dni and facturas.EstadoBorrado=0";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grillaFacturas.DataSource = tabla;

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

        private void btnBuscarPedidos_Click(object sender, EventArgs e)
        {
            int mesa = cmbMesa.SelectedIndex + 1;
            if (mesa != 0)
            {
                CargarGrillaCobros(mesa);
                int resultadoPlatos = CalcularTotalPlatos(mesa);
                txtTotalPlatos.Text = Convert.ToString(resultadoPlatos);
                int resultadoBebidas = CalcularTotalBebidas(mesa);
                txtTotalBebidas.Text = Convert.ToString(resultadoBebidas);
                int total = resultadoPlatos + resultadoBebidas;
                txtTotal.Text = Convert.ToString(total);
            }
            else
            {

            }
        }

        private int CalcularTotalPlatos(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT SUM(PrecioPlato) FROM pedidos, platos WHERE pedidos.IdMesa = @mesa AND pedidos.IdPlato = platos.IdPlato AND pedidos.IdEstado=4 AND pedidos.EstadoBorrado=1";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@mesa", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                int nombre = Convert.ToInt32(cmd.ExecuteScalar());
                if (nombre != 0 )
                {
                    return nombre;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("No se encontro ningun pedido con esa mesa");
                return 0;
            }
            finally
            {
                cn.Close();

            }
        }

        private int CalcularTotalBebidas(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT SUM(PrecioBebida) FROM pedidos, bebidas WHERE pedidos.IdMesa = @mesa AND pedidos.IdBebida = bebidas.IdBebida AND pedidos.IdEstado=4 AND pedidos.EstadoBorrado=1";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@mesa", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                int nombre = Convert.ToInt32(cmd.ExecuteScalar());
                if (nombre != 0 && nombre != null)
                {
                    return nombre;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                cn.Close();

            }
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
                Cliente cli = new Cliente();
                cli.nomDeCliente = txtNombre.Text;
                cli.apeDeCliente = txtApellido.Text;
                cli.calleDeCliente = txtCalle.Text;
                cli.alturaCalle = txtAltura.Text;
                cli.paisClient = txtPais.Text;
                cli.localidadClient = cmbLocalidad.SelectedIndex + 1;
                cli.provClient = cmbProvincias.SelectedIndex + 1;
                cli.tipoDocumento = cmbTipoDoc.Text;
                cli.numeroDoc = txtNumeroDoc.Text;
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
                    fac.idDeSucursal = cmbSucursalEmpleado.SelectedIndex + 1;
                    fac.fechaPago = DateTime.Parse(txtFecha.Text);



                    //TransaccionHelper.getBDHelper().conectarConTransaccion();

                    InsertarFactura(fac);
                    Factura facturita = ObtenerIdFactura(fac.idDeCliente, fac.fechaPago);
                    txtFactura.Text = Convert.ToString(facturita.idDeFactura);
                    int mesita = cmbMesa.SelectedIndex + 1;
                    bool resul = InsertarIdFactura(facturita, mesita);

                    //TransaccionHelper.getBDHelper().desconectar();
                    ActualizarEstadoBorrado(mesita);
                    ActualizarEstadoBorradoFac(facturita);
                    printDocument1 = new PrintDocument();
                    PrinterSettings ps = new PrinterSettings();
                    printDocument1.PrinterSettings = ps;
                    printDocument1.PrintPage += imprimir;
                    printDocument1.Print();
                    CargarGrillaCobros(mesita);
                    LimpiarCampos();

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
            cmbLocalidad.Text = "";
            cmbMedioPago.Text = "";
            cmbSucursalEmpleado.Text = "";
            cmbTipoDoc.Text = "";
            cmbProvincias.Text = "";
            txtFactura.Text = "";
        }

        private bool ActualizarEstadoBorrado(int mesita)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE pedidos SET EstadoBorrado=0 WHERE IdMesa like @mesa AND EstadoBorrado=1";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@mesa", mesita);
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


        private Factura ObtenerIdFactura(int idCli , DateTime fechaPago)
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
                string consulta = "UPDATE detallefactura SET EstadoBorrado=0, IdFactura=" +fac.idDeFactura+" WHERE Mesa like "+mesita+" AND EstadoBorrado like 1";



                TransaccionHelper.getBDHelper().EjecutarSQLConTransaccion(consulta);

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
            
            //try
            //{
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO facturas (IdCliente, IdMedioPago, Fecha, IdSucursal, EstadoBorrado) " +
                                    "VALUES(" + @fac.idDeCliente +  ",'" + fac.idDeMedioPago + "','" + fac.fechaPago.ToString("yyyy/MM/dd") + "'," + fac.idDeSucursal + ", 1)";

               

                TransaccionHelper.getBDHelper().EjecutarSQLConTransaccion(consulta);
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            
        }

        private void btnBuscarFactura_Click(object sender, EventArgs e)
        {
            string dni = txtBusquedaDni.Text;
            CargarGrillaFacturas(dni);
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
            e.Graphics.DrawString("TOTAL: $" + txtTotal.Text , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));


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
            }
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
        }
    }
}