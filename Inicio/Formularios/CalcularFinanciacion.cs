using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio.Formularios
{
    public partial class CalcularFinanciacion : Form
    {
        public CalcularFinanciacion()
        {
            InitializeComponent();
        }

        private void CalcularFinanciacion_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int anios = int.Parse(txtAnios.Text);

            int cuotas = anios * 12;

            decimal precio = decimal.Parse(txtPrecio.Text);
            decimal interes = decimal.Parse(txtInteres.Text);

            decimal interesTotal = precio * interes * anios;

            decimal montoFinanciado = precio+interesTotal;

            decimal ValorCuota = montoFinanciado/cuotas;

            txtValorCuota.Text = ValorCuota.ToString("F2");
            txtMonto.Text = montoFinanciado.ToString("F2");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
