using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    internal class Cuota
    {
        private int id_cuota;
        private int id_financiacion;
        private DateTime fecha_vencimiento;
        private decimal valor_cuota;
        private decimal interes_mora;
        private Boolean estado_financiado;
        private int cuota_numero;
        private decimal total_a_pagar;
        private string nombre_proyecto;

        public int Id_cuota { get => id_cuota; set => id_cuota = value; }
        public int Id_financiacion { get => id_financiacion; set => id_financiacion = value; }
        public DateTime Fecha_vencimiento { get => fecha_vencimiento; set => fecha_vencimiento = value; }
        public decimal Valor_cuota { get => valor_cuota; set => valor_cuota = value; }
        public decimal Interes_mora { get => interes_mora; set => interes_mora = value; }
        public bool Estado_financiado { get => estado_financiado; set => estado_financiado = value; }
        public int Cuota_numero { get => cuota_numero; set => cuota_numero = value; }
        public decimal Total_a_pagar { get => total_a_pagar; set => total_a_pagar = value; }
        public string Nombre_proyecto { get => nombre_proyecto; set => nombre_proyecto = value; }
    }
}
