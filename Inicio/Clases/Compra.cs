using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    internal class Compra
    {


        public int IdCompra { get; set; }
        public DateTime FechaCompra { get; set; }
        public int IdProveedor { get; set; }
        public int IdUsuario { get; set; }
        public decimal Total { get; set; }
        public int IdTipoPago { get; set; }

        public List<DetalleCompra> Detalles { get; set; }

        public Compra()
        {
            Detalles = new List<DetalleCompra>();
        }





    }
}
