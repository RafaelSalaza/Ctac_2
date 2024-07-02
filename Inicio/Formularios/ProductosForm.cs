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
    public partial class ProductosForm : Form
    {

        Conexion con = new Conexion();
        private int idProductoSeleccionado;

        ProductoDao productoDao;
        public ProductosForm()
        {
            InitializeComponent();

            productoDao = new ProductoDao(con);
            cargarSucursales();
            CargarCategorias();

        }






        private void botonactualizar_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtnombre.Text;
            string descripcion = txtdescrip.Text;
            decimal precioVenta;

            if (decimal.TryParse(txtprecioventa.Text, out precioVenta))
            {
                bool exito = productoDao.ActualizarProducto(idProductoSeleccionado, nombreProducto, descripcion, precioVenta);

                if (exito)
                {
                    MessageBox.Show("Producto actualizado exitosamente.");
                    CargarProductos(); // Recargar productos
                }
                else
                {
                    MessageBox.Show("Error al actualizar el producto.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un precio de venta válido.");
            }
        }


        private void cargarSucursales()
        {
            CompraDao compraDao = new CompraDao(con);
            DataTable sucursales = compraDao.CargarSucursales();
            comboSucursales.DataSource = sucursales;
            comboSucursales.DisplayMember = "nombre_sucursal";
            comboSucursales.ValueMember = "id_sucursal";






        }



        private void CargarProductos()
        {
            if (comboSucursales.SelectedValue != null && combocategorias.SelectedValue != null)
            {
                int idSucursal = (int)comboSucursales.SelectedValue;
                int idCategoria = (int)combocategorias.SelectedValue;

                DataTable productos = productoDao.ObtenerProductosPorSucursalYCategoria(idSucursal, idCategoria);
                if (productos != null && productos.Rows.Count > 0)
                {
                    tablaProductos.DataSource = productos;
                }
                else
                {
                    MessageBox.Show("No se encontraron productos para la sucursal y categoría seleccionadas.");
                    tablaProductos.DataSource = null; // Limpiar la tabla si no hay resultados
                }
            }
            else
            {
                tablaProductos.DataSource = null; // Limpiar la tabla si no hay selección
            }
        }

        private void comboSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void combocategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
           
                string filtro = txtBuscar.Text;
                (tablaProductos.DataSource as DataTable).DefaultView.RowFilter = string.Format("nombre_producto LIKE '%{0}%'", filtro);
            
        }

        private void tablaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tablaProductos.Rows[e.RowIndex];

                txtnombre.Text = row.Cells["nombre_producto"].Value.ToString();
                txtdescrip.Text = row.Cells["descripcion"].Value.ToString();
                txtprecioventa.Text = row.Cells["precio_venta"].Value.ToString();
                idProductoSeleccionado = (int)row.Cells["id_producto"].Value; // Oculto para identificar el producto
            }
        }

    



        private void CargarCategorias()
        {
            DataTable categorias = productoDao.CargarCategorias(); // O el método correspondiente en tu DAO
            combocategorias.DataSource = categorias;
            combocategorias.DisplayMember = "nombre_categoria";
            combocategorias.ValueMember = "id_categoria_producto";
        }





    }

}
