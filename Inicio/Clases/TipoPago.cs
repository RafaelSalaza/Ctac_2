using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    internal class TipoPago
    {
        private int id_tipo_pago;
        private string nombre;

        public int Id_tipo_pago { get => id_tipo_pago; set => id_tipo_pago = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
