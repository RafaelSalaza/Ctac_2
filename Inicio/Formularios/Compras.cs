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
    public partial class Compras : Form
    {
        Conexion con = new Conexion();
        public int IdSucursal { get; set; }
        public int IdUsuario { get; set; }

        CompraDao compraDao;


        private List<DetalleCompra> detallesCompra = new List<DetalleCompra>();
        private int selectedIdProducto;
        private string selectedNombreProducto;

        public Compras()
        {
            InitializeComponent();

            compraDao = new CompraDao(con);
            CargarCategorias();
            CargarProveedores();
            CargarTipopago();







            // Configurar DataGridView de detalles de compra
            tablaDetallescompra.AutoGenerateColumns = false;
            tablaDetallescompra.Columns.Add("Producto", "Producto");
            tablaDetallescompra.Columns.Add("Cantidad", "Cantidad");
            tablaDetallescompra.Columns.Add("Precio", "Precio");
            tablaDetallescompra.Columns.Add("Subtotal", "Subtotal");


            /*da.Columns["id_producto"].Visible = false; // Ocultar la columna id_producto si no quieres mostrarla
            dataGridViewProductos.Columns["nombre_producto"].HeaderText = "Nombre del Producto";
            dataGridViewProductos.Columns["stock"].HeaderText = "Stock";
            dataGridViewProductos.Columns["marca"].HeaderText = "Marca";*/



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if (selectedIdProducto != 0 && !string.IsNullOrEmpty(selectedNombreProducto))
            {
                int cantidad = (int)CantidadSpinner.Value;
                decimal precioCompra = decimal.Parse(txtPrecio.Text);
                decimal subtotal = cantidad * precioCompra;

                DetalleCompra detalle = new DetalleCompra
                {
                    IdProducto = selectedIdProducto,
                    Cantidad = cantidad,
                    PrecioCompra = precioCompra,
                    Subtotal = subtotal
                };

                detallesCompra.Add(detalle);

                // Agregar el detalle al DataGridView
                tablaDetallescompra.Rows.Add(selectedNombreProducto, cantidad, precioCompra, subtotal);
                ActualizarTotalGastado();
            }
        }


        private void CargarCategorias()
        {


            DataTable categorias = compraDao.CargarCategorias();
            comboCat.DataSource = categorias;
            comboCat.DisplayMember = "nombre_categoria";
            comboCat.ValueMember = "id_categoria_producto";
        }

        private void CargarProveedores()
        {
            DataTable provedores = compraDao.CargarProveedor();
            comboprov.DataSource = provedores;
            comboprov.DisplayMember = "nombre_proveedor";
            comboprov.ValueMember = "id_proveedor";


        }


        private void CargarTipopago()
        {
            DataTable pagos = compraDao.CargarTiposPago();
            comboTipoPago.DataSource = pagos;
            comboTipoPago.DisplayMember = "nombre";
            comboTipoPago.ValueMember = "id_tipo_pago";


        }


        private void CargarProductosPorCategoria(int idCategoria)
        {


            DataTable productos = compraDao.ObtenerProductosPorCategoria(idCategoria);

            tablaProductos.DataSource = productos;
        }

        private void comboCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCat.SelectedValue != null)
            {
                int idCategoria = (int)comboCat.SelectedValue;
                CargarProductosPorCategoria(idCategoria);
            }
        }

        private void tablaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tablaProductos.Rows[e.RowIndex];
                selectedIdProducto = (int)row.Cells["ID"].Value;
                selectedNombreProducto = row.Cells["PRODUCTO"].Value.ToString();
                int stock = (int)row.Cells["STOCK"].Value;

                // Mostrar detalles del producto seleccionado en etiquetas o campos de texto
                labelProducto.Text = selectedNombreProducto;
                CantidadSpinner.Value = 1;  // Valor por defecto
                txtPrecio.Text = "";  // Valor por defecto
            }

        }


        private void AgregarDetalleCompra(int idProducto, string nombreProducto)
        {
            int cantidad = (int)CantidadSpinner.Value;
            decimal precioCompra = decimal.Parse(txtPrecio.Text);
            decimal subtotal = cantidad * precioCompra;

            DetalleCompra detalle = new DetalleCompra
            {
                IdProducto = idProducto,
                Cantidad = cantidad,
                PrecioCompra = precioCompra,
                Subtotal = subtotal
            };

            detallesCompra.Add(detalle);

            // Agregar el detalle al DataGridView
            tablaDetallescompra.Rows.Add(nombreProducto, cantidad, precioCompra, subtotal);
            ActualizarTotalGastado();
        }


        private void pagar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProveedor = (int)comboprov.SelectedValue;
                int idUsuario = this.IdUsuario;
                int idTipoPago = (int)comboTipoPago.SelectedValue;

                Compra compra = new Compra
                {
                    IdProveedor = idProveedor,
                    IdUsuario = idUsuario,
                    IdTipoPago = idTipoPago,
                    Detalles = detallesCompra
                };

                if (compraDao.InsertarCompraConDetalles(compra))
                {
                    MessageBox.Show("Compra registrada exitosamente.");
                    limpiartodo();
                }
                else
                {
                    MessageBox.Show("Error al registrar la compra.");
                }
            }
            catch (Exception ex)
            {
                // Mostrar el mensaje de error en un MessageBox
                MessageBox.Show($"Error al registrar la compra: {ex.Message}");
            }

        }


        private void ActualizarTotalGastado()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in tablaDetallescompra.Rows)
            {
                if (row.Cells["subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["subtotal"].Value);
                }
            }

            labeltotal.Text = $"Total: {total:C2}"; // Mostrar el total en formato moneda
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpiar la tabla de detalles de compra
            tablaDetallescompra.Rows.Clear();

            // Limpiar la lista de detalles de compra
            detallesCompra.Clear();

            // Restablecer los campos de entrada a sus valores predeterminados
            labelProducto.Text = string.Empty;
            CantidadSpinner.Value = 0; // Valor por defecto
            txtPrecio.Text = ""; // Valor por defecto
            labeltotal.Text = "Total: 0.00"; // Restablecer el total gastado

            // Opcional: Restablecer otros controles si es necesario
            comboCat.SelectedIndex = -1; // Desseleccionar la categoría
            comboprov.SelectedIndex = -1; // Desseleccionar el proveedor
        }



        private void limpiartodo()
        {

            // Limpiar la tabla de detalles de compra
            tablaDetallescompra.Rows.Clear();

            // Limpiar la lista de detalles de compra
            detallesCompra.Clear();

            // Restablecer los campos de entrada a sus valores predeterminados
            labelProducto.Text = string.Empty;
            CantidadSpinner.Value = 0; // Valor por defecto
            txtPrecio.Text = ""; // Valor por defecto
            labeltotal.Text = "Total: 0.00"; // Restablecer el total gastado

            // Opcional: Restablecer otros controles si es necesario
            comboCat.SelectedIndex = -1; // Desseleccionar la categoría
            comboprov.SelectedIndex = -1; // Desseleccionar el proveedor


        }

        private void botonquitar_Click(object sender, EventArgs e)
        {
            if (tablaDetallescompra.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = tablaDetallescompra.SelectedRows[0];

                // Eliminar el detalle de la lista
                int rowIndex = selectedRow.Index;
                detallesCompra.RemoveAt(rowIndex);

                // Eliminar la fila del DataGridView
                tablaDetallescompra.Rows.RemoveAt(rowIndex);

                // Actualizar el total gastado
                ActualizarTotalGastado();
            }
            else
            {
                MessageBox.Show("Seleccione un detalle de compra para quitar.");
            }

        }



    }
}

