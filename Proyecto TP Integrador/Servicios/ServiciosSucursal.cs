using Proyecto_TP_Integrador.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TP_Integrador.Servicios
{
    internal class ServiciosSucursal
    {
        public static bool ABMSucursal(string consulta)
        {
            bool result = BDHelper.getBDHelper().ConsultaParam(consulta);
            return result;
        }
    }
}
