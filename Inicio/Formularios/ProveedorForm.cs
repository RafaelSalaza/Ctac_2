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
    public partial class ProveedorForm : Form
    {

        Conexion con = new Conexion();
        private ProveedorDao proveedorDao;

        public ProveedorForm()
        {
            InitializeComponent();

            tablaProveedor.AllowUserToAddRows = false;
        }
      
        private void ProveedorForm_Load(object sender, EventArgs e)
        {
            proveedorDao = new ProveedorDao(con);
            proveedorDao.Mostrar(tablaProveedor);
        }

        private void tablaProveedor_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            tablaProveedor.Columns["id_proveedor"].Width = 80; // Ancho de la columna "id_proveedor"
            tablaProveedor.Columns["nombre_proveedor"].Width = 200; // Ancho de la columna "nombre_proveedor"
            tablaProveedor.Columns["correo"].Width = 180; // Ancho de la columna "correo"
            tablaProveedor.Columns["numero_telefono"].Width = 120; // Ancho de la columna "numero_telefono"
            tablaProveedor.Columns["id_direccion"].Width = 300; // Ancho de la columna "id_direccion"
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            Proveedorn nuevoProveedor = new Proveedorn(
    txtNombreproveedor.Text,
    txtCorreo.Text,
    txtnumero.Text,
    txtdireccion.Text
);




            ProveedorDao proveedorDao = new ProveedorDao(con);
            bool resultado = proveedorDao.Agregar(nuevoProveedor);

            if (resultado)
            {
                MessageBox.Show("Proveedor agregado correctamente.");
                // Actualizar el DataGridView Conexion los datos actualizados
                proveedorDao.Mostrar(tablaProveedor);
            }
            else
            {
                MessageBox.Show("Error al agregar el proveedor.");
            }
        }

        private void botonactualizar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombreproveedor.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtnumero.Text) ||
                string.IsNullOrWhiteSpace(txtdireccion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el proveedor seleccionado en el DataGridView
            int indiceFilaSeleccionada = tablaProveedor.SelectedCells[0].RowIndex;
            DataGridViewRow filaSeleccionada = tablaProveedor.Rows[indiceFilaSeleccionada];
            int idProveedor = Convert.ToInt32(filaSeleccionada.Cells["id_proveedor"].Value);

            // Crear un objeto Proveedor Conexion los datos actualizados
            Proveedorn proveedorActualizado = new Proveedorn(
                txtNombreproveedor.Text,
                txtCorreo.Text,
                txtnumero.Text,
                txtdireccion.Text
            )
            {
                IdProveedor = idProveedor
            };

            ProveedorDao proveedorDao = new ProveedorDao(con);
            bool resultado = proveedorDao.Editar(proveedorActualizado);

            if (resultado)
            {
                MessageBox.Show("Proveedor editado correctamente.");
                // Actualizar el DataGridView Conexion los datos actualizados
                proveedorDao.Mostrar(tablaProveedor);
            }
            else
            {
                MessageBox.Show("Error al editar el proveedor.");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ProveedorDao proveedorDao = new ProveedorDao(con);
            string textoBusqueda = txtBuscar.Text;

            DataTable resultados = proveedorDao.Buscar(textoBusqueda);
          tablaProveedor.DataSource = resultados;

        }
    }
}
