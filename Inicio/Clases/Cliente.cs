using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    internal class Cliente
    {

        private int id_cliente;
        private string nombre;
        private string apellido;
        private string dui;
        private int? id_cuenta; // Cambiado a int?
        private string direccion;
        private string correo;
        private DateTime fecha_registro;
        private int? id_sucursal; // Cambiado a int?
        private string telefono;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dui { get => dui; set => dui = value; }
        public int? Id_cuenta { get => id_cuenta; set => id_cuenta = value; } // Cambiado a int?
        public string Direccion { get => direccion; set => direccion = value; }
        public string Correo { get => correo; set => correo = value; }
        public DateTime Fecha_registro { get => fecha_registro; set => fecha_registro = value; }
        public int? Id_sucursal { get => id_sucursal; set => id_sucursal = value; } // Cambiado a int?
        public string Telefono { get => telefono; set => telefono = value; }




    }
}
