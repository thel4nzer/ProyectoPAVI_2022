using Proyecto_TP_Integrador.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_TP_Integrador
{
    public partial class RegistroEmpleados : Form
    {
        List<Localidad> lstLocalidades;
        List<Provincia> lstProvincias;
        List<Puesto> lstPuestos;
        List<Sucursal> lstSucursales;
        public RegistroEmpleados()
        {
            InitializeComponent();
        }

        private void CargarComboBoxSucursales()
        {
            lstSucursales = Servicios.ServiciosEmpleado.GetSucursales();
            cmbSucursalEmpleado.DataSource = lstSucursales;
            cmbSucursalEmpleado.DisplayMember = "nombreDeSucursal";
            cmbSucursalEmpleado.ValueMember = "idDeSucursal";
        }

        private void CargarComboBoxPuestos()
        {
            lstPuestos = Servicios.ServiciosEmpleado.GetPuestos();
            cmbPuestoEmpleado.DataSource = lstPuestos;
            cmbPuestoEmpleado.DisplayMember = "nombreDePuesto";
            cmbPuestoEmpleado.ValueMember = "idDePuesto";
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


        private void RegistroEmpleados_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            btnActualizarEmpleado.Enabled = false;
            grillaEmpleados.Visible = false;
            CargarComboBoxProvincias();
            CargarComboBoxPuestos();
            CargarComboBoxSucursales();
            txtIdUsuario.Text = Servicios.ServiciosEmpleado.Next().ToString();
        }

        private void CargarGrilla()
        {
            string cns = "SELECT IdUsuario, NombreDeUsuario, Password, NomEmpleado, ApeEmpleado, NomPuesto, NomSucursal FROM usuarios, puestos, sucursales WHERE usuarios.IdPuesto=puestos.IdPuesto AND usuarios.IdSucursal=sucursales.IdSucursal AND usuarios.EstadoBorrado=1 ";
            DataTable tabla = Servicios.ServiciosEmpleado.CargarGrilla(cns);
            grillaEmpleados.DataSource = tabla;
        }

        private void LimpiarCampos()
        {
            txtNombreEmpleado.Text = "";
            txtApellidoEmpleado.Text = "";
            txtTelefonoEmpleado.Text = "";
            txtCalleEmpleado.Text = "";
            txtAlturaEmpleado.Text = "";
            cmbLocalidad.Text = "";
            cmbProvincias.Text = "";
            txtUsuario.Text = "";
            txtContrasena.Text = "";
            txtRepetirContrasena.Text = "";
            cmbPuestoEmpleado.Text = "";
            cmbSucursalEmpleado.Text = "";
            txtIdUsuario.Text = Servicios.ServiciosEmpleado.Next().ToString();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnActualizarEmpleado.Enabled = false;
        }

        private bool UsuarioExistente(string nomUsu)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT COUNT(*) FROM usuarios WHERE NombreDeUsuario like @usu";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usu", nomUsu);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
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

        private void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || (txtContrasena.Text.Equals("")) || (cmbPuestoEmpleado.SelectedIndex.Equals(-1)) || (cmbSucursalEmpleado.SelectedIndex.Equals(-1)) || (txtRepetirContrasena.Text.Equals("")))
            {
                MessageBox.Show("Falto completar un campo importante sobre Informacion de ingreso o informacion adicional");
            }
            else
            {
                bool usuExiste = UsuarioExistente(txtUsuario.Text);
                if (usuExiste == true)
                {
                    if (txtContrasena.Text.Equals(txtRepetirContrasena.Text))
                    {
                        try
                        {
                            Usuario usu = new Usuario();
                            usu.PuestoEmpleado = lstPuestos[cmbPuestoEmpleado.SelectedIndex].idDePuesto;
                            usu.SucursalEmpleado = lstSucursales[cmbSucursalEmpleado.SelectedIndex].idDeSucursal;
                            usu.NombreDeUsuario = txtNombreEmpleado.Text.Trim();
                            usu.ApellidoDeEmpleado = txtApellidoEmpleado.Text.Trim();
                            usu.TelEmpleado = txtTelefonoEmpleado.Text.Trim();
                            usu.ProvinciaEmpleado = lstProvincias[cmbProvincias.SelectedIndex].IdProvincia;
                            usu.LocalidadEmpleado = lstLocalidades[cmbLocalidad.SelectedIndex].IdLocalidad;
                            usu.PaisEmpleado = txtPaisEmpleado.Text.Trim();
                            usu.CalleEmpleado = txtCalleEmpleado.Text.Trim();
                            usu.NumCalle = txtAlturaEmpleado.Text.Trim();
                            usu.NombreDeEmpleado = txtNombreEmpleado.Text.Trim();
                            usu.Password = txtContrasena.Text.Trim();
                            bool resultado = InsertarUsuario(usu);
                            if (resultado == true)
                            {
                                MessageBox.Show("Empleado agregado correctamente");
                                CargarGrilla();
                                LimpiarCampos();

                            }
                            else
                            {
                                MessageBox.Show("Error al insertar el nuevo usuario");
                            }
                        }
                        catch
                        {
                            throw;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden");
                    }
                }
                else
                {
                    MessageBox.Show("El nombre de usuario ya esta en uso");
                }

            }
        }
        private bool InsertarUsuario(Usuario usu)
        {
            string consulta = "INSERT INTO usuarios (NombreDeUsuario, Password, NomEmpleado, ApeEmpleado, Telefono, Calle, Numero, Pais, Provincia, Localidad, IdPuesto, IdSucursal, EstadoBorrado) VALUES('" + usu.NombreDeUsuario + "','" + usu.Password + "','" + usu.NombreDeEmpleado + "','" + usu.ApellidoDeEmpleado + "','" + usu.TelEmpleado + "','" + usu.CalleEmpleado + "','" + usu.NumCalle + "','" + usu.PaisEmpleado + "'," + usu.ProvinciaEmpleado + "," + usu.LocalidadEmpleado + "," + usu.PuestoEmpleado + "," + usu.SucursalEmpleado + "," + "1" + ")";
            bool result = Servicios.ServiciosEmpleado.AMBEmpleados(consulta);
            return result;
        }

        private void grillaEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice == -1)
            {
            }
            else
            {
                btnActualizarEmpleado.Enabled = true;
                DataGridViewRow filaSeleccionada = grillaEmpleados.Rows[indice];
                string nomusu = filaSeleccionada.Cells["NombreDeUsuario"].Value.ToString();
                Usuario usu = ObtenerUsuario(nomusu);
                CargarCampos(usu);
            }

        }

        private string ValidarPuesto(Usuario ped)
        {
            string consulta = "SELECT NomPuesto FROM puestos WHERE IdPuesto like " + ped.PuestoEmpleado;
            string puesto = Servicios.ServiciosEmpleado.Validar(consulta);
            return puesto;
        }

        private string ValidarSucursal(Usuario ped)
        {
            string consulta = "SELECT NomSucursal FROM sucursales WHERE IdSucursal like " + ped.SucursalEmpleado;
            string sucursal = Servicios.ServiciosEmpleado.Validar(consulta);
            return sucursal;
        }

        private void CargarCampos(Usuario usu)
        {
            txtIdUsuario.Text = Convert.ToString(usu.IdDelUsuario);
            txtUsuario.Text = usu.NombreDeUsuario;
            txtContrasena.Text = usu.Password;
            txtNombreEmpleado.Text = usu.NombreDeEmpleado;
            txtApellidoEmpleado.Text = usu.ApellidoDeEmpleado;
            txtTelefonoEmpleado.Text = usu.TelEmpleado;
            txtCalleEmpleado.Text = usu.CalleEmpleado;
            txtAlturaEmpleado.Text = usu.NumCalle;
            string localidad = ValidarLocalidad(usu);
            cmbLocalidad.Text = localidad;
            string provincia = ValidarProvincia(usu);
            cmbProvincias.Text = provincia;
            txtPaisEmpleado.Text = usu.PaisEmpleado;
            string puesto = ValidarPuesto(usu);
            cmbPuestoEmpleado.Text = puesto;
            string sucursal = ValidarSucursal(usu);
            cmbSucursalEmpleado.Text = sucursal;
        }

        private string ValidarLocalidad(Usuario ped)
        {
            string consulta = "SELECT NomLocalidad FROM localidades WHERE IdLocalidad like " + ped.LocalidadEmpleado;
            string localidad = Servicios.ServiciosEmpleado.Validar(consulta);
            return localidad;
        }

        private string ValidarProvincia(Usuario ped)
        {
            string consulta = "SELECT NomProvincia FROM provincias WHERE IdProvincia like " + ped.ProvinciaEmpleado;
            string provincia = Servicios.ServiciosEmpleado.Validar(consulta);
            return provincia;

        }

        private Usuario ObtenerUsuario(string nomusu)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Usuario usu = new Usuario();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM usuarios WHERE NombreDeUsuario like @nomusu";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nomusu", nomusu);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    usu.IdDelUsuario = int.Parse(dr["IdUsuario"].ToString());
                    usu.NombreDeUsuario = dr["NombreDeUsuario"].ToString();
                    usu.Password = dr["Password"].ToString();
                    usu.PuestoEmpleado = int.Parse(dr["IdPuesto"].ToString());
                    usu.SucursalEmpleado = int.Parse(dr["IdSucursal"].ToString());
                    usu.NombreDeEmpleado = dr["NomEmpleado"].ToString();
                    usu.ApellidoDeEmpleado = dr["ApeEmpleado"].ToString();
                    usu.TelEmpleado = dr["Telefono"].ToString();
                    usu.CalleEmpleado = dr["Calle"].ToString();
                    usu.NumCalle = dr["Numero"].ToString();
                    usu.PaisEmpleado = dr["Pais"].ToString();
                    usu.LocalidadEmpleado = int.Parse(dr["Localidad"].ToString());
                    usu.ProvinciaEmpleado = int.Parse(dr["Provincia"].ToString());

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

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text == txtRepetirContrasena.Text)
            {
                Usuario usu = new Usuario();
                usu.IdDelUsuario = Convert.ToInt32(txtIdUsuario.Text);
                usu.PuestoEmpleado = lstPuestos[cmbPuestoEmpleado.SelectedIndex].idDePuesto;
                usu.SucursalEmpleado = lstSucursales[cmbSucursalEmpleado.SelectedIndex].idDeSucursal;
                usu.NombreDeUsuario = txtNombreEmpleado.Text.Trim();
                usu.ApellidoDeEmpleado = txtApellidoEmpleado.Text.Trim();
                usu.TelEmpleado = txtTelefonoEmpleado.Text.Trim();
                usu.ProvinciaEmpleado = lstProvincias[cmbProvincias.SelectedIndex].IdProvincia;
                usu.LocalidadEmpleado = lstLocalidades[cmbLocalidad.SelectedIndex].IdLocalidad;
                usu.PaisEmpleado = txtPaisEmpleado.Text.Trim();
                usu.CalleEmpleado = txtCalleEmpleado.Text.Trim();
                usu.NumCalle = txtAlturaEmpleado.Text.Trim();
                usu.NombreDeEmpleado = txtNombreEmpleado.Text.Trim();
                usu.Password = txtContrasena.Text.Trim();
                bool resultado = ActualizarEmpleado(usu);
                if (resultado)
                {
                    MessageBox.Show("Empleado modificado correctamente");
                    CargarGrilla();
                    LimpiarCampos();
                    btnActualizarEmpleado.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Error al modificiar el empleado");
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }

        private bool ActualizarEmpleado(Usuario usu)
        {
            string consulta = "UPDATE usuarios SET NombreDeUsuario='" + usu.NombreDeUsuario + "', Password='" + usu.Password + "', NomEmpleado='" + usu.NombreDeEmpleado + "', ApeEmpleado='" + usu.ApellidoDeEmpleado + "', Telefono='" + usu.TelEmpleado + "', Calle='" + usu.CalleEmpleado + "', Numero=" + usu.NumCalle + ", Pais='" + usu.PaisEmpleado + "',  Provincia=" + usu.ProvinciaEmpleado + ", Localidad=" + usu.LocalidadEmpleado + ", IdPuesto=" + usu.PuestoEmpleado + ", IdSucursal=" + usu.SucursalEmpleado + "WHERE IdUsuario like " + usu.IdDelUsuario;
            bool result = Servicios.ServiciosEmpleado.AMBEmpleados(consulta);
            return result;
        }

        private void grillaEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVisualizarGrilla_Click(object sender, EventArgs e)
        {
            grillaEmpleados.Visible = true;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (grillaEmpleados.CurrentRow is null)
            {
                MessageBox.Show("No ha seleccionado ninguna fila...");
            }
            else
            {
                eliminarEmpleado(grillaEmpleados.CurrentRow.Cells["Id"].Value.ToString());
                MessageBox.Show("Registro eliminado con éxito...");
                CargarGrilla();
            }
        }
        private void eliminarEmpleado(string id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "bajaUsuario";
                cmd.Parameters.AddWithValue("@idUsu", SqlDbType.BigInt).Value = Int64.Parse(id);

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

        private void grillaEmpleados_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow fila = (DataGridViewRow)grillaEmpleados.Rows[e.Row.Index];

            eliminarEmpleado(grillaEmpleados.Rows[e.Row.Index].Cells["Id"].Value.ToString());
            MessageBox.Show("Registro eliminado con éxito...");
            grillaEmpleados.Refresh();
        }

        private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboBoxLocalidades();
        }
    }
}
