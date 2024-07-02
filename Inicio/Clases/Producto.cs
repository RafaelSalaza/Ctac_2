using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    internal class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioVenta { get; set; } = 0;
        public decimal PrecioCompra { get; set; } = 0;
        public int Stock { get; set; } = 0;
        public int SucursalId { get; set; }
        public int IdCategoriaProducto { get; set; }
        public int IdMarca { get; set; }

        public Producto() { }

        public Producto(string nombreProducto, string descripcion, int sucursalId, int idCategoriaProducto, int idMarca)
        {
            NombreProducto = nombreProducto;
            Descripcion = descripcion;
            SucursalId = sucursalId;
            IdCategoriaProducto = idCategoriaProducto;
            IdMarca = idMarca;
        }





    }
}
