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
    public partial class AgregarVehiculo : Form
    {
        private VehiculoDAO vehiculoDAO;

        public AgregarVehiculo()
        {
            InitializeComponent();

            var conexion = new Conexion();
            vehiculoDAO = new VehiculoDAO(conexion); ;

            CargarCategoriasVehiculo();
            CargarSucursales();
            CargarVehiculos();
            dgvVehiculo.AllowUserToAddRows = false;
        }

        private void CargarCategoriasVehiculo()
        {
            try
            {
                var categorias = vehiculoDAO.ObtenerCategoriasVehiculo();
                cmbCategoria.DataSource = categorias;
                cmbCategoria.DisplayMember = "tipo";
                cmbCategoria.ValueMember = "id_categoria_vehiculo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías de vehículos: " + ex.Message);
            }
        }

        private void CargarSucursales()
        {
            try
            {
                var sucursales = vehiculoDAO.ObtenerSucursales();
                cmbSucursal.DataSource = sucursales;
                cmbSucursal.DisplayMember = "nombre_sucursal";
                cmbSucursal.ValueMember = "id_sucursal";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las sucursales: " + ex.Message);
            }
        }

        private void CargarVehiculos()
        {
            try
            {
                DataTable vehiculos = vehiculoDAO.ObtenerVehiculos();
                dgvVehiculo.DataSource = vehiculos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los vehículos: " + ex.Message);
            }
        }
        private void AgregarVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idCategoriaVehiculo = (int)cmbCategoria.SelectedValue;
            string placa = txtPlaca.Text;
            string descripcion = txtDescripcion.Text;
            string anio = txtAnio.Text;
            int idSucursal = (int)cmbSucursal.SelectedValue;

            try
            {
                vehiculoDAO.CrearVehiculo(idCategoriaVehiculo, placa, descripcion, anio, idSucursal);
                MessageBox.Show("Vehículo agregado exitosamente.");
                CargarVehiculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el vehículo: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvVehiculo.CurrentRow != null) 
            {
                DataGridViewRow row = dgvVehiculo.CurrentRow;
                int idVehiculo = Convert.ToInt32(row.Cells["id_vehiculo"].Value);
                int idCategoriaVehiculo = (int)cmbCategoria.SelectedValue;
                string placa = txtPlaca.Text;
                string descripcion = txtDescripcion.Text;
                string anio = txtAnio.Text;
                int idSucursal = (int)cmbSucursal.SelectedValue;

                try
                {
                    vehiculoDAO.ActualizarVehiculo(idVehiculo, idCategoriaVehiculo, placa, descripcion, anio, idSucursal);
                    MessageBox.Show("Vehículo actualizado exitosamente.");
                    CargarVehiculos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el vehículo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un vehículo para editar.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvVehiculo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DataGridViewRow row = dgvVehiculo.Rows[e.RowIndex];

                int idCategoriaVehiculo = Convert.ToInt32(row.Cells["id_categoria_vehiculo"].Value);
                string placa = row.Cells["placa"].Value.ToString();
                string descripcion = row.Cells["descripcion"].Value.ToString();
                string anio = row.Cells["anio"].Value.ToString();
                int idSucursal = Convert.ToInt32(row.Cells["id_sucursal"].Value);

                cmbCategoria.SelectedValue = idCategoriaVehiculo;
                txtPlaca.Text = placa;
                txtDescripcion.Text = descripcion;
                txtAnio.Text = anio;
                cmbSucursal.SelectedValue = idSucursal;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
