using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class EnvioForm : Form
      {
        private EnvioDao envioDao;
        public int IdSucursal { get; set; }
       
        Conexion con = new Conexion();

        public EnvioForm()
        {
            InitializeComponent();
            envioDao = new EnvioDao(con);
             
            

        }

        private void EnvioForm_Load(object sender, EventArgs e)
        {
            CargarEnviosNoEntregados();
            CargarConductores();
            CargarVehiculos();
        }

        private void botonMarcar_Click(object sender, EventArgs e)
        {
            if (dataGridEnvios.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridEnvios.SelectedRows[0];
                int idEnvio = (int)row.Cells["id_envio"].Value;
                int idEmpleado = (int)comboBoxConductores.SelectedValue;
                int idVehiculo = (int)comboBoxVehiculo.SelectedValue;

                if (envioDao.ActualizarEnvio(idEnvio, idEmpleado, idVehiculo))
                {
                    MessageBox.Show("Envío marcado como entregado.");
                    CargarEnviosNoEntregados(); // Recargar la lista de envíos no entregados
                }
                else
                {
                    MessageBox.Show("Error al actualizar el envío.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un envío de la lista.");
            }
        }


        private void CargarEnviosNoEntregados()
        {
            DataTable envios = envioDao.CargarEnviosNoEntregados(IdSucursal);
            dataGridEnvios.DataSource = envios;
        }

        private void CargarConductores()
        {
            DataTable conductores = envioDao.CargarConductores(IdSucursal);
            comboBoxConductores.DisplayMember = "nombre_completo";
            comboBoxConductores.ValueMember = "id_empleado";
            comboBoxConductores.DataSource = conductores;
        }

        private void CargarVehiculos()
        {
            DataTable vehiculos = envioDao.CargarVehiculos(IdSucursal);
            comboBoxVehiculo.DisplayMember = "descripcion_vehiculo";
            comboBoxVehiculo.ValueMember = "id_vehiculo";
            comboBoxVehiculo.DataSource = vehiculos;
        }

        private void MostrarEntregados_Click(object sender, EventArgs e)
        {

            DataTable enviosEntregados = envioDao.CargarEnviosEntregados(IdSucursal);
            dataGridEnvios.DataSource = enviosEntregados;
        }

        private void mostrarPendientes_Click(object sender, EventArgs e)
        {
            CargarEnviosNoEntregados();
        }
    }
}
