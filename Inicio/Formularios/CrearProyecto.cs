
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inicio.Formularios
{
    public partial class CrearProyecto : Form
    {
        private ProyectoDao proyectoDAO;
        public int IdUsuario { get; set; }
        public CrearProyecto()
        {
            InitializeComponent();


            // Crear una instancia de UsuarioDAO con la conexión adecuada
            var conexion = new Conexion();
            proyectoDAO = new ProyectoDao(conexion);

            // Cargar los roles al abrir el formulario
            CargarClientes();
            CargarTiposPago();
            CargarCatProyecto();
            //CargarDirecciones();
            CargarEstados();
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
                MessageBox.Show("Error al cargar los roles: " + ex.Message);
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
                MessageBox.Show("Error al cargar los roles: " + ex.Message);
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
                MessageBox.Show("Error al cargar los roles: " + ex.Message);
            }
        }

     /*  private void CargarDirecciones()
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
                MessageBox.Show("Error al cargar los roles: " + ex.Message);
            }
        }*/

        private void CargarEstados()
        {
            try
            {
                // Obtener los roles desde la base de datos utilizando UsuarioDAO
                var estados = proyectoDAO.GetEstadoProyecto();

                // Asignar la lista de roles al ComboBox
                cmbIdEstadoProyecto.DataSource = estados;
                cmbIdEstadoProyecto.DisplayMember = "Nombre";
                cmbIdEstadoProyecto.ValueMember = "Id_estado_proyecto";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los roles: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void CrearProyecto_Load(object sender, EventArgs e, ProyectoDao proyectoDao)
        {

        }

        private void cmbIdEstadoProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CrearProyecto_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                int idUsuario = this.IdUsuario;

                string nombreProyecto = txtNombre.Text.ToLower();

                // Verificar si el nombre del proyecto ya existe
                if (proyectoDAO.ExisteProyectoConNombre(nombreProyecto))
                {
                    MessageBox.Show("Ya existe un proyecto con ese nombre. Por favor, elija un nombre diferente.");
                    return;
                }

                Proyecto nuevoProyecto = new Proyecto
                {
                    Nombre = nombreProyecto,
                    Descripcion = txtDescripcion.Text,
                    Id_direccion = Convert.ToInt32(txtDireccion.Text),
                    Id_empleado = idUsuario,
                    Id_categoria_proyecto = (int)cmbIdCategoriaProyecto.SelectedValue,
                    Id_cliente = (int)cmbIdCliente.SelectedValue,
                    Precio_proyecto = decimal.Parse(txtPrecioProyecto.Text),
                    Id_tipo_pago = (int)cmbIdTipoPago.SelectedValue,
                    Financiado = chkFinanciado.Checked,
                    Pagado = chkPagado.Checked,
                    Id_estado_proyecto = (int)cmbIdEstadoProyecto.SelectedValue
                };

                proyectoDAO.AgregarProyecto(nuevoProyecto, idUsuario);

                MessageBox.Show("Proyecto guardado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el proyecto: " + ex.Message);
            }
        }

        private void chkFinanciado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CrearDireccion_Click(object sender, EventArgs e)
        {
            crearDireccion crearDireccionForm = new crearDireccion();
            crearDireccionForm.DireccionCreada += (idDireccion) =>
            {
                this.txtDireccion.Text = idDireccion.ToString();
            };
            crearDireccionForm.ShowDialog();
        }
    }
}
