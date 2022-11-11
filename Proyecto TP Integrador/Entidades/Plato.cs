using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TP_Integrador.Entidades
{
    public class Plato
    {
        private int IdPlato;
        private string NombrePlato;
        private string DescripcionPlato;
        private int PrecioPlato;

        public Plato(int idPlato, string nombrePlato)
        {
            IdPlato = idPlato;
            NombrePlato = nombrePlato;
        }
        public Plato()
        {

        }

        public int idDelPlato
        {
            get => IdPlato;
            set => IdPlato = value;
        }
        public string nombreDelPlato
        {
            get => NombrePlato;
            set => NombrePlato= value;
        }
        public string descripPlato
        {
            get => DescripcionPlato;
            set => DescripcionPlato = value;
        }
        public int precioDelPlato
        {
            get => PrecioPlato;
            set => PrecioPlato = value;
        }



    }
    
}
