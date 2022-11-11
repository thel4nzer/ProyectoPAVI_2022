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
    class BDHelper
    {
        enum ResultadoTransaccion
        {
            exito, fracaso
        }
        enum tipoConexion
        {
            simple, transaccion
        }

        private SqlConnection miConexion = new SqlConnection();
        private SqlCommand miCmd = new SqlCommand();
        private SqlTransaction miTransaccion = null;
        private ResultadoTransaccion miEstado = ResultadoTransaccion.exito;
        private tipoConexion miTipo = tipoConexion.simple;

        private string string_conexion = @"Data Source=BETA\SQLEXPRESS;Initial Catalog=Almacen;Integrated Security=True";

        private static BDHelper instance; 
        public static BDHelper getBDHelper()
        {
            if (instance == null)
                instance = new BDHelper();
            return instance;
        }

        public DataTable ConsultaSQL(string strSql)
        {
            
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {
                conexion.ConnectionString = string_conexion;
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                

                tabla.Load(cmd.ExecuteReader());
                
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if ((conexion.State == ConnectionState.Open))
                {
                    conexion.Close();
                }

                
                conexion.Dispose();
            }

        }

        public DataTable ConsultaSqlConParametros(string strSql, List<string> sqlParam)
        {
            
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {
                conexion.ConnectionString = string_conexion;
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                

                var indice = 0;
                foreach (var param in sqlParam)
                {
                    if (param != null)
                    {
                        var n_param = "param" + Convert.ToString(indice + 1);
                        cmd.Parameters.AddWithValue(n_param, param);
                    }
                    indice++;
                }

                tabla.Load(cmd.ExecuteReader());
                
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if ((conexion.State == ConnectionState.Open))
                {
                    conexion.Close();
                }

                
                conexion.Dispose();
            }

        }
        public void EjecutarSQL(string strSql)
        {
            
            SqlConnection conexion = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                conexion.ConnectionString = string_conexion;
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if ((conexion.State == ConnectionState.Open))
                {
                    conexion.Close();
                }

                
                conexion.Dispose();
            }

        }
        public void EjecutarSQLConTransaccion(string strSql)
        {
           
            try
            {
                miCmd.CommandType = CommandType.Text;
                miCmd.CommandText = strSql;
                miCmd.ExecuteNonQuery();
                miEstado = ResultadoTransaccion.exito;
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
                miEstado = ResultadoTransaccion.fracaso;
            }
        }
        public void conectarConTransaccion()
        {
            miTipo = tipoConexion.transaccion;
            miEstado = ResultadoTransaccion.exito;
            miConexion.ConnectionString = string_conexion;
            miConexion.Open();
            miTransaccion = miConexion.BeginTransaction();
            miCmd.Transaction = miTransaccion;
            miCmd.Connection = miConexion;
        }
        public bool desconectar()
        {
            if (miTipo == tipoConexion.transaccion)
            {
                if (miEstado == ResultadoTransaccion.exito)
                {
                    miTransaccion.Commit();
                    
                }
                else
                {
                    miTransaccion.Rollback();
                    
                }
                miTipo = tipoConexion.simple;
            }

            if ((miConexion.State == ConnectionState.Open))
            {
                miConexion.Close();
            }

            
            miConexion.Dispose();
            if (miEstado.Equals(ResultadoTransaccion.exito))
                return true;
            else
                return false;
        }
        public object ConsultaSQLScalar(string strSql)
        {
            miCmd.CommandType = CommandType.Text;
            miCmd.CommandText = strSql;
            return miCmd.ExecuteScalar();

        }
    }
}
