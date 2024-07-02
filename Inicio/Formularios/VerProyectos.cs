
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
    public partial class VerProyectos : Form
    {

        private ProyectoDao proyectoDAO;

        public int IdUsuario { get; set; }

        public VerProyectos()
        {
            InitializeComponent();
            var conexion = new Conexion();
            proyectoDAO = new ProyectoDao(conexion);


            dataGridView1.AutoGenerateColumns = false;
            InitializeDataGridViewColumns();

            CargarProyectos();

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            CargarClientes();
            CargarTiposPago();
            CargarCatProyecto();
            CargarDirecciones();
            CargarEstados();

        }
        private void InitializeDataGridViewColumns()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Nombre", HeaderText = "Nombre" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Descripcion", HeaderText = "Descripción" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "NombreDireccion", HeaderText = "Dirección" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "NombreCliente", HeaderText = "Cliente" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "NombreCategoria", HeaderText = "Categoría" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Precio_proyecto", HeaderText = "Precio Proyecto" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "NombreTipoPago", HeaderText = "Tipo de Pago" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Financiado", HeaderText = "Financiado" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Pagado", HeaderText = "Pagado" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "NombreEstadoProyecto", HeaderText = "Estado del Proyecto" });
        }

        private void CargarClientes()
        {
            try
            {
                // Obtener los roles desde la base de datos utilizando UsuarioDAO
                var clientes = proyectoDAO.GetClientes();

                // Asignar la lista de roles al ComboBox
                cmbIdCliente.DataSource = clientes;
                cmbIdCliente.DisplayMember = "Nombre";
                cmbIdCliente.ValueMember = "Id_cliente";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }

        private void CargarTiposPago()
        {
            try
            {
                // Obtener los roles desde la base de datos utilizando UsuarioDAO
                var tipopago = proyectoDAO.GetTipoPago();

                // Asignar la lista de roles al ComboBox
                cmbIdTipoPago.DataSource = tipopago;
                cmbIdTipoPago.DisplayMember = "Nombre";
                cmbIdTipoPago.ValueMember = "Id_tipo_pago";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pagos: " + ex.Message);
            }
        }

        private void CargarCatProyecto()
        {
            try
            {
                // Obtener los roles desde la base de datos utilizando UsuarioDAO
                var CatProyecto = proyectoDAO.GetCatProyecto();

                // Asignar la lista de roles al ComboBox
                cmbIdCategoriaProyecto.DataSource = CatProyecto;
                cmbIdCategoriaProyecto.DisplayMember = "Nombre_categoria";
                cmbIdCategoriaProyecto.ValueMember = "Id_categoria_proyecto";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las cat_proyecto: " + ex.Message);
            }
        }

        private void CargarDirecciones()
        {
            try
            {
                // Obtener los roles desde la base de datos utilizando UsuarioDAO
                var direcciones = proyectoDAO.GetDireccion();

                // Asignar la lista de roles al ComboBox
                cmbIdDireccion.DataSource = direcciones;
                cmbIdDireccion.DisplayMember = "Descripcion";
                cmbIdDireccion.ValueMember = "Id_direccion";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las direcciones: " + ex.Message);
            }
        }

        private void CargarEstados()
        {
            try
            {
                var estados = proyectoDAO.GetEstadoProyecto();

                cmbIdEstadoProyecto.DataSource = estados;
                cmbIdEstadoProyecto.DisplayMember = "Nombre";
                cmbIdEstadoProyecto.ValueMember = "Id_estado_proyecto";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los estados: " + ex.Message);
            }
        }

        private void VerProyectos_Load(object sender, EventArgs e)
        {

        }

        private void CargarProyectos()
        {
            try
            {
                var proyectos = proyectoDAO.ObtenerProyectosCreados();
                dataGridView1.DataSource = proyectos;
                dataGridView1.AutoGenerateColumns = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proyectos: " + ex.Message);
            }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Proyecto proyectoSeleccionado = (Proyecto)selectedRow.DataBoundItem;

                txtNombre.Text = proyectoSeleccionado.Nombre;
                txtDescripcion.Text = proyectoSeleccionado.Descripcion;
                txtPrecioProyecto.Text = proyectoSeleccionado.Precio_proyecto.ToString();
                chkFinanciado.Checked = proyectoSeleccionado.Financiado;
                chkPagado.Checked = proyectoSeleccionado.Pagado;

                cmbIdCliente.SelectedIndex = cmbIdCliente.FindStringExact(proyectoSeleccionado.NombreCliente);
                cmbIdTipoPago.SelectedIndex = cmbIdTipoPago.FindStringExact(proyectoSeleccionado.NombreTipoPago);
                cmbIdDireccion.SelectedIndex = cmbIdDireccion.FindStringExact(proyectoSeleccionado.NombreDireccion);
                cmbIdEstadoProyecto.SelectedIndex = cmbIdEstadoProyecto.FindStringExact(proyectoSeleccionado.NombreEstadoProyecto);
                cmbIdCategoriaProyecto.SelectedIndex = cmbIdCategoriaProyecto.FindStringExact(proyectoSeleccionado.NombreCategoria);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    Proyecto proyectoSeleccionado = (Proyecto)selectedRow.DataBoundItem;

                    proyectoSeleccionado.Nombre = txtNombre.Text;
                    proyectoSeleccionado.Descripcion = txtDescripcion.Text;
                    proyectoSeleccionado.Id_direccion = (int)cmbIdDireccion.SelectedValue;
                    proyectoSeleccionado.Id_categoria_proyecto = (int)cmbIdCategoriaProyecto.SelectedValue;
                    proyectoSeleccionado.Id_cliente = (int)cmbIdCliente.SelectedValue;
                    proyectoSeleccionado.Precio_proyecto = decimal.Parse(txtPrecioProyecto.Text);
                    proyectoSeleccionado.Id_tipo_pago = (int)cmbIdTipoPago.SelectedValue;
                    proyectoSeleccionado.Financiado = chkFinanciado.Checked;
                    proyectoSeleccionado.Pagado = chkPagado.Checked;
                    proyectoSeleccionado.Id_estado_proyecto = (int)cmbIdEstadoProyecto.SelectedValue;

                    proyectoDAO.ModificarProyecto(proyectoSeleccionado);
                    CargarProyectos(); // Recargar los proyectos para actualizar el DataGridView

                    MessageBox.Show("Proyecto modificado exitosamente.");
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un proyecto para modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el proyecto: " + ex.Message);
            }
        }

        private void cmbIdDireccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioProyecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
