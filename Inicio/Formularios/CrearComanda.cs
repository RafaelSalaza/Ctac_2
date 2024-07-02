
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
    public partial class CrearComanda : Form
    {

        private ComandaDao comandaDao;
        private Vehiculo vehiculoSeleccionado;

        public int IdUsuario { get; set; }


        public CrearComanda()
        {
            InitializeComponent();
            var conexion = new Conexion();
            comandaDao = new ComandaDao(conexion);

            CargarProyecto();        }

        private void CargarProyecto()
        {
            try
            {
                var proyectos = comandaDao.GetProyectos();

                cmbIdProyecto.DataSource = proyectos;
                cmbIdProyecto.DisplayMember = "Nombre";
                cmbIdProyecto.ValueMember = "Idproyecto";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proyectos del combo: " + ex.Message);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CrearComanda_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (vehiculoSeleccionado == null)
                {
                    MessageBox.Show("Por favor, selecciona un vehículo.");
                    return;
                }

                // Validar y recopilar datos del formulario
                string nombre = txtNombre.Text;
                int idVehiculo = vehiculoSeleccionado.Id_vehiculo;
                int idProyecto = (int)cmbIdProyecto.SelectedValue;

                // Crear una nueva instancia de Comanda
                Comanda nuevaComanda = new Comanda
                {
                    Nombre = nombre,
                    Id_vehiculo = idVehiculo,
                    Id_proyecto = idProyecto
                };

                // Llamar al método para agregar la comanda
                comandaDao.AgregarComanda(nuevaComanda);

                MessageBox.Show("Comanda agregada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la comanda: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SeleccionarVehiculo seleccionarVehiculoForm = new SeleccionarVehiculo())
            {
                if (seleccionarVehiculoForm.ShowDialog() == DialogResult.OK)
                {
                    vehiculoSeleccionado = seleccionarVehiculoForm.VehiculoSeleccionado;
                    txtVehiculo.Text = vehiculoSeleccionado.Placa; // Muestra alguna información del vehículo seleccionado
                }
            }
        }
    }
}
