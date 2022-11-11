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
    public partial class Puestos : Form
    {
        public Puestos()
        {
            InitializeComponent();
            CargarGrillaPuestos();
        }

        private void Puestos_Load(object sender, EventArgs e)
        {

        }

        private void CargarGrillaPuestos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT IdPuesto, NomPuesto, DescripcionPuesto FROM puestos WHERE EstadoBorrado=1";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                grillaPuestos.DataSource = tabla;

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


        private bool PuestoExiste(string nomPuest)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT COUNT(*) FROM puestos WHERE NomPuesto like @puesto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@puesto", nomPuest);
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

        private void btnAgregarPuesto_Click(object sender, EventArgs e)
        {
            Puesto p = new Puesto();
            p.nombreDePuesto = txtNombrePuesto.Text;
            p.descripPuesto = txtDescripcionPuesto.Text;
            bool puestoExiste = PuestoExiste(txtNombrePuesto.Text);
            if (puestoExiste == true)
            {
                if (txtNombrePuesto.Text != "")
                {
                    bool resultado = InsertarPuestoBD(p);
                    if (resultado)
                    {
                        MessageBox.Show("Puesto agregado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrillaPuestos();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el puesto");
                    }
                }
                else
                {
                    MessageBox.Show("Debe cargar el nombre del puesto", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("EL PUESTO QUE INTENTA INGRESAR YA EXISTE", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool InsertarPuestoBD(Puesto p)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO puestos (NomPuesto, DescripcionPuesto, EstadoBorrado) VALUES(@nomPlatito, @desPlatito, 1)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nomPlatito", p.nombreDePuesto);
                cmd.Parameters.AddWithValue("@desPlatito", p.descripPuesto);
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
            txtNombrePuesto.Text = "";
            txtDescripcionPuesto.Text = "";
            txtIdPuesto.Text = "";
            btnActualizarPuestos.Enabled = false;
        }

        private void btnActualizarPuesto_Click(object sender, EventArgs e)
        {
            Puesto p = new Puesto();
            string id = txtIdPuesto.Text;
            p.nombreDePuesto= txtNombrePuesto.Text;
            p.descripPuesto = txtDescripcionPuesto.Text;
            bool resultado = ActualizarPuesto(id, p);
            if (resultado)
            {
                MessageBox.Show("Puesto actualizado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                CargarGrillaPuestos();
                LimpiarCampos();
                btnActualizarPuestos.Enabled = false;
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el puesto");
            }
        }
        private bool ActualizarPuesto(string id, Puesto p)
        {
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                bool resultado = false;
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    string consulta = "UPDATE puestos SET NomPuesto=@puestito, DescripcionPuesto=@desc WHERE IdPuesto like @id";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@desc", p.descripPuesto);
                    cmd.Parameters.AddWithValue("@puestito", p.nombreDePuesto);
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

        private void grillaPuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice == -1)
            {
            }
            else
            {
                btnActualizarPuestos.Enabled = true;
                DataGridViewRow filaSeleccionada = grillaPuestos.Rows[indice];
                string id = filaSeleccionada.Cells["IdPuesto"].Value.ToString();
                Puesto ped = ObtenerPuesto(id);
                CargarCamposPuesto(ped);
                btnActualizarPuestos.Enabled = true;
            }
        }

        private Puesto ObtenerPuesto(string id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Puesto ped = new Puesto();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM puestos WHERE IdPuesto like @idPuesto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idPuesto", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    ped.idDePuesto = int.Parse(dr["IdPuesto"].ToString());
                    ped.nombreDePuesto = dr["NomPuesto"].ToString();
                    ped.descripPuesto = dr["DescripcionPuesto"].ToString();
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
        private void CargarCamposPuesto(Puesto ped)
        {
            LimpiarCampos();
            txtIdPuesto.Text = Convert.ToString(ped.idDePuesto);
            txtNombrePuesto.Text = Convert.ToString(ped.nombreDePuesto);
            txtDescripcionPuesto.Text = Convert.ToString(ped.descripPuesto);
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminarPuesto_Click(object sender, EventArgs e)
        {
            if (grillaPuestos.CurrentRow is null)
            {
                MessageBox.Show("No ha seleccionado ninguna fila...");
            }
            else
            {
                eliminarPuesto(grillaPuestos.CurrentRow.Cells["IdPuesto"].Value.ToString());
                MessageBox.Show("Registro eliminado con éxito...");
                CargarGrillaPuestos();
            }
        }
        private void eliminarPuesto(string id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "bajaPuesto";
                cmd.Parameters.AddWithValue("@idPuesto", SqlDbType.BigInt).Value = Int64.Parse(id);

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

        private void grillaPuestos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow fila = (DataGridViewRow)grillaPuestos.Rows[e.Row.Index];

            eliminarPuesto(grillaPuestos.Rows[e.Row.Index].Cells["IdPuesto"].Value.ToString());
            MessageBox.Show("Registro eliminado con éxito...");
            grillaPuestos.Refresh();
        }
    }
}
