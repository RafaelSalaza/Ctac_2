
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
    public partial class PagarCuota : Form
    {

        private CuotaDao cuotaDao;
        private List<Cuota> cuotas;
        private Cuota cuotaSeleccionada;
        private ProyectoDao proyectoDao;
        private FinanciacionDao financiacionDao;
        public PagarCuota()
        {
            InitializeComponent();
            var conexion = new Conexion();
            financiacionDao = new FinanciacionDao(conexion);
            cuotaDao = new CuotaDao(conexion);
            proyectoDao = new ProyectoDao(conexion);

            InitializeDataGridViewColumns();
            cuotaDataGridView.AutoGenerateColumns = false;
            cuotaDataGridView.SelectionChanged += cuotaDataGridView_SelectionChanged;


            //cuotaDataGridView.SelectionChanged += new System.EventHandler(this.cuotaDataGridView_SelectionChanged);


        }

        private void InitializeDataGridViewColumns()
        {
            cuotaDataGridView.Columns.Clear();

            cuotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Fecha_vencimiento", HeaderText = "Fecha Vencimiento", DataPropertyName = "Fecha_vencimiento" });
            cuotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Valor_cuota", HeaderText = "Valor Cuota", DataPropertyName = "Valor_cuota" });
            cuotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Interes_mora", HeaderText = "Interés Mora", DataPropertyName = "Interes_mora" });
            cuotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Cuota_numero", HeaderText = "Número de Cuota", DataPropertyName = "Cuota_numero" });
            cuotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre_proyecto", HeaderText = "Nombre del Proyecto", DataPropertyName = "Nombre_proyecto" });
            cuotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn { Name = "Total_a_pagar", HeaderText = "Total a Pagar", DataPropertyName = "Total_a_pagar" });

        }

        private void CargarCuotas(int idFinanciacion)
        {
            try
            {
                var cuotas = cuotaDao.ObtenerCuotasPorFinanciacion(idFinanciacion);
                cuotaDataGridView.DataSource = cuotas;
                cuotaDataGridView.AutoGenerateColumns = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las cuotas: " + ex.Message);
            }
        }




        private void cuotaDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (cuotaDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = cuotaDataGridView.SelectedRows[0];
                cuotaSeleccionada = (Cuota)selectedRow.DataBoundItem;

                txtFechaVencimiento.Text = cuotaSeleccionada.Fecha_vencimiento.ToString("yyyy-MM-dd");
                txtCuotaNumero.Text = cuotaSeleccionada.Cuota_numero.ToString();
                txtValorCuota.Text = cuotaSeleccionada.Valor_cuota.ToString("F2");
                txtTotalAPagar.Text = cuotaSeleccionada.Total_a_pagar.ToString("F2");

                ValidarFechaVencimiento();
            }
        }


        private void ValidarFechaVencimiento()
        {
            DateTime fechaActual = DateTime.Now;
            DateTime fechaVencimiento = DateTime.Parse(txtFechaVencimiento.Text);

            if (fechaActual >= fechaVencimiento)
            {
                txtInteresMora.Text = "0.10";
                txtInteresMora.ReadOnly = true;
                MessageBox.Show("La fecha de pago es posterior a la fecha de vencimiento. Por favor, ingrese el interés de mora.");
                
            }
            else
            {
                txtInteresMora.Text = "0.00";
                txtInteresMora.ReadOnly = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cuotaSeleccionada != null)
            {
                DateTime fechaActual = DateTime.Now;

                try
                {
                    // Llamar al método para registrar el pago de la cuota usando el procedimiento almacenado
                    cuotaDao.RegistrarPagoCuota(cuotaSeleccionada.Id_cuota, fechaActual);

                    MessageBox.Show("Pago registrado exitosamente.");

                    // Recargar las cuotas
                    CargarCuotas(cuotaSeleccionada.Id_financiacion);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el pago: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una cuota para pagar.");
            }
        }

        private void PagarCuota_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int cuotasAPagar = 1;
                decimal valorCuota = decimal.Parse(txtValorCuota.Text);
                decimal interesMora = decimal.Parse(txtInteresMora.Text);
                decimal totalCuotaInteres = valorCuota * interesMora;

                decimal totalAPagar = (valorCuota * cuotasAPagar) + totalCuotaInteres;

                // Actualizar los campos de interés mora y total a pagar en la cuota seleccionada
                cuotaSeleccionada.Interes_mora = interesMora;
                cuotaSeleccionada.Total_a_pagar = totalAPagar;

                // Reflejar los cambios en la base de datos
                cuotaDao.ActualizarCuota(cuotaSeleccionada);

                txtDineroAPagar.Text = totalAPagar.ToString("F2");

                // No actualizar saldo pendiente aquí, solo realizar cálculo

                CargarCuotas(cuotaSeleccionada.Id_financiacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el pago: " + ex.Message);
            }
        }


        private void txtInteresMora_TextChanged(object sender, EventArgs e)
        {
            if (!txtInteresMora.ReadOnly)
            {
                button2_Click(sender, e);
            }
        }

        private void btnBuscarProyecto_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreProyecto = txtBuscar.Text.ToLower();
                if (string.IsNullOrEmpty(nombreProyecto))
                {
                    MessageBox.Show("Por favor ingrese un nombre de proyecto para buscar.");
                    return;
                }

                List<Proyecto> proyectos = proyectoDao.ObtenerProyectosPorNombres(nombreProyecto);

                if (proyectos != null && proyectos.Count > 0)
                {
                    List<Cuota> todasCuotas = new List<Cuota>();

                    foreach (var proyecto in proyectos)
                    {
                        int idProyecto = proyecto.Idproyecto;
                        List<Financiacion> financiaciones = financiacionDao.ObtenerFinanciaciones(idProyecto);

                        if (financiaciones != null && financiaciones.Count > 0)
                        {
                            foreach (var financiacion in financiaciones)
                            {
                                List<Cuota> cuotas = cuotaDao.ObtenerCuotasPorFinanciacion(financiacion.Id_financiacion);
                                if (cuotas != null)
                                {
                                    todasCuotas.AddRange(cuotas);
                                }
                            }
                        }
                    }

                    if (todasCuotas.Count > 0)
                    {
                        cuotaDataGridView.DataSource = todasCuotas;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron cuotas para los proyectos seleccionados.");
                        cuotaDataGridView.DataSource = null;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron proyectos con ese nombre.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar proyectos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
