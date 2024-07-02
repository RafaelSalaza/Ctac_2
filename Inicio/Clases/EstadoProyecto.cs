using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    internal class EstadoProyecto
    {
        private int id_estado_proyecto;
        private string nombre;

        public int Id_estado_proyecto { get => id_estado_proyecto; set => id_estado_proyecto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
