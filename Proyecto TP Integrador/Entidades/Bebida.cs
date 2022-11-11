using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TP_Integrador.Entidades
{
    public class Bebida
    {
        private int IdBebida;
        private string NombreBebida;
        private string DescripcionBebida;
        private int PrecioBebida;

        public Bebida(int idBebida, string nombreBebida)
        {
            IdBebida = idBebida;
            NombreBebida = nombreBebida;
        }
        public Bebida()
        {

        }

        public int idDeBebida
        {
            get => IdBebida;
            set => IdBebida = value;
        }
        public string nombreDeBebida
        {
            get => NombreBebida;
            set => NombreBebida = value;
        }
        public string descripBebida
        {
            get => DescripcionBebida;
            set => DescripcionBebida = value;
        }
        public int precioDeBebida
        {
            get => PrecioBebida;
            set => PrecioBebida = value;
        }



    }
}
