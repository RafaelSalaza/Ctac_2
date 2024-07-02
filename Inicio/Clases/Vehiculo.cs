using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    internal class Vehiculo
    {
        private int id_vehiculo;
        private int id_categoria_vehiculo;
        private int id_sucursal;
        private string placa;
        private string descripcion;
        private string anio;
        private string tipoVehiculo;

        public int Id_vehiculo { get => id_vehiculo; set => id_vehiculo = value; }
        public int Id_categoria_vehiculo { get => id_categoria_vehiculo; set => id_categoria_vehiculo = value; }
        public int Id_sucursal { get => id_sucursal; set => id_sucursal = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Anio { get => anio; set => anio = value; }
        public string TipoVehiculo { get => tipoVehiculo; set => tipoVehiculo = value; }
    }
}
