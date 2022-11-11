using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TP_Integrador.Entidades
{
    public class Sucursal
    {
        private int IdSucursal;
        private string NomSucursal;
        private string TelSucursal;
        private string CalleSucursal;
        private string NroSucursal;
        private string LocSucursal;
        private string PaisSucursal;



        public Sucursal(int idSucursal, string nombreSucursal)
        {
            IdSucursal = idSucursal;
            NomSucursal = nombreSucursal;
        }
        public Sucursal()
        {

        }

        public int idDeSucursal
        {
            get => IdSucursal;
            set => IdSucursal = value;
        }
        public string nombreDeSucursal
        {
            get => NomSucursal;
            set => NomSucursal = value;
        }
        public string telSucursal
        {
            get => TelSucursal;
            set => TelSucursal = value;
        }

        public string calleSucursal
        {
            get => CalleSucursal;
            set => CalleSucursal = value;
        }
        public string nroSucursal
        {
            get => NroSucursal;
            set => NroSucursal = value;
        }
        public string locSucursal
        {
            get => LocSucursal;
            set => LocSucursal = value;
        }
        public string paisSucursal
        {
            get => PaisSucursal;
            set => PaisSucursal = value;
        }
    }
}

