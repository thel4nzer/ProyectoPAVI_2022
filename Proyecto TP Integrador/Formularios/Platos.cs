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
    public partial class Platos : Form
    {
        public Platos()
        {
            InitializeComponent();
            CargarGrillaPlatos();
            CargarGrillaBebidas();
        }
        private bool PlatoExistente(string nomPlato)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT COUNT(*) FROM platos WHERE NombrePlato like @platito AND EstadoBorrado=1";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@platito", nomPlato);
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
        private bool BebidaExiste(string nomBebi)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT COUNT(*) FROM bebidas WHERE NombreBebida like @bebida AND EstadoBorrado = 1";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@bebida", nomBebi);
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



        //Botones platos//
        private void btnAgregarPlato_Click(object sender, EventArgs e)
        {
            Plato p = new Plato();
            p.nombreDelPlato = txtNombrePlato.Text;
            p.descripPlato = txtDescripcionPlato.Text;
            int precio;
            if (txtPrecio.Text == "" || !(Int32.TryParse(txtPrecio.Text, out precio)))
            {
                p.precioDelPlato = 0;
            }
            else
            {
                p.precioDelPlato = Convert.ToInt32(txtPrecio.Text);
            }
            bool platoExiste = PlatoExistente(txtNombrePlato.Text);
            if (platoExiste == true)
            {
                if (txtNombrePlato.Text != "")
                {
                    bool resultado = InsertarPlatoBD(p);
                    if (resultado)
                    {
                        MessageBox.Show("El plato fue agregado con exito!!!", "PLATO AGREGADO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrillaPlatos();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No fue posible agregar el plato", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe asignarle un nombre al plato", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El plato que intenta ingresar ya existe", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnActualizarPlato_Click(object sender, EventArgs e)
        {
            Plato p = new Plato();
            string id = txtIdPlato.Text;
            p.nombreDelPlato = txtNombrePlato.Text;
            p.descripPlato = txtDescripcionPlato.Text;
            p.precioDelPlato = Convert.ToInt32(txtPrecio.Text);
            bool resultado = ActualizarPlato(id, p);
            if (resultado)
            {
                MessageBox.Show("Plato actualizado correctamente");
                CargarGrillaPlatos();
                LimpiarCampos();
                btnActualizarPlato.Enabled = false;
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el plato");
            }
        }

        //FIN BOTONES PLATOS//

        //BOTONES BEBIDAS//

        private void btnAgregarBebida_Click(object sender, EventArgs e)
        {
            Bebida p = new Bebida();
            p.nombreDeBebida = txtNombreBebida.Text;
            p.descripBebida = txtDescripcionBebida.Text;
            int precio;
            if (txtPrecioBebida.Text == "" || !(Int32.TryParse(txtPrecioBebida.Text, out precio)))
            {
                p.precioDeBebida = 0;
            }
            else
            {
                p.precioDeBebida = Convert.ToInt32(txtPrecioBebida.Text);
            }
            bool bebidaExiste = BebidaExiste(txtNombreBebida.Text);
            if (bebidaExiste == true)
            {
                if (txtNombreBebida.Text != "")
                {
                    bool resultado = InsertarBebidaBD(p);
                    if (resultado)
                    {
                        MessageBox.Show("Bebida agregada con exito!!!", "BEBIDA AGREGADO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrillaBebidas();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar la bebida", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe cargar el nombre de la bebida obligatoriamente", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La bebida que intenta agregar ya existe", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizarBebida_Click(object sender, EventArgs e)
        {
            Bebida p = new Bebida();
            string id = txtIdBebida.Text;
            p.nombreDeBebida = txtNombreBebida.Text;
            if(txtNombreBebida.Text != "")
            {
                p.descripBebida = txtDescripcionBebida.Text;
                p.precioDeBebida = Convert.ToInt32(txtPrecioBebida.Text);
                bool resultado = ActualizarBebida(id, p);
                if (resultado)
                {
                    MessageBox.Show("Bebida actualizada con exito!!!", "BEBIDA AGREGADA!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrillaBebidas();
                    LimpiarCamposBebidas();
                    btnActualizarBebida.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No fue posible actualizar la bebida!!!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No puede dejar el campo nombre vacio", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //----------------//

        // GRILLAS //
        private void CargarGrillaPlatos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT IdPlato, NombrePlato, DescripcionPlato, PrecioPlato FROM platos WHERE EstadoBorrado=1";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grillaPlatos.DataSource = tabla;

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
        private void CargarGrillaBebidas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT IdBebida, NombreBebida, DescripcionBebida, PrecioBebida FROM bebidas WHERE EstadoBorrado=1";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grillaBebida.DataSource = tabla;

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
        private void grillaPlatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice == -1)
            {
            }
            else
            {
                btnActualizarPlato.Enabled = true;
                DataGridViewRow filaSeleccionada = grillaPlatos.Rows[indice];
                string id = filaSeleccionada.Cells["IdPlato"].Value.ToString();
                Plato ped = ObtenerPlato(id);
                CargarCamposPlato(ped);
                btnActualizarPlato.Enabled = true;
            }
        }


        // FIN GRILLAS //
        private void LimpiarCampos()
        {
            txtNombrePlato.Text = "";
            txtDescripcionPlato.Text = "";
            txtPrecio.Text = "";
            txtIdPlato.Text = "";

        }

        private void LimpiarCamposBebidas()
        {
            txtNombreBebida.Text = "";
            txtDescripcionBebida.Text = "";
            txtIdBebida.Text = "";
            txtPrecioBebida.Text = "";
        }
        private bool InsertarPlatoBD(Plato p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO platos (NombrePlato, DescripcionPlato, PrecioPlato, EstadoBorrado) VALUES(@nomPlatito, @desPlatito, @precioPlatito, 1)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nomPlatito", p.nombreDelPlato);
                cmd.Parameters.AddWithValue("@desPlatito", p.descripPlato);
                cmd.Parameters.AddWithValue("@precioPlatito", p.precioDelPlato);
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

        private bool InsertarBebidaBD(Bebida p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO bebidas (NombreBebida, DescripcionBebida, PrecioBebida, EstadoBorrado) VALUES(@nomBeb, @desBeb, @precioBeb, 1)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nomBeb", p.nombreDeBebida);
                cmd.Parameters.AddWithValue("@desBeb", p.descripBebida);
                cmd.Parameters.AddWithValue("@precioBeb", p.precioDeBebida);
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


        private Plato ObtenerPlato(string id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Plato ped = new Plato();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM platos WHERE IdPlato like @idplat";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idplat", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    ped.idDelPlato = int.Parse(dr["IdPlato"].ToString());
                    ped.nombreDelPlato = dr["NombrePlato"].ToString();
                    ped.descripPlato = dr["DescripcionPlato"].ToString();
                    ped.precioDelPlato = int.Parse(dr["PrecioPlato"].ToString());
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


        private void CargarCamposPlato(Plato ped)
        {
            LimpiarCampos();
            txtIdPlato.Text = Convert.ToString(ped.idDelPlato);
            txtNombrePlato.Text = Convert.ToString(ped.nombreDelPlato);
            txtDescripcionPlato.Text = Convert.ToString(ped.descripPlato);
            txtPrecio.Text = Convert.ToString(ped.precioDelPlato);
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


        private bool ActualizarPlato(string id, Plato p)
        {
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                bool resultado = false;
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    string consulta = "UPDATE platos SET NombrePlato=@platito, DescripcionPlato=@desc, PrecioPlato=@precio WHERE IdPlato like @id";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@desc", p.descripPlato);
                    cmd.Parameters.AddWithValue("@platito", p.nombreDelPlato);
                    cmd.Parameters.AddWithValue("@precio", p.precioDelPlato);
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
        private bool ActualizarBebida(string id, Bebida p)
        {
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                bool resultado = false;
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    string consulta = "UPDATE bebidas SET NombreBebida=@beb, DescripcionBebida=@desc, PrecioBebida=@precio WHERE IdBebida like @id";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@beb", p.nombreDeBebida);
                    cmd.Parameters.AddWithValue("@precio", p.precioDeBebida);
                    cmd.Parameters.AddWithValue("@desc", p.descripBebida);
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

        private Bebida ObtenerBebida(string id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Bebida ped = new Bebida();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM bebidas WHERE IdBebida like @idbeb";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idbeb", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    ped.idDeBebida = int.Parse(dr["IdBebida"].ToString());
                    ped.nombreDeBebida = dr["NombreBebida"].ToString();
                    ped.descripBebida = dr["DescripcionBebida"].ToString();
                    ped.precioDeBebida = int.Parse(dr["PrecioBebida"].ToString());
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
        private void CargarCamposBebida(Bebida ped)
        {
            LimpiarCamposBebidas();
            txtIdBebida.Text = Convert.ToString(ped.idDeBebida);
            txtNombreBebida.Text = Convert.ToString(ped.nombreDeBebida);
            txtDescripcionBebida.Text = Convert.ToString(ped.descripBebida);
            txtPrecioBebida.Text = Convert.ToString(ped.precioDeBebida);
        }

        private void grillaBebidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice == -1)
            {
            }
            else
            {
                btnActualizarBebida.Enabled = true;
                DataGridViewRow filaSeleccionada = grillaBebida.Rows[indice];
                string id = filaSeleccionada.Cells["IdBebida"].Value.ToString();
                Bebida ped = ObtenerBebida(id);
                CargarCamposBebida(ped);
                btnActualizarBebida.Enabled = true;
            }
        }

        private void btnLimpiarCamposBebida_Click(object sender, EventArgs e)
        {
            txtDescripcionBebida.Text = "";
            txtNombreBebida.Text = "";
            txtPrecioBebida.Text = "";
            txtIdBebida.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (grillaPlatos.CurrentRow is null)
            {
                MessageBox.Show("No ha seleccionado ninguna fila...", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eliminarPlato(grillaPlatos.CurrentRow.Cells["IdPlato"].Value.ToString());
                MessageBox.Show("Registro eliminado con éxito...", "REGISTRO ELIMINADO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrillaPlatos();
            }
        }

        private void eliminarPlato(string id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "bajaPlato";
                cmd.Parameters.AddWithValue("@idPlato", SqlDbType.BigInt).Value = Int64.Parse(id);

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

        private void grillaPlatos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow fila = (DataGridViewRow)grillaPlatos.Rows[e.Row.Index];

            eliminarPlato(grillaPlatos.Rows[e.Row.Index].Cells["IdPlato"].Value.ToString());
            MessageBox.Show("Registro eliminado con éxito...", "REGISTRO ELIMINADO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grillaPlatos.Refresh();
        }

        private void btnEliminarBebida_Click(object sender, EventArgs e)
        {
            if (grillaBebida.CurrentRow is null)
            {
                MessageBox.Show("No ha seleccionado ninguna fila...", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eliminarBebida(grillaBebida.CurrentRow.Cells["IdBebida"].Value.ToString());
                MessageBox.Show("Registro eliminado con éxito...", "REGISTRO ELIMINADO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrillaPlatos();
            }
        }
        private void eliminarBebida(string id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "bajaBebida";
                cmd.Parameters.AddWithValue("@IdBebida", SqlDbType.BigInt).Value = Int64.Parse(id);

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

        private void grillaBebida_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow fila = (DataGridViewRow)grillaBebida.Rows[e.Row.Index];

            eliminarBebida(grillaBebida.Rows[e.Row.Index].Cells["IdBebida"].Value.ToString());
            MessageBox.Show("Registro eliminado con éxito...", "REGISTRO ELIMINADO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grillaBebida.Refresh();
        }

        private void Platos_Load(object sender, EventArgs e)
        {

        }
    }
}
