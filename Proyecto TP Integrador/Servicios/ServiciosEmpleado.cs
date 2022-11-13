using Proyecto_TP_Integrador.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TP_Integrador.Servicios
{
    internal class ServiciosEmpleado
    {
        public static List<Localidad> GetLocalidades(int prov)
        {
            List<Localidad> lst = new List<Localidad>();
            string consultaSQL = "SELECT * FROM localidades WHERE IdProvincia like " + prov;
            DataTable tabla = BDHelper.getBDHelper().ConsultaSQL(consultaSQL);
            foreach (DataRow fila in tabla.Rows)
            {
                Localidad a = new Localidad();
                a.IdLocalidad = Convert.ToInt16(fila[0]);    //fila["Id_Plato"]
                a.IdProvincia = Convert.ToInt16(fila[1]);
                a.Nombre = fila[2].ToString();              //fila["NombrePlato"]          //fila[DescripcionPlato]
                lst.Add(a);
            }
            return lst;
        }

        public static List<Provincia> GetProvincias()
        {
            List<Provincia> lst = new List<Provincia>();
            string consultaSQL = "SELECT * FROM provincias";
            DataTable tabla = BDHelper.getBDHelper().ConsultaSQL(consultaSQL);
            foreach (DataRow fila in tabla.Rows)
            {
                Provincia a = new Provincia();
                a.IdProvincia = Convert.ToInt16(fila[0]);    //fila["Id_Plato"]
                a.Nombre = fila[1].ToString();              //fila["NombrePlato"]          //fila[DescripcionPlato]
                lst.Add(a);
            }
            return lst;
        }

        public static List<Puesto> GetPuestos()
        {
            List<Puesto> lst = new List<Puesto>();
            string consultaSQL = "SELECT * FROM puestos";
            DataTable tabla = BDHelper.getBDHelper().ConsultaSQL(consultaSQL);
            foreach (DataRow fila in tabla.Rows)
            {
                Puesto a = new Puesto();
                a.idDePuesto = Convert.ToInt16(fila[0]);    //fila["Id_Plato"]
                a.nombreDePuesto = fila[1].ToString();
                a.descripPuesto = fila[2].ToString(); //fila["NombrePlato"]          //fila[DescripcionPlato]
                lst.Add(a);
            }
            return lst;
        }

        public static List<Sucursal> GetSucursales()
        {
            List<Sucursal> lst = new List<Sucursal>();
            string consultaSQL = "SELECT * FROM sucursales";
            DataTable tabla = BDHelper.getBDHelper().ConsultaSQL(consultaSQL);
            foreach (DataRow fila in tabla.Rows)
            {
                Sucursal a = new Sucursal();
                a.idDeSucursal = Convert.ToInt16(fila[0]);    //fila["Id_Plato"]
                a.nombreDeSucursal = fila[1].ToString(); //fila["NombrePlato"]          //fila[DescripcionPlato]
                lst.Add(a);
            }
            return lst;
        }

        public static bool AMBEmpleados(string consulta)
        {
            bool result = BDHelper.getBDHelper().ConsultaParam(consulta);
            return result;
        }

        public static DataTable CargarGrilla(string Consult)
        {
            DataTable tabla = BDHelper.getBDHelper().ConsultaSQL(Consult);
            return tabla;
        }

        public static string Validar(string consult)
        {
            string resultado = BDHelper.getBDHelper().ConsultaValor(consult);
            return resultado;
        }

        public static int Next()
        {
            string consultaSQL = "SELECT MAX(IdUsuario) FROM usuarios";
            DataTable tabla = BDHelper.getBDHelper().ConsultaSQL(consultaSQL);
            if (tabla.Rows[0][0] == DBNull.Value)
                return 1;
            else
                return (int)tabla.Rows[0][0] + 1;
        }

    }
}
