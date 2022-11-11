using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TP_Integrador.Entidades
{
    public class Puesto
    {
        private int IdPuesto;
        private string NombrePuesto;
        private string DescripcionPuesto;

        public Puesto(int idPuesto, string nombrePuesto)
        {
            IdPuesto = idPuesto;
            NombrePuesto = nombrePuesto;
        }
        public Puesto()
        {

        }

        public int idDePuesto
        {
            get => IdPuesto;
            set => IdPuesto = value;
        }
        public string nombreDePuesto
        {
            get => NombrePuesto;
            set => NombrePuesto = value;
        }
        public string descripPuesto
        {
            get => DescripcionPuesto;
            set => DescripcionPuesto = value;
        }



    }
}
