using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    internal class Venta
    {
        int Idventa { get; set; }
    
        public DateTime Fecha { get; set; }
        public int? Idcliente { get; set; }
        public int IdUsuario { get; set; }
        public decimal MontoTotal { get; set; }
        public int IdSucursal { get; set; }
        public decimal MontoEnvio { get; set; }
        public int IdTipoPago { get; set; }

        public List<DetalleVenta> Detalles { get; set; }

        public Venta()
        {
            Detalles = new List<DetalleVenta>();
        }








    }
}
