using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    internal class Envio
    {

        public int IdEnvio { get; set; }
        public int? IdEmpleado { get; set; }
        public int? IdVehiculo { get; set; }
        public bool Entrega { get; set; }
        public int IdVenta { get; set; }

    }
}
