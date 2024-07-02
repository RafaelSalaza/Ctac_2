using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    internal class Financiacion
    {
        private int id_financiacion;
        private int id_proyecto;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;
        private int numero_cuotas;
        private decimal valor_cuotas;
        private decimal tasa_interes_anual;
        private decimal monto_financiado;
        private decimal saldo_pendiente;
        private int id_estado_financiacion;

        public int Id_financiacion { get => id_financiacion; set => id_financiacion = value; }
        public int Id_proyecto { get => id_proyecto; set => id_proyecto = value; }
        public DateTime Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public DateTime Fecha_fin { get => fecha_fin; set => fecha_fin = value; }
        public int Numero_cuotas { get => numero_cuotas; set => numero_cuotas = value; }
        public decimal Valor_cuotas { get => valor_cuotas; set => valor_cuotas = value; }
        public decimal Tasa_interes_anual { get => tasa_interes_anual; set => tasa_interes_anual = value; }
        public decimal Monto_financiado { get => monto_financiado; set => monto_financiado = value; }
        public decimal Saldo_pendiente { get => saldo_pendiente; set => saldo_pendiente = value; }
        public int Id_estado_financiacion { get => id_estado_financiacion; set => id_estado_financiacion = value; }

        public string NombreEstadoFinanciacion { get; set; }
        public string NombreProyecto { get; set; }
    }
}
