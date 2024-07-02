
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
    public partial class CrearFinanciacion : Form
    {

        private FinanciacionDao financiacionDao;
        private Proyecto seleccionarProyecto;
        private List<Financiacion> financiaciones;


        public CrearFinanciacion()
        {
            InitializeComponent();
            var conexion = new Conexion();
            financiacionDao = new FinanciacionDao(conexion);
            financiaciones = new List<Financiacion>();
            ConfigurarDataGridView();
            Financiaciones();
        }


        private void btnSeleccionarProyecto_Click(object sender, EventArgs e)
        {
            using (SeleccionarProyecto seleccionarProyectoForm = new SeleccionarProyecto())
            {
                if (seleccionarProyectoForm.ShowDialog() == DialogResult.OK)
                {
                    seleccionarProyecto = seleccionarProyectoForm.seleccionarProyecto;
                    txtProyecto.Text = seleccionarProyecto.Nombre; // Muestra el nombre del proyecto seleccionado
                }
            }
        }

        private void btnCalcularFinanciacion_Click(object sender, EventArgs e)
        {
            if (seleccionarProyecto != null)
            {
                try
                {
                    financiacionDao.CalcularFinanciacion(seleccionarProyecto.Idproyecto, Convert.ToInt32(txtAnios.Text), Convert.ToDecimal(txtInteres.Text));
                    MessageBox.Show("La financiación se ha calculado y registrado correctamente.");
                    CargarFinanciaciones(seleccionarProyecto.Idproyecto); // Volver a cargar financiaciones después de calcular
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al calcular la financiación: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un proyecto antes de calcular la financiación.");
            }
        }

        private void ConfigurarDataGridView()
        {
            dataGridViewFinanciaciones.AutoGenerateColumns = false;
            dataGridViewFinanciaciones.Columns.Clear();

            //dataGridViewFinanciaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id_financiacion", HeaderText = "ID" });
            dataGridViewFinanciaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Fecha_inicio", HeaderText = "Fecha Inicio" });
            dataGridViewFinanciaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Fecha_fin", HeaderText = "Fecha Fin" });
            dataGridViewFinanciaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Numero_cuotas", HeaderText = "Número de Cuotas" });
            dataGridViewFinanciaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Valor_cuotas", HeaderText = "Valor de Cuotas" });
            dataGridViewFinanciaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Tasa_interes_anual", HeaderText = "Tasa de Interés Anual" });
            dataGridViewFinanciaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Monto_financiado", HeaderText = "Monto Financiado" });
            dataGridViewFinanciaciones.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Saldo_pendiente", HeaderText = "Saldo Pendiente" });

            dataGridViewFinanciaciones.DataSource = financiaciones;
        }

        private void CargarFinanciaciones(int idProyecto)
        {
            try
            {
                financiaciones = financiacionDao.ObtenerFinanciaciones(idProyecto);
                dataGridViewFinanciaciones.DataSource = null;
                dataGridViewFinanciaciones.DataSource = financiaciones;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las financiaciones: " + ex.Message);
            }
        }

        private void Financiaciones()
        {
            try
            {
                var financiaion = financiacionDao.GetFinanciaciones();
                dataGridViewFinanciaciones.DataSource = financiaion; // Asignar lista de vehículos al DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las financiaciones: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
