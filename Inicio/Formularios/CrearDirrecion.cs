using System;
using System.Data;
using System.Windows.Forms;

namespace Inicio.Formularios
{
    public partial class crearDireccion : Form
    {
        private DireccionDAO direccionDAO;
        private DepartamentoDAO departamentoDAO;
        private DistritoDAO distritoDAO;
        public event Action<int> DireccionCreada;

        public crearDireccion()
        {
            InitializeComponent();

            var conexion = new Conexion();
            direccionDAO = new DireccionDAO(conexion);
            departamentoDAO = new DepartamentoDAO(conexion);
            distritoDAO = new DistritoDAO(conexion);


            CargarDepartamentos();
            CargarDirecciones();
            dgvDirecciones.AllowUserToAddRows = false;
            this.txtIdDireccion.Enabled = false;
            dgvDirecciones.CellClick += dgvDirecciones_CellClick;
            // Event handler for ComboBox selection change
            cmbDepartamento.SelectedIndexChanged += cmbDepartamento_SelectedIndexChanged;
        }
        private void CargarDepartamentos()
        {
            try
            {
                var departamentos = departamentoDAO.ObtenerDepartamentos();
                cmbDepartamento.DataSource = departamentos;
                cmbDepartamento.DisplayMember = "nombre_departamento";
                cmbDepartamento.ValueMember = "Id_departamento";

                // Cargar distritos para el primer departamento por defecto
                if (cmbDepartamento.Items.Count > 0)
                {
                    cmbDepartamento.SelectedIndex = 0;
                    CargarDistritos((int)cmbDepartamento.SelectedValue);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los departamentos: " + ex.Message);
            }
        }

        private void CargarDirecciones()
        {
            try
            {
                DataTable direcciones = direccionDAO.ObtenerDireccionesConDepartamento();
                if (direcciones != null && direcciones.Rows.Count > 0)
                {
                    dgvDirecciones.DataSource = direcciones;
                }
                else
                {
                    dgvDirecciones.DataSource = null;
                    MessageBox.Show("No se encontraron direcciones.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las direcciones: " + ex.Message);
            }
        }

        private void CargarDistritos(int idDepartamento)
        {
            try
            {
                var distritos = distritoDAO.ObtenerDistritosPorDepartamento(idDepartamento);
                cmbDistrito.DataSource = distritos;
                cmbDistrito.DisplayMember = "nombre";
                cmbDistrito.ValueMember = "id_distrito";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los distritos: " + ex.Message);
            }
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartamento.SelectedValue != null)
            {
                int idDepartamento = (int)cmbDepartamento.SelectedValue;
                CargarDistritos(idDepartamento);
            }
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtReferencia.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            string descripcion = txtDescripcion.Text;
            string referencia = txtReferencia.Text;
            int idDistrito = (int)cmbDistrito.SelectedValue;

            try
            {
                direccionDAO.CrearDireccion(idDistrito, descripcion, referencia);
                int idDireccion = direccionDAO.ObtenerUltimoIdDireccion();

                MessageBox.Show("Dirección creada exitosamente.");
                DireccionCreada?.Invoke(idDireccion);
                CargarDirecciones(); // Recargar la lista de direcciones
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la dirección: " + ex.Message);
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdDireccion.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtReferencia.Text))
            {
                MessageBox.Show("Por favor completa todos los campos antes de guardar los cambios.");
                return;
            }

            int idDireccion = Convert.ToInt32(txtIdDireccion.Text);
            string descripcion = txtDescripcion.Text;
            string referencia = txtReferencia.Text;
            int idDistrito = (int)cmbDistrito.SelectedValue;

            try
            {
                direccionDAO.ActualizarDireccion(idDireccion, idDistrito, descripcion, referencia);
                MessageBox.Show("Dirección actualizada correctamente.");
                CargarDirecciones(); // Recargar la lista de direcciones
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la dirección: " + ex.Message);
            }
        }

        private void dgvDirecciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDirecciones.Rows[e.RowIndex];
                int idDireccion = Convert.ToInt32(row.Cells["id_direccion"].Value);
                int idDepartamento = Convert.ToInt32(row.Cells["id_departamento"].Value);
                int idDistrito = Convert.ToInt32(row.Cells["id_distrito"].Value);
                string descripcion = row.Cells["descripcion"].Value.ToString();
                string referencia = row.Cells["referencia"].Value.ToString();

                txtIdDireccion.Text = idDireccion.ToString();
                txtDescripcion.Text = descripcion;
                txtReferencia.Text = referencia;
                cmbDepartamento.SelectedValue = idDepartamento;
                CargarDistritos(idDepartamento);
                cmbDistrito.SelectedValue = idDistrito;
            }
        }

        private void dgvDirecciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aquí puedes manejar eventos específicos de clic en las celdas, si es necesario
        }

        private void crearDireccion_Load(object sender, EventArgs e)
        {
            // Este evento se dispara cuando el formulario se carga
        }

        private void botonSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvDirecciones.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDirecciones.SelectedRows[0];
                int idDireccion = Convert.ToInt32(selectedRow.Cells["id_direccion"].Value);

                // Invoca el evento para notificar la selección
                DireccionCreada?.Invoke(idDireccion);
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una dirección.");
            }
        }
    }
}
