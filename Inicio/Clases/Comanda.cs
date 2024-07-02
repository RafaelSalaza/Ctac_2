using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    internal class Comanda
    {
        private int id_comanda;
        private string nombre;
        private int id_vehiculo;
        private int id_proyecto;

        public int Id_comanda { get => id_comanda; set => id_comanda = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id_vehiculo { get => id_vehiculo; set => id_vehiculo = value; }
        public int Id_proyecto { get => id_proyecto; set => id_proyecto = value; }

        public string PlacaVehiculo { get; set; }
        public string DescripcionVehiculo { get; set; }
        public string AnioVehiculo { get; set; }
        public string NombreProyecto { get; set; }
    }
}
