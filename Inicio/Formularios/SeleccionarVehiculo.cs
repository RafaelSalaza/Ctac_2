
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
    public partial class SeleccionarVehiculo : Form
    {

        internal Vehiculo VehiculoSeleccionado { get; private set; }
        private ComandaDao comandaDao;


        public SeleccionarVehiculo()
        {
            InitializeComponent();
            var conexion = new Conexion();
            comandaDao = new ComandaDao(conexion);
            CargarVehiculos();
        }



        private void CargarVehiculos()
        {
            try
            {
                var vehiculos = comandaDao.GetVehiculosConTipo();
                dataGridViewVehiculos.DataSource = vehiculos; // Asignar lista de vehículos al DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los vehículos: " + ex.Message);
            }
        }

        private void SeleccionarVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridViewVehiculos.SelectedRows.Count > 0)
            {
                VehiculoSeleccionado = (Vehiculo)dataGridViewVehiculos.SelectedRows[0].DataBoundItem; // Establecer el vehículo seleccionado
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
