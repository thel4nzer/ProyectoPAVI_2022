using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TP_Integrador.Entidades
{
    public class Usuario
    {
        private int IdUsuario;
        private string NombreUsu;
        private string Pass;
        private string NomEmpleado;
        private string ApeEmpleado;
        private string Telefono;
        private string Calle;
        private string Numero;
        private string Pais;
        private int Provincia;
        private int Localidad;
        private int IdPuesto;
        private int IdSucursal;
        private DateTime FechaIngreso;

        public Usuario()
        {
        }

        public Usuario(string nombreDeUsuario, string password)
        {
            NombreUsu = nombreDeUsuario;
            Pass = password;
        }
        public int IdDelUsuario
        {
            get => IdUsuario;
            set => IdUsuario = value;
        }
        public string NombreDeUsuario
        { get => NombreUsu;
          set => NombreUsu = value;
        }
        public string Password
        {
            get => Pass;
            set => Pass = value;
        }
        public string NombreDeEmpleado
        {
            get => NomEmpleado;
            set => NomEmpleado = value;
        }
        public string ApellidoDeEmpleado
        {
            get => ApeEmpleado;
            set => ApeEmpleado = value;
        }
        public string TelEmpleado
        {
            get => Telefono;
            set => Telefono = value;
        }

        public string CalleEmpleado
        {
            get => Calle;
            set => Calle = value;
        }
        public string NumCalle
        {
            get => Numero;
            set => Numero= value;
        }
        public string PaisEmpleado
        {
            get => Pais;
            set => Pais = value;
        }

        public int ProvinciaEmpleado
        {
            get => Provincia;
            set => Provincia = value;
        }

        public int LocalidadEmpleado
        {
            get => Localidad;
            set => Localidad = value;
        }
        public int PuestoEmpleado
        {
            get => IdPuesto;
            set => IdPuesto = value;
        }
        public int SucursalEmpleado
        {
            get => IdSucursal;
            set => IdSucursal = value;
        }

        public DateTime FechaDeIngreso
        {
            get => FechaIngreso;
            set => FechaIngreso = value;
        }


    }
}
