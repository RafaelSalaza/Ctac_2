
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
    public partial class VerComanda : Form
    {
        private ComandaDao comandaDao;
        public VerComanda()
        {
            InitializeComponent();
            var conexion = new Conexion();
            comandaDao = new ComandaDao(conexion);

            dataGridView1.AutoGenerateColumns = false;
            InitializeDataGridViewColumns();

            GetProyectos();
            Getvehiculos();
            CargarComandas();

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void InitializeDataGridViewColumns()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Nombre", HeaderText = "Nombre" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "PlacaVehiculo", HeaderText = "Placa del vehiculo" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "NombreProyecto", HeaderText = "Nombre del proyecto" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "DescripcionVehiculo", HeaderText = "Descripcion del vehiculo" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "AnioVehiculo", HeaderText = "Año del vehiculo" });
        }

        private void GetProyectos()
        {
            var proyectos = comandaDao.GetProyectos();
            cmbIdProyecto.DataSource = proyectos;
            cmbIdProyecto.DisplayMember = "Nombre";
            cmbIdProyecto.ValueMember = "Idproyecto";
        }

        private void Getvehiculos()
        {
            var vehiculos = comandaDao.GetVehiculosConTipo();
            cmbIdVehiculo.DataSource = vehiculos;
            cmbIdVehiculo.DisplayMember = "Descripcion";
            cmbIdVehiculo.ValueMember = "Id_vehiculo";
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarCamposDesdeSeleccion();
        }

        private void ActualizarCamposDesdeSeleccion()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Comanda comandaSeleccionada = (Comanda)selectedRow.DataBoundItem;

                // Mostrar los datos seleccionados en los controles de edición
                txtNombre.Text = comandaSeleccionada.Nombre;

                // Obtener el vehículo seleccionado por su ID
                Vehiculo vehiculo = comandaDao.GetVehiculoPorId(comandaSeleccionada.Id_vehiculo);
                if (vehiculo != null)
                {
                    cmbIdVehiculo.SelectedValue = vehiculo.Id_vehiculo;
                }

                // Obtener el proyecto seleccionado por su ID
                Proyecto proyecto = comandaDao.GetProyectoPorId(comandaSeleccionada.Id_proyecto);
                if (proyecto != null)
                {
                    cmbIdProyecto.SelectedValue = proyecto.Idproyecto;
                    // Actualiza otros campos relacionados con el proyecto si es necesario
                }
            }
        }

        private void CargarComandas()
        {
            try
            {
                var comandas = comandaDao.ObtenerTodasLasComandas();
                dataGridView1.DataSource = comandas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las comandas: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    Comanda comandaSeleccionada = (Comanda)selectedRow.DataBoundItem;

                    // Actualizar los campos modificados en el objeto Comanda
                    comandaSeleccionada.Nombre = txtNombre.Text;
                    comandaSeleccionada.Id_vehiculo = (int)cmbIdVehiculo.SelectedValue;
                    comandaSeleccionada.Id_proyecto = (int)cmbIdProyecto.SelectedValue;

                    // Llamar al método para modificar la comanda en la base de datos
                    comandaDao.ModificarComanda(comandaSeleccionada);

                    // Recargar las comandas para actualizar el DataGridView
                    CargarComandas();

                    MessageBox.Show("Comanda modificada exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar la comanda: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una comanda para modificar.");
            }
        }
    }
}
