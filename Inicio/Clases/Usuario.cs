using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    internal class Usuario
    {
        private int idUsuario;
        private string clave;
        private string nombreUsuario;
        private string codigoUsuario;
        private int idRol;
        private DateTime fechaCreacion;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public string CodigoUsuario
        {
            get { return codigoUsuario; }
            set { codigoUsuario = value; }
        }

        public int IdRol
        {
            get { return idRol; }
            set { idRol = value; }
        }

        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }







    }
}
