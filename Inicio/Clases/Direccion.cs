using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    internal class Direccion
    {
        private int id_direccion;
        private int id_distrito;
        private string descripcion;
        private string referencia;

        public int Id_direccion { get => id_direccion; set => id_direccion = value; }
        public int Id_distrito { get => id_distrito; set => id_distrito = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Referencia { get => referencia; set => referencia = value; }
    }
}
