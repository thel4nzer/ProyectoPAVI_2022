using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_TP_Integrador.Entidades
{
    class TransaccionHelper
    {
        enum ResultadoTransaccion
        {
            exito, fracaso
        }
        enum tipoConexion
        {
            simple, transaccion
        }

        public SqlConnection miConexion = new SqlConnection();
        public SqlCommand miCmd = new SqlCommand();
        public SqlTransaction miTransaccion = null;
        private ResultadoTransaccion miEstado = ResultadoTransaccion.exito;
        private tipoConexion miTipo = tipoConexion.simple;


        private string string_conexion = @"Data Source=DESKTOP-K7FE51D\SQLEXPRESS;Initial Catalog=ProyectoPAVI;Integrated Security=True";


        private static TransaccionHelper instance;
        public static TransaccionHelper getBDHelper()

        {
            if (instance == null)
                instance = new TransaccionHelper();
            return instance;
        }

        public void EjecutarSQLConTransaccion(string strSql)
        {
            
            try
            {
                
                miCmd.CommandType = CommandType.Text;
                miCmd.CommandText = strSql;
                conectarConTransaccion();
                miCmd.ExecuteNonQuery();
                desconectar();



            }
            catch
            {
                throw;
                miEstado = ResultadoTransaccion.fracaso;
            }
        }
        public void conectarConTransaccion()
        {
            miTipo = tipoConexion.transaccion;
            miEstado = ResultadoTransaccion.exito;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            miConexion.ConnectionString = string_conexion;
            miConexion.Open();
            miTransaccion = miConexion.BeginTransaction();
            miCmd.Transaction = miTransaccion;
            miCmd.Connection = miConexion;
        }
        public void desconectar()
        {
            if (miTipo == tipoConexion.transaccion)
            {
                if (miEstado == ResultadoTransaccion.exito)
                {
                    miTransaccion.Commit();
                    MessageBox.Show("La factura fue generada con exito", "REGISTRO EXITOSO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    miTransaccion.Rollback();
                    MessageBox.Show("La trasacción no pudo realizarse...");
                }
                miTipo = tipoConexion.simple;
            }

            if ((miConexion.State == ConnectionState.Open))
            {
                miConexion.Close();
            }

            
            miConexion.Dispose();

        }
    }
}
