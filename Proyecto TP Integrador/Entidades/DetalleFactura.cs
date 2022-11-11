using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TP_Integrador.Entidades
{
    public class DetalleFactura
    {
        private int IdDetalleFactura;
        private int IdFactura;
        private string Precio;
        private string Descripcion;
        private int Mesa;


        public DetalleFactura(int idDetalleFactura, int idFactura, string precio, string descrip)
        {
            IdDetalleFactura = idDetalleFactura;
            IdFactura = idFactura;
            Precio = precio;
            Descripcion = descrip;
        }

        public DetalleFactura()
        {

        }

        public int idDeDetalleFactura
        {
            get => IdDetalleFactura;
            set => IdDetalleFactura = value;
        }

        public int idDeFactura
        {
            get => IdFactura;
            set => IdFactura = value;
        }
        public string precio
        {
            get => Precio; 
            set => Precio = value;
        }

        public string descripcion
        {
            get => Descripcion;
            set => Descripcion = value;
        }

        public int mesa
        {
            get => Mesa;
            set => Mesa = value;
        }
    }
}
