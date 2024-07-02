using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    internal class Proveedorn
    {
        private int idProveedor;
        private string nombreProveedor;
        private string correo;
        private string numeroTelefono;
        private string idDireccion;

        public Proveedorn(string nombreProveedor, string correo, string numeroTelefono, string idDireccion)
        {
            this.nombreProveedor = nombreProveedor;
            this.correo = correo;
            this.numeroTelefono = numeroTelefono;
            this.idDireccion = idDireccion;
        }

        public int IdProveedor
        {
            get { return idProveedor; }
            set { idProveedor = value; }
        }

        public string NombreProveedor
        {
            get { return nombreProveedor; }
            set { nombreProveedor = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string NumeroTelefono
        {
            get { return numeroTelefono; }
            set { numeroTelefono = value; }
        }

        public string IdDireccion
        {
            get { return idDireccion; }
            set { idDireccion = value; }
        }


    }
}
