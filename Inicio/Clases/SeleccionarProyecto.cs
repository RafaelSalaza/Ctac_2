
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
    public partial class SeleccionarProyecto : Form
    {
        internal Proyecto seleccionarProyecto { get; private set; }
        private ProyectoDao proyectoDAO;
        public SeleccionarProyecto()
        {
            InitializeComponent();

            var conexion = new Conexion();
            proyectoDAO = new ProyectoDao(conexion);

            dataGridView1.AutoGenerateColumns = false;
            InitializeDataGridViewColumns();

            CargarProyectos();

        }
        private void InitializeDataGridViewColumns()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Nombre", HeaderText = "Nombre" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Descripcion", HeaderText = "Descripción" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "NombreDireccion", HeaderText = "Dirección" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "NombreCliente", HeaderText = "Cliente" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "NombreCategoria", HeaderText = "Categoría" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Precio_proyecto", HeaderText = "Precio Proyecto" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "NombreTipoPago", HeaderText = "Tipo de Pago" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Financiado", HeaderText = "Financiado" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Pagado", HeaderText = "Pagado" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "NombreEstadoProyecto", HeaderText = "Estado del Proyecto" });
        }

        private void CargarProyectos()
        {
            try
            {
                var proyectos = proyectoDAO.ObtenerProyectosCreados();
                dataGridView1.DataSource = proyectos; // Asignar lista de vehículos al DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proyectos: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                seleccionarProyecto = (Proyecto)dataGridView1.SelectedRows[0].DataBoundItem; // Establecer el vehículo seleccionado
                this.DialogResult = DialogResult.OK; // Cerrar el formulario con OK
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un vehículo.");
            }
        }
    }
}
