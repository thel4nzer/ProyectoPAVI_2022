using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TP_Integrador.Entidades
{
    public class Cliente
    {
        private int IdCliente;
        private string NomCliente;
        private string ApeCliente;
        private string TipoDocumento;
        private string NumeroDoc;
        private string Calle;
        private string Altura;
        private string Pais;
        private int IdLocalidad;
        private int IdProvincia;

        public Cliente(int idCliente, string nomCliente, string apeCliente, string tipoDoc, string numeroDoc, string calle, string altura, string pais, int idLocalidad, int idProvincia)
        {
            IdCliente = idCliente;
            NomCliente = nomCliente;
            ApeCliente = apeCliente;
            TipoDocumento = tipoDoc;
            NumeroDoc = numeroDoc;
            Calle = calle;
            Altura = altura;
            Pais = pais;
            IdLocalidad = idLocalidad;
            IdProvincia = idProvincia;
        }
        public Cliente()
        {

        }

        public int idDeCliente
        {
            get => IdCliente;
            set => IdCliente = value;
        }

        public string nomDeCliente
        {
            get => NomCliente;
            set => NomCliente = value;
        }

        public string apeDeCliente
        {
            get => ApeCliente;
            set => ApeCliente = value;
        }

        public string tipoDocumento
        {
            get => TipoDocumento;
            set => TipoDocumento = value;
        }

        public string numeroDoc
        {
            get => NumeroDoc;
            set => NumeroDoc = value;
        }

        public string calleDeCliente
        {
            get => Calle;
            set => Calle = value;
        }

        public string alturaCalle
        {
            get => Calle;
            set => Calle = value;
        }

        public string paisClient
        {
            get => Pais;
            set => Pais = value;
        }

        public int localidadClient
        {
            get => IdLocalidad;
            set => IdLocalidad = value;
        }

        public int provClient
        {
            get => IdProvincia; 
            set => IdProvincia = value;
        }
    }
}
