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
    public partial class HistorialCompras : Form
    {
        Conexion con = new Conexion();

        CompraDao compraDao;


        public HistorialCompras()
        {
            InitializeComponent();

            compraDao = new CompraDao(con);

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
                DataTable historialCompras;

                if (radiofiltro.Checked && comboUsuarios.SelectedValue != null)
                {
                    int idUsuario = (int)comboUsuarios.SelectedValue;
                    historialCompras = compraDao.ConsultarHistorialCompras(idSucursal, fechaInicio, fechaFin, idUsuario);
                }
                else
                {
                    historialCompras = compraDao.ConsultarHistorialCompras(idSucursal, fechaInicio, fechaFin);
                }

                dataGridHistorialCompras.DataSource = historialCompras;
                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar el historial de compras: {ex.Message}");
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
            dataGridHistorialCompras.Columns["id_compra"].HeaderText = "ID Compra";
            dataGridHistorialCompras.Columns["nombre_proveedor"].HeaderText = "Proveedor";
            dataGridHistorialCompras.Columns["fecha_compra"].HeaderText = "Fecha";
            dataGridHistorialCompras.Columns["total"].HeaderText = "Total";
            dataGridHistorialCompras.Columns["nombre_completo_empleado"].HeaderText = "Nombre empleado";
            dataGridHistorialCompras.Columns["nombre_tipo_pago"].HeaderText = "Tipo de Pago";
            dataGridHistorialCompras.Columns["nombre_sucursal"].HeaderText = "Sucursal";

             //Ajustar el tamaño de las columnas
            dataGridHistorialCompras.Columns["id_compra"].Width = 30;
            dataGridHistorialCompras.Columns["nombre_proveedor"].Width = 150;
            dataGridHistorialCompras.Columns["fecha_compra"].Width = 100;
            dataGridHistorialCompras.Columns["total"].Width = 70;
            dataGridHistorialCompras.Columns["nombre_completo_empleado"].Width = 200;
            dataGridHistorialCompras.Columns["nombre_tipo_pago"].Width = 150;
            dataGridHistorialCompras.Columns["nombre_sucursal"].Width = 150;

            // Ajustar el modo de ajuste de tamaño de las columnas
            dataGridHistorialCompras.Columns["id_compra"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
           dataGridHistorialCompras.Columns["nombre_proveedor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridHistorialCompras.Columns["fecha_compra"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridHistorialCompras.Columns["total"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridHistorialCompras.Columns["nombre_completo_empleado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridHistorialCompras.Columns["nombre_tipo_pago"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridHistorialCompras.Columns["nombre_sucursal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Opcional: Ajustar el modo de ajuste de tamaño de todas las columnas al contenido
            dataGridHistorialCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 

            
        }


        private void LimpiarFormulario()
        {
            // Limpiar DataGridView
            dataGridHistorialCompras.DataSource = null;

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
