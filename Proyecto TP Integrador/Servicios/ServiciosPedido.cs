using Proyecto_TP_Integrador.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TP_Integrador.Servicios
{
    internal class ServiciosPedido
    {
        public static List<Plato> GetPlatos()
        {
            List<Plato> lst = new List<Plato>();
            string consultaSQL = "SELECT * FROM platos";
            DataTable tabla = BDHelper.getBDHelper().ConsultaSQL(consultaSQL);
            foreach (DataRow fila in tabla.Rows)
            {
                Plato a = new Plato();
                a.idDelPlato = Convert.ToInt16(fila[0]);    //fila["Id_Plato"]
                a.nombreDelPlato = fila[1].ToString();              //fila["NombrePlato"]
                a.descripPlato = fila[2].ToString();            //fila[DescripcionPlato]
                a.precioDelPlato = Convert.ToInt32(fila[3]);       //fila["PrecioPlato"]
                lst.Add(a);
            }
            return lst;
        }

        public static List<Bebida> GetBebidas()
        {
            List<Bebida> lst = new List<Bebida>();
            string consultaSQL = "SELECT * FROM bebidas";
            DataTable tabla = BDHelper.getBDHelper().ConsultaSQL(consultaSQL);
            foreach (DataRow fila in tabla.Rows)
            {
                Bebida a = new Bebida();
                a.idDeBebida = Convert.ToInt16(fila[0]);    //fila["Id_Plato"]
                a.nombreDeBebida = fila[1].ToString();              //fila["NombrePlato"]
                a.descripBebida = fila[2].ToString();            //fila[DescripcionPlato]
                a.precioDeBebida = Convert.ToInt32(fila[3]);       //fila["PrecioPlato"]
                lst.Add(a);
            }
            return lst;
        }

        public static List<Estado> GetEstados()
        {
            List<Estado> lst = new List<Estado>();
            string consultaSQL = "SELECT * FROM estados";
            DataTable tabla = BDHelper.getBDHelper().ConsultaSQL(consultaSQL);
            foreach (DataRow fila in tabla.Rows)
            {
                Estado a = new Estado();
                a.IdEstado = Convert.ToInt16(fila[0]);    //fila["Id_Plato"]
                a.Nombre = fila[1].ToString();              //fila["NombrePlato"]
                a.Descripcion = fila[2].ToString();            //fila[DescripcionPlato]
                lst.Add(a);
            }
            return lst;
        }



        public static bool AMBPedido(string consulta)
        {
            bool result = BDHelper.getBDHelper().ConsultaParam(consulta);
            return result;
        }


        public static int Next()
        {
            string consultaSQL = "SELECT MAX(IdPedido) FROM pedidos";
            DataTable tabla = BDHelper.getBDHelper().ConsultaSQL(consultaSQL);
            if (tabla.Rows[0][0] == DBNull.Value)
                return 1;
            else
                return (int)tabla.Rows[0][0] + 1;
        }

        public static DataTable CargarGrilla(string Consult)
        {
            DataTable tabla = BDHelper.getBDHelper().ConsultaSQL(Consult);
            return tabla;

        }

        public static string CargarPrecio(string consult)
        {
            string precio = BDHelper.getBDHelper().ConsultaValor(consult);
            return precio;
        }

    }
}
