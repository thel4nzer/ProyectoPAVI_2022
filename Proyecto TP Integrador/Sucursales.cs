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
    public partial class Sucursales : Form
    {
        public Sucursales()
        {
            InitializeComponent();
            CargarGrillaSucursales();
        }

        private void Sucursales_Load(object sender, EventArgs e)
        {

        }

        private void CargarGrillaSucursales()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT IdSucursal, TelSucursal, NomSucursal, CalleSucursal, NroSucursal, LocSucursal, PaisSucursal FROM sucursales WHERE EstadoBorrado=1";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grillaSucursales.DataSource = tabla;

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

        private void btnAgregarSucursal_Click(object sender, EventArgs e)
        {
            if (txtNombreSucursal.Text.Trim() == "")
            {
                MessageBox.Show("Debe cargar minimamente el nombre de la sucursal", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Sucursal p = new Sucursal();
                p.nombreDeSucursal = txtNombreSucursal.Text.Trim();
                p.telSucursal = txtTelefono.Text.Trim();
                p.calleSucursal = txtCalle.Text.Trim();
                p.nroSucursal = txtNumero.Text.Trim();
                p.locSucursal = txtLocalidad.Text.Trim();
                p.paisSucursal = txtPais.Text.Trim();
                bool sucursalExiste = SucuExistente(txtNombreSucursal.Text.Trim());
                if (sucursalExiste == true)
                {
                        bool resultado = InsertarSucursalBD(p);
                        if (resultado)
                        {
                            MessageBox.Show("Sucursal agregada correctamente!!", "Registro exitoso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarGrillaSucursales();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar la sucursal");
                        }
                }
                else
                {
                    MessageBox.Show("La sucursal que intenta cargar ya existe", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private bool SucuExistente(string nomSucu)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT COUNT(*) FROM sucursales WHERE NomSucursal like @sucu AND EstadoBorrado = 1";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@sucu", nomSucu);
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

        private bool InsertarSucursalBD(Sucursal p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO sucursales (NomSucursal, TelSucursal, CalleSucursal, NroSucursal, LocSucursal, PaisSucursal, EstadoBorrado) VALUES(@nomSucu, @telSucu, @calleSucu, @nroSucu, @locSucu, @paisSucu, 1)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nomSucu", p.nombreDeSucursal);
                cmd.Parameters.AddWithValue("@telSucu", p.telSucursal);
                cmd.Parameters.AddWithValue("@calleSucu", p.calleSucursal);
                cmd.Parameters.AddWithValue("@nroSucu", p.nroSucursal);
                cmd.Parameters.AddWithValue("@locSucu", p.locSucursal);
                cmd.Parameters.AddWithValue("@paisSucu", p.paisSucursal);
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

        private void LimpiarCampos()
        {
            txtIdSucusrsal.Text = "";
            txtNombreSucursal.Text = "";
            txtTelefono.Text = "";
            txtCalle.Text = "";
            txtNumero.Text = "";
            txtLocalidad.Text = "";
            txtPais.Text = ""; 
            btnActualizarSucursales.Enabled = false;
        }

        private void btnActualizarSucursales_Click(object sender, EventArgs e)
        {
            Sucursal p = new Sucursal();
            string id = txtIdSucusrsal.Text;
            p.nombreDeSucursal = txtNombreSucursal.Text;
            p.telSucursal = txtTelefono.Text;
            p.calleSucursal = txtCalle.Text;
            p.nroSucursal = txtNumero.Text;
            p.locSucursal = txtLocalidad.Text;
            p.paisSucursal = txtPais.Text;

            bool resultado = ActualizarSucursal(id, p);
            if (resultado)
            {
                MessageBox.Show("Sucursal actualizada correctamente");
                CargarGrillaSucursales();
                LimpiarCampos();
                btnActualizarSucursales.Enabled = false;
            }
            else
            {
                MessageBox.Show("No se pudo actualizar la sucursal");
            }
        }

        private bool ActualizarSucursal(string id, Sucursal p)
        {
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                bool resultado = false;
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    string consulta = "UPDATE sucursales SET NomSucursal=@nomSucu, TelSucursal=@telSucu, CalleSucursal = @calleSucu, NroSucursal = @nroSucu, LocSucursal=@localidad, PaisSucursal=@pais WHERE IdSucursal like @id";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nomSucu", p.nombreDeSucursal);
                    cmd.Parameters.AddWithValue("@telSucu", p.telSucursal);
                    cmd.Parameters.AddWithValue("@calleSucu", p.calleSucursal);
                    cmd.Parameters.AddWithValue("@nroSucu", p.nroSucursal);
                    cmd.Parameters.AddWithValue("@localidad", p.locSucursal);
                    cmd.Parameters.AddWithValue("@pais", p.paisSucursal);
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

        private void grillaSucursales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice == -1)
            {
            }
            else
            {
                btnActualizarSucursales.Enabled = true;
                DataGridViewRow filaSeleccionada = grillaSucursales.Rows[indice];
                string id = filaSeleccionada.Cells["IdSucursal"].Value.ToString();
                Sucursal ped = ObtenerSucursal(id);
                CargarCamposSucursal(ped);
                btnActualizarSucursales.Enabled = true;
            }
        }

        private Sucursal ObtenerSucursal(string id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Sucursal ped = new Sucursal();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM sucursales WHERE IdSucursal like @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    ped.idDeSucursal = int.Parse(dr["IdSucursal"].ToString());
                    ped.nombreDeSucursal = dr["NomSucursal"].ToString();
                    ped.telSucursal = dr["TelSucursal"].ToString();
                    ped.calleSucursal = dr["CalleSucursal"].ToString();
                    ped.nroSucursal = dr["NroSucursal"].ToString();
                    ped.locSucursal = dr["LocSucursal"].ToString();
                    ped.paisSucursal = dr["PaisSucursal"].ToString();
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
        private void CargarCamposSucursal(Sucursal ped)
        {
            LimpiarCampos();
            txtIdSucusrsal.Text = Convert.ToString(ped.idDeSucursal);
            txtNombreSucursal.Text = Convert.ToString(ped.nombreDeSucursal);
            txtTelefono.Text = Convert.ToString(ped.telSucursal);
            txtCalle.Text = Convert.ToString(ped.calleSucursal);
            txtNumero.Text = Convert.ToString(ped.nroSucursal);
            txtLocalidad.Text = Convert.ToString(ped.locSucursal);
            txtPais.Text = Convert.ToString(ped.paisSucursal);
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminarPuesto_Click(object sender, EventArgs e)
        {
            if (grillaSucursales.CurrentRow is null)
            {
                MessageBox.Show("No ha seleccionado ninguna fila...");
            }
            else
            {
                eliminarSucursal(grillaSucursales.CurrentRow.Cells["IdSucursal"].Value.ToString());
                MessageBox.Show("Registro eliminado con éxito...");
                CargarGrillaSucursales();
            }
        }
        private void eliminarSucursal(string id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "bajaSucursal";
                cmd.Parameters.AddWithValue("@IdSucursal", SqlDbType.BigInt).Value = Int64.Parse(id);

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

        private void grillaSucursales_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow fila = (DataGridViewRow)grillaSucursales.Rows[e.Row.Index];

            eliminarSucursal(grillaSucursales.Rows[e.Row.Index].Cells["IdSucursal"].Value.ToString());
            MessageBox.Show("Registro eliminado con éxito...");
            grillaSucursales.Refresh();
        }
    }
}
