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
    }
}
