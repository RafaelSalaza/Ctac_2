
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
    public partial class VerFinanciaciones : Form
    {
        private FinanciacionDao financiacionDao;

        public VerFinanciaciones()
        {
            
            InitializeComponent();

            var conexion = new Conexion();
            financiacionDao = new FinanciacionDao(conexion);

            dataGridView1.AutoGenerateColumns = false;
            InitializeDataGridViewColumns();

            CargarFinancaciones();


        }
        private void InitializeDataGridViewColumns()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "NombreProyecto", HeaderText = " Nombre del proyecto" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Fecha_inicio", HeaderText = "Fecha de inicio" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Fecha_fin", HeaderText = "Fecha final" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Numero_cuotas", HeaderText = "Numero de cuotas" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Valor_cuotas", HeaderText = "Valor por cuota" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Tasa_interes_anual", HeaderText = "Tasa de interes anual" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Monto_financiado", HeaderText = "Monto Financiado" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Saldo_pendiente", HeaderText = "Saldo pendiente" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "NombreEstadoFinanciacion", HeaderText = "Estado de la financiacion" });
        }
        private void VerFinanciaciones_Load(object sender, EventArgs e)
        {

        }

        private void CargarFinancaciones()
        {
            try
            {
                var finaciaciones = financiacionDao.ObtenerFinanciacionesCreadas();
                dataGridView1.DataSource = finaciaciones;
                dataGridView1.AutoGenerateColumns = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proyectos: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
