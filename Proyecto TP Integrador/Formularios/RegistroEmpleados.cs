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
        public RegistroEmpleados()
        {
            InitializeComponent();
            CargarComboBoxPuestos();
            CargarComboBoxSucursales();
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

        private void RegistroEmpleados_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            btnActualizarEmpleado.Enabled = false;
            grillaEmpleados.Visible = false;
            CargarComboBoxProvincias();

        }

        private void CargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT IdUsuario, NombreDeUsuario, Password, NomEmpleado, ApeEmpleado, NomPuesto, NomSucursal FROM usuarios, puestos, sucursales WHERE usuarios.IdPuesto=puestos.IdPuesto AND usuarios.IdSucursal=sucursales.IdSucursal AND usuarios.EstadoBorrado=1 ";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grillaEmpleados.DataSource = tabla;

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
            txtIdUsuario.Text = "";
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
                            usu.PuestoEmpleado = cmbPuestoEmpleado.SelectedIndex + 1;
                            usu.SucursalEmpleado = cmbSucursalEmpleado.SelectedIndex + 1;
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
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO usuarios (NombreDeUsuario, Password, NomEmpleado, ApeEmpleado, Telefono, Calle, Numero, Pais, Provincia, Localidad, IdPuesto, IdSucursal, EstadoBorrado) VALUES(@nombreUsu, @pass, @nomEmp, @apeEmp, @telEmp, @calleEmp, @nroEmp, @paisEmp, @provEmp, @locEmp ,@puestoEmp, @sucEmp, 1)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsu", usu.NombreDeUsuario);
                cmd.Parameters.AddWithValue("@pass", usu.Password);
                cmd.Parameters.AddWithValue("@nomEmp", usu.NombreDeEmpleado);
                cmd.Parameters.AddWithValue("@apeEmp", usu.ApellidoDeEmpleado);
                cmd.Parameters.AddWithValue("@telEmp", usu.TelEmpleado);
                cmd.Parameters.AddWithValue("@calleEmp", usu.CalleEmpleado);
                cmd.Parameters.AddWithValue("@nroEmp", usu.NumCalle);
                cmd.Parameters.AddWithValue("@paisEmp", usu.PaisEmpleado);
                cmd.Parameters.AddWithValue("@provEmp", usu.ProvinciaEmpleado);
                cmd.Parameters.AddWithValue("@locEmp", usu.LocalidadEmpleado);
                cmd.Parameters.AddWithValue("@puestoEmp", usu.PuestoEmpleado);
                cmd.Parameters.AddWithValue("@sucEmp", usu.SucursalEmpleado);
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
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT NomPuesto FROM puestos WHERE IdPuesto like @puesto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@puesto", ped.PuestoEmpleado);
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

        private string ValidarSucursal(Usuario ped)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT NomSucursal FROM sucursales WHERE IdSucursal like @sucu";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@sucu", ped.SucursalEmpleado);
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
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT NomLocalidad FROM localidades WHERE IdLocalidad like @idEst";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idEst", ped.LocalidadEmpleado);
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

        private string ValidarProvincia(Usuario ped)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT NomProvincia FROM provincias WHERE IdProvincia like @idEst";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idEst", ped.ProvinciaEmpleado);
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
                string id = txtIdUsuario.Text;
                usu.PuestoEmpleado = cmbPuestoEmpleado.SelectedIndex + 1;
                usu.SucursalEmpleado = cmbSucursalEmpleado.SelectedIndex + 1;
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
                bool resultado = ActualizarEmpleado(usu, id);
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

        private bool ActualizarEmpleado(Usuario usu, string id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE usuarios SET NombreDeUsuario=@nombreUsu, Password=@pass, NomEmpleado=@nomEmp, ApeEmpleado=@apeEmp, Telefono=@telEmp, Calle=@calleEmp, Numero=@nroEmp, Pais=@paisEmp, Provincia=@provEmp, Localidad=@locEmp, IdPuesto=@puestoEmp, IdSucursal=@sucEmp  WHERE IdUsuario like @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombreUsu", usu.NombreDeUsuario);
                cmd.Parameters.AddWithValue("@pass", usu.Password);
                cmd.Parameters.AddWithValue("@nomEmp", usu.NombreDeEmpleado);
                cmd.Parameters.AddWithValue("@apeEmp", usu.ApellidoDeEmpleado);
                cmd.Parameters.AddWithValue("@telEmp", usu.TelEmpleado);
                cmd.Parameters.AddWithValue("@calleEmp", usu.CalleEmpleado);
                cmd.Parameters.AddWithValue("@nroEmp", usu.NumCalle);
                cmd.Parameters.AddWithValue("@paisEmp", usu.PaisEmpleado);
                cmd.Parameters.AddWithValue("@provEmp", usu.ProvinciaEmpleado);
                cmd.Parameters.AddWithValue("@locEmp", usu.LocalidadEmpleado);
                cmd.Parameters.AddWithValue("@puestoEmp", usu.PuestoEmpleado);
                cmd.Parameters.AddWithValue("@sucEmp", usu.SucursalEmpleado);
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
