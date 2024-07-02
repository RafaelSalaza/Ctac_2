    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Inicio
    {
        internal class Proyecto
        {
            private int idproyecto;
            private string nombre;
            private string descripcion;
            private int id_direccion;
            private int id_empleado;
            private int id_categoria_proyecto;
            private int id_cliente;
            private decimal precio_proyecto;
            private int id_tipo_pago;
            private bool financiado;
            private bool pagado;
            private int id_estado_proyecto;

            public int Idproyecto { get => idproyecto; set => idproyecto = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Descripcion { get => descripcion; set => descripcion = value; }
            public int Id_direccion { get => id_direccion; set => id_direccion = value; }
            public int Id_empleado { get => id_empleado; set => id_empleado = value; }
            public int Id_categoria_proyecto { get => id_categoria_proyecto; set => id_categoria_proyecto = value; }
            public int Id_cliente { get => id_cliente; set => id_cliente = value; }
            public decimal Precio_proyecto { get => precio_proyecto; set => precio_proyecto = value; }
            public int Id_tipo_pago { get => id_tipo_pago; set => id_tipo_pago = value; }
            public bool Financiado { get => financiado; set => financiado = value; }
            public bool Pagado { get => pagado; set => pagado = value; }
            public int Id_estado_proyecto { get => id_estado_proyecto; set => id_estado_proyecto = value; }

            public string NombreCliente { get; set; }
            public string NombreCategoria { get; set; }
            public string NombreTipoPago { get; set; }
            public string NombreDireccion { get; set; }
            public string NombreEmpleado { get; set; }
            public string NombreEstadoProyecto { get; set; }
        }
    }
