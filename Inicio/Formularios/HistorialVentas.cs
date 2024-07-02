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
    public partial class HistorialVentas : Form
    {

        Conexion con = new Conexion();

        CompraDao compraDao;
        VentaDao ventaDao;



        public HistorialVentas()
        {
            InitializeComponent();
            compraDao = new CompraDao(con);
            ventaDao = new VentaDao(con);


            CargarSucursales();

            // Configurar los eventos
            comboSucursales.SelectedIndexChanged += comboSucursales_SelectedIndexChanged;
            botonConsultar.Click += botonConsultar_Click;
        }

        private void botonConsultar_Click(object sender, EventArgs e)
        {

            try
            {
                int idSucursal = (int)comboSucursales.SelectedValue;
                DateTime fechaInicio = dateTimePickerInicio.Value.Date;
                DateTime fechaFin = dateTimePickerFin.Value.Date;
                DataTable historialVentas;

                if (radiofiltro.Checked && comboUsuarios.SelectedValue != null)
                {
                    int idUsuario = (int)comboUsuarios.SelectedValue;
                    historialVentas =ventaDao.ConsultarHistorialVentas(idSucursal, fechaInicio, fechaFin, idUsuario);
                }
                else
                {
                    historialVentas = ventaDao.ConsultarHistorialVentas(idSucursal, fechaInicio, fechaFin);
                }

                dataGridHistorialVentas.DataSource = historialVentas;
                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar el historial de ventas: {ex.Message}");
            }


        }

        private void CargarSucursales()
        {
            DataTable sucursales = compraDao.CargarSucursales();
            comboSucursales.DataSource = sucursales;
            comboSucursales.DisplayMember = "nombre_sucursal";
            comboSucursales.ValueMember = "id_sucursal";
        }

        private void comboSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSucursales.SelectedValue != null)
            {
                int idSucursal = (int)comboSucursales.SelectedValue;
                DataTable usuarios = compraDao.CargarUsuariosPorSucursal(idSucursal);
                comboUsuarios.DataSource = usuarios;
                comboUsuarios.DisplayMember = "nombre_usuario";
                comboUsuarios.ValueMember = "id_usuario";
            }
        }


        private void ConfigurarDataGridView()
        {
            // Configurar los encabezados de las columnas
            dataGridHistorialVentas.Columns["id_venta"].HeaderText = "ID";
            dataGridHistorialVentas.Columns["nombre_completo_empleado"].HeaderText = "Empleado";
            dataGridHistorialVentas.Columns["fecha_venta"].HeaderText = "Fecha";
            dataGridHistorialVentas.Columns["nombre_completo_cliente"].HeaderText = "Cliente";
            dataGridHistorialVentas.Columns["monto_envio"].HeaderText = "Envío";
            dataGridHistorialVentas.Columns["monto_total"].HeaderText = "Total";
            dataGridHistorialVentas.Columns["nombre_sucursal"].HeaderText = "Sucursal";

            // Ajustar el tamaño de las columnas
            dataGridHistorialVentas.Columns["id_venta"].Width = 30;
            dataGridHistorialVentas.Columns["nombre_completo_empleado"].Width = 300;
            dataGridHistorialVentas.Columns["fecha_venta"].Width = 150;
            dataGridHistorialVentas.Columns["nombre_completo_cliente"].Width = 300;
            dataGridHistorialVentas.Columns["monto_envio"].Width = 100;
            dataGridHistorialVentas.Columns["monto_total"].Width = 100;
            dataGridHistorialVentas.Columns["nombre_sucursal"].Width = 300;

            // Ajustar el modo de ajuste de tamaño de las columnas
            dataGridHistorialVentas.Columns["id_venta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridHistorialVentas.Columns["nombre_completo_empleado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridHistorialVentas.Columns["fecha_venta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridHistorialVentas.Columns["nombre_completo_cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridHistorialVentas.Columns["monto_envio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridHistorialVentas.Columns["monto_total"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridHistorialVentas.Columns["nombre_sucursal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            // dataGridHistorialVentas.Columns["nombre_sucursal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Puedes ajustar este si es necesario

            // Opcional: Ajustar el modo de ajuste de tamaño de todas las columnas al contenido
            dataGridHistorialVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        

        }

        private void comboSucursales_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }


        private void LimpiarFormulario()
        {
            // Limpiar DataGridView
            dataGridHistorialVentas.DataSource = null;

            // Restablecer los controles a sus valores por defecto
            comboSucursales.SelectedIndex = -1;
            comboUsuarios.DataSource = null;
            dateTimePickerInicio.Value = DateTime.Now;
            dateTimePickerFin.Value = DateTime.Now;
            radiofiltro.Checked = false;

            // Opcional: mostrar un mensaje de que el formulario ha sido limpiado
            //MessageBox.Show("El formulario ha sido limpiado.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
