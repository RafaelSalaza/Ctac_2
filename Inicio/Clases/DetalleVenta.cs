using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    internal class DetalleVenta
    {


        public int IdDetalleVenta { get; set; } 
        public int IdVenta { get; set; }
        public int Cantidad { get; set; }

        public int IdProducto { get; set; }
        
        public decimal Precio { get; set; }
        public decimal Subtotal { get; set; }










    }
}
