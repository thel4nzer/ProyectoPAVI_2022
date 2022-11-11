using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TP_Integrador.Entidades
{
    public class Factura
    {
        private int IdFactura;
        private int IdCliente;
        private string IdMedioPago;
        private DateTime Fecha;
        private int IdSucursal;

        public Factura(int idFactura, int idCliente, string idMedioPago, DateTime fecha, int idSucursal)
        {
            IdFactura = idFactura;
            IdCliente = idCliente;
            IdMedioPago = idMedioPago;
            Fecha = fecha;
            IdSucursal = idSucursal;

        }
        public Factura()
        {

        }

        public int idDeFactura
        {
            get => IdFactura;
            set => IdFactura = value;
        }

        public int idDeCliente
        {
            get => IdCliente;
            set => IdCliente = value;
        }

        public string idDeMedioPago
        {
            get => IdMedioPago;
            set => IdMedioPago = value;
        }

        public DateTime fechaPago
        {
            get => Fecha; 
            set => Fecha = value;
        }

        public int idDeSucursal
        {
            get => IdSucursal; 
            set => IdSucursal = value;
        }
       
    }
}
