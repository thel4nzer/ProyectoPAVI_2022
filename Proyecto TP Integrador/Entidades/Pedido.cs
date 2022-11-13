using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TP_Integrador.Entidades
{
    public class Pedido
    {
        private int IdPedido;
        private int IdMesa;
        private int IdPlato;
        private int IdBebida;
        private int IdEstado;
        private DateTime FechaPedido;

        public Pedido(int idPedido, int idMesa)
        {
            IdPedido = idPedido;
            IdMesa = idMesa;
        }

        public Pedido()
        {

        }

        public int IdDelPedido
        {
            get => IdPedido;
            set => IdPedido = value;
        }
        public int IdMesaPedido
        {
            get => IdMesa;
            set => IdMesa = value;
        }
        public int IdPlatoPedido
        {
            get => IdPlato;
            set => IdPlato = value;
        }
        public int IdBebidaPedido
        {
            get => IdBebida;
            set => IdBebida = value;
        }
        public int IdEstadoPedido
        {
            get => IdEstado;
            set => IdEstado = value;
        }

        public DateTime FechaDelPedido
        {
            get => FechaPedido;
            set => FechaPedido = value;
        }
    }
}
