using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class VentasForm : Form
    {
        public int IdSucursal { get; set; }
        public int IdUsuario { get; set; }

        ProductoDao productoDao;
        ClienteDao clienteDao;
        VentaDao ventaDao;

        Conexion con = new Conexion();
        private List<DetalleVenta> detallesVenta = new List<DetalleVenta>();
        private int selectedIdProducto;
        private string selectedNombreProducto;
        private decimal selectedPrecioVenta;
        private int? selectedIdCliente = null;
        private string selectedNombreCliente;
        public string nombresucur;
        public VentasForm()
        {
            InitializeComponent();
            productoDao = new ProductoDao(con);
            
            clienteDao = new ClienteDao(con);
           
           
            ventaDao = new VentaDao(con);
             CargarTiposPago();
            cargarSucursales();
            CargarCategorias();
            cargarSucur();


            //ConfigurarTablaProductos();

            // Configurar DataGridView de clientes

            // Configurar event handlers
            ConfigurarTabladetalleventas();
            //ConfigurarTablaClientes();
            tablaProductos.CellClick += tablaProductos_CellClick;
            tablaclientes.CellClick += tablaclientes_CellClick;
            txtMonto.Enabled = false;
            txtMonto.Text = "0";

            // Event handler para el RadioButton
            radioagregarenvio.CheckedChanged += radioagregarenvio_CheckedChanged;

        }

        private void VentasForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabladetalleventas.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = tabladetalleventas.SelectedRows[0];

                // Eliminar el detalle de la lista
                int rowIndex = selectedRow.Index;
                detallesVenta.RemoveAt(rowIndex);

                // Eliminar la fila del DataGridView
                tabladetalleventas.Rows.RemoveAt(rowIndex);

                // Actualizar el total gastado
                ActualizarTotalGastado();
            }

        }


        private void CargarTiposPago()
        {
            DataTable pagos = ventaDao.CargarTiposPago();
            comboTipoPago.DataSource = pagos;
            comboTipoPago.DisplayMember = "nombre";
            comboTipoPago.ValueMember = "id_tipo_pago";
           
        }







        private void cargarSucursales()
        {
            CompraDao compraDao = new CompraDao(con);
            DataTable sucursales = compraDao.CargarSucursales();
            comboSucursales.DataSource = sucursales;
            comboSucursales.DisplayMember = "nombre_sucursal";
            comboSucursales.ValueMember = "id_sucursal";
          

        }

        private void cargarSucur()
        {

            CompraDao compraDao = new CompraDao(con);
            DataTable sucursales = compraDao.CargarSucursales();
            comboSuc.DataSource = sucursales;
            comboSuc.DisplayMember = "nombre_sucursal";
            comboSuc.ValueMember = "id_sucursal";


        }








        private void CargarCategorias()
        {
            DataTable categorias = productoDao.CargarCategorias();
            combocategorias.DataSource = categorias;
            combocategorias.DisplayMember = "nombre_categoria";
            combocategorias.ValueMember = "id_categoria_producto";
        }





        private void CargarProductos()
        {
            if (comboSucursales.SelectedValue != null && combocategorias.SelectedValue != null)
            {
                int idSucursal = (int)comboSucursales.SelectedValue;
                int idCategoria = (int)combocategorias.SelectedValue;

                DataTable productos = productoDao.CargarProductosVenta(idSucursal, idCategoria);
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

        private void ConfigurarTabladetalleventas()
        {
            tabladetalleventas.AutoGenerateColumns = false;
            tabladetalleventas.Columns.Add(new DataGridViewTextBoxColumn { Name = "Producto", HeaderText = "Producto" });
            tabladetalleventas.Columns.Add(new DataGridViewTextBoxColumn { Name = "Cantidad", HeaderText = "Cantidad" });
            tabladetalleventas.Columns.Add(new DataGridViewTextBoxColumn { Name = "Precio", HeaderText = "Precio" });
            tabladetalleventas.Columns.Add(new DataGridViewTextBoxColumn { Name = "Subtotal", HeaderText = "Subtotal" });
        }


        private void CargarClientes(int idSucursal)
        {
            DataTable clientes = clienteDao.CargarClientes(idSucursal);
            if (clientes != null && clientes.Rows.Count > 0)
            {
                tablaclientes.DataSource = clientes;
                tablaclientes.Refresh();
            }
            else
            {
                MessageBox.Show("No se encontraron clientes para la sucursal seleccionada.");
                tablaclientes.DataSource = null; // Limpiar la tabla si no hay resultados
            }
        }

        private void FiltrarClientesPorNombre(string nombreCliente)
        {
            DataTable dt = (DataTable)tablaclientes.DataSource;
            if (dt != null)
            {
                dt.DefaultView.RowFilter = $"nombre LIKE '%{nombreCliente}%' OR apellido LIKE '%{nombreCliente}%'";
            }
        }






        private void combocategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Buscarcliente_TextChanged(object sender, EventArgs e)
        {
            string nombreCliente = Buscarcliente.Text.Trim();
            FiltrarClientesPorNombre(nombreCliente);
        }


        private void comboSuc_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboSuc.SelectedValue != null)
            {
                int idSucursal = (int)comboSuc.SelectedValue;
                CargarClientes(idSucursal);
                
            }


        }

        private void comboSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }




       /* private void ConfigurarTablaClientes()
        {
            tablaclientes.AutoGenerateColumns = false;
            tablaclientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "ID", HeaderText = "ID" });
            tablaclientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "NOMBRE", HeaderText = "NOMBRE" });
            tablaclientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "APELLIDO", HeaderText = "APELLIDO" });
            tablaclientes.Columns.Add(new DataGridViewTextBoxColumn { Name = "TEL", HeaderText = "TEL" });
        }*/


        private void CargarTipopago()
        {
            CompraDao compraDao = new CompraDao(con);
            DataTable pagos = compraDao.CargarTiposPago();
            comboTipoPago.DataSource = pagos;
            comboTipoPago.DisplayMember = "nombre";
            comboTipoPago.ValueMember = "id_tipo_pago";


        }

        private void tablaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tablaProductos.Rows[e.RowIndex];
                selectedIdProducto = (int)row.Cells["ID"].Value;
                selectedNombreProducto = row.Cells["PRODUCTO"].Value.ToString();
                selectedPrecioVenta = (decimal)row.Cells["PRECIO"].Value;
                int stock = (int)row.Cells["STOCK"].Value;

                // Mostrar detalles del producto seleccionado en etiquetas o campos de texto
                labelProducto.Text = selectedNombreProducto;
                CantidadSpinner.Value = 1;  // Valor por defecto
            }
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {

            if (selectedIdProducto != 0 && !string.IsNullOrEmpty(selectedNombreProducto))
            {
                int cantidad = (int)CantidadSpinner.Value;
                decimal subtotal = cantidad * selectedPrecioVenta;

                DetalleVenta detalle = new DetalleVenta
                {
                    IdProducto = selectedIdProducto,
                    Cantidad = cantidad,
                    Precio = selectedPrecioVenta,
                    Subtotal = subtotal
                };

                detallesVenta.Add(detalle);

                // Agregar el detalle al DataGridView
                tabladetalleventas.Rows.Add(selectedNombreProducto, cantidad, selectedPrecioVenta, subtotal);
                ActualizarTotalGastado();
            }

        }

        private void tablaclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tablaclientes.Rows[e.RowIndex];
                selectedNombreCliente = row.Cells["NOMBRE"].Value.ToString();
                nombrecliente.Text = selectedNombreCliente;
            }
        }


        private void ActualizarTotalGastado()
        {
            decimal total = detallesVenta.Sum(d => d.Subtotal);
            labeltotal.Text = $"Total: {total:C2}"; // Mostrar el total en formato moneda
        }

        private void pagar_Click(object sender, EventArgs e)
        {

            try
            {
                int? idCliente = null;
                if (!clienteEventual.Checked)
                {
                    idCliente = selectedIdCliente;
                }

                int idUsuario = this.IdUsuario;
                int idTipoPago = (int)comboTipoPago.SelectedValue;
                decimal montoEnvio = 0;

                // Obtener el monto del envío del TextBox si el RadioButton está seleccionado
                if (radioagregarenvio.Checked && decimal.TryParse(txtMonto.Text, out decimal parsedMontoEnvio))
                {
                    montoEnvio = parsedMontoEnvio;
                }

                // Calcular el total de la venta incluyendo el monto de envío
                decimal montoTotal = detallesVenta.Sum(d => d.Subtotal) + montoEnvio;

                Venta venta = new Venta
                {
                    Idcliente = idCliente,
                    IdUsuario = idUsuario,
                    IdTipoPago = idTipoPago,
                    MontoEnvio = montoEnvio,
                    IdSucursal = this.IdSucursal,
                    Detalles = detallesVenta
                };

                if (ventaDao.InsertarVentaConDetalles(venta))
                {
                    MessageBox.Show($"Venta registrada exitosamente. El total de la venta es: {montoTotal:C2}");

                    // Generar factura si el radio button está marcado
                    if (radioConFactura.Checked)
                    {
                        GenerarFacturaPDF(montoTotal);
                    }

                    LimpiarTodo();
                }
                else
                {
                    MessageBox.Show("Error al registrar la venta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la venta: {ex.Message}");
            }
        }


        private void botonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void LimpiarTodo()
        {
            // Limpiar la tabla de detalles de venta
            tabladetalleventas.Rows.Clear();

            // Limpiar la lista de detalles de venta
            detallesVenta.Clear();

            // Restablecer los campos de entrada a sus valores predeterminados
            labelProducto.Text = string.Empty;
            CantidadSpinner.Value = 0; // Valor por defecto
            labeltotal.Text = "Total: 0.00"; // Restablecer el total gastado

            // Restablecer otros controles si es necesario
            comboTipoPago.SelectedIndex = -1; // Desseleccionar el tipo de pago
                                              // Opcional: Restablecer otros controles si es necesario
            tablaclientes.ClearSelection();
            tablaProductos.ClearSelection();
            selectedIdCliente = 0;
           // nombrecliente = string.Empty;
        }

        private void botonagregarcliente_Click(object sender, EventArgs e)
        {
            if (tablaclientes.SelectedRows.Count > 0)
            {
                DataGridViewRow row = tablaclientes.SelectedRows[0];
                selectedIdCliente = (int)row.Cells["ID"].Value;
                selectedNombreCliente = row.Cells["NOMBRE"].Value.ToString();
                MessageBox.Show("Cliente añadido: " + selectedNombreCliente);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista.");
            }
        }

        private void radioagregarenvio_CheckedChanged(object sender, EventArgs e)
        {
            if (radioagregarenvio.Checked)
            {
                if (selectedIdCliente == null)
                {
                    MessageBox.Show("Debe seleccionar un cliente antes de añadir un envío.");
                    radioagregarenvio.Checked = false; // Desactivar el RadioButton
                }
                else
                {
                    txtMonto.Enabled = true;
                }
            }
            else
            {
                txtMonto.Enabled = false;
                txtMonto.Text = "0";
            }
        }

        private void botonquitarcliente_Click(object sender, EventArgs e)
        {
            // Deseleccionar cliente y restablecer variables relacionadas
            selectedIdCliente = null;
            selectedNombreCliente = null;
            nombrecliente.Text = "Sin cliente";

            // Desactivar y limpiar el TextBox de monto de envío
            radioagregarenvio.Checked = false;
            txtMonto.Enabled = false;
            txtMonto.Text = "0";

            MessageBox.Show("Cliente deseleccionado.");
        }






        private void GenerarFacturaPDF(decimal montoTotal)
        {
            try
            {
                // Obtener la ruta del escritorio del usuario
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // Especificar la carpeta donde se guardará el PDF
                string facturasFolder = System.IO.Path.Combine(desktopPath, "Facturas");

                // Crear la carpeta si no existe
                if (!Directory.Exists(facturasFolder))
                {
                    Directory.CreateDirectory(facturasFolder);
                }

                // Definir la ruta completa del archivo PDF
                string pdfPath = System.IO.Path.Combine(facturasFolder, "FacturaVenta.pdf");

                // Crear un documento PDF
                using (var document = new Document())
                {
                    PdfWriter.GetInstance(document, new FileStream(pdfPath, FileMode.Create));
                    document.Open();

                    // Nombre de la empresa
                    document.Add(new Paragraph("CTAC"));
                    document.Add(new Paragraph(""));

                    // Fecha de la venta
                    document.Add(new Paragraph($"Fecha de la Venta: {DateTime.Now.ToString("dd/MM/yyyy")}"));
                    document.Add(new Paragraph(" "));

                    // Detalles del cliente (si hay)
                    if (selectedIdCliente != null)
                    {
                        document.Add(new Paragraph($"Cliente: {selectedNombreCliente}"));
                        document.Add(new Paragraph(" "));
                    }

                    // Detalles de los productos
                    PdfPTable table = new PdfPTable(4);
                    table.AddCell("Producto");
                    table.AddCell("Cantidad");
                    table.AddCell("Precio");
                    table.AddCell("Subtotal");

                    foreach (DataGridViewRow row in tabladetalleventas.Rows)
                    {
                        if (row.Cells["Producto"].Value != null)
                        {
                            table.AddCell(row.Cells["Producto"].Value.ToString());
                            table.AddCell(row.Cells["Cantidad"].Value.ToString());
                            table.AddCell(Convert.ToDecimal(row.Cells["Precio"].Value).ToString("C2"));
                            table.AddCell(Convert.ToDecimal(row.Cells["Subtotal"].Value).ToString("C2"));
                        }
                    }

                    document.Add(table);

                    // Monto del envío
                    document.Add(new Paragraph($"Monto de Envío: {txtMonto.Text:C2}"));
                    document.Add(new Paragraph(" "));

                    // Monto total
                    document.Add(new Paragraph($"Monto Total: {montoTotal:C2}"));

                    document.Close();
                }

                // Mostrar un mensaje de éxito
                MessageBox.Show($"Factura generada exitosamente en: {pdfPath}");

                // Abrir el archivo PDF
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = pdfPath,
                    UseShellExecute = true,
                    Verb = "open"
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar la factura: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }

    }

