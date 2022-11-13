using Proyecto_TP_Integrador.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TP_Integrador.Servicios
{
    internal class ServicioCobro
    {
        public static int Next()
        {
            string consultaSQL = "SELECT MAX(IdFactura) FROM facturas";
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

        public static int CargarTotal(string consult)
        {
            int total = BDHelper.getBDHelper().ConsultaValorEntero(consult);
            return total;
        }
    }
}
