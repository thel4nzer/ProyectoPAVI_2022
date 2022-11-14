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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || (txtContrasena.Text.Equals("")))
            {
                MessageBox.Show("Debe ingresar un usuario y contraseña!!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nombreDeUsuario = txtUsuario.Text;
                string password = txtContrasena.Text;
                bool resultado = false;
                try
                {
                    resultado = ValidarUsuario(nombreDeUsuario, password);
                    if (resultado == true)
                    {
                        Usuario usu = new Usuario(nombreDeUsuario, password);
                        PrincipalForm ventana = new PrincipalForm(usu);
                        ventana.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario y/o constraseña incorrectos!!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar el usuario!!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private bool ValidarUsuario(string nombreDeUsuario, string password)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT NombreDeUsuario FROM usuarios WHERE NombreDeUsuario like @nombreUsu AND Password like @pass";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsu", nombreDeUsuario);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count.Equals(1))
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }

                return resultado;
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

        private void contrasena_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
