using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    internal class Sucursale
    {
        private int id_sucursal;
        private int? id_direccion; 
        private int? id_cuenta; 
        private string nombre_sucursal;
        private string hora_cierre;
        private string hora_apertura;

        public int Id_sucursal { get => id_sucursal; set => id_sucursal = value; }
        public int? Id_direccion { get => id_direccion; set => id_direccion = value; } // Cambiado a int?
        public int? Id_cuenta { get => id_cuenta; set => id_cuenta = value; } // Cambiado a int?
        public string Nombre_sucursal { get => nombre_sucursal; set => nombre_sucursal = value; }
        public string Hora_cierre { get => hora_cierre; set => hora_cierre = value; }
        public string Hora_apertura { get => hora_apertura; set => hora_apertura = value; }
    }
}
