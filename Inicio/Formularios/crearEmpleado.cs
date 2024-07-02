using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio.Formularios
{
    public partial class crearEmpleado : Form
    {
        private EmpleadoDAO empleadoDAO;
        private const string placeholderText = "00000000-0";

        public crearEmpleado()
        {
            InitializeComponent();

            var conexion = new Conexion();
            empleadoDAO = new EmpleadoDAO(conexion); ;

            CargarCategoriasEmpleado();
            CargarSucursales();
            dgvEmpleado.AllowUserToAddRows = false;
            dgvEmpleado.CellClick += dataGridView1_CellClick;

            txtDui.Text = placeholderText;
            txtDui.ForeColor = Color.Gray;
            txtDui.Enter += txtDui_Enter;
            txtDui.Leave += txtDui_Leave;
            txtDui.KeyPress += txtDui_KeyPress;
            txtDui.TextChanged += txtDui_TextChanged;
        }

        private void CargarCategoriasEmpleado()
        {
            try
            {
                DataTable categorias = empleadoDAO.ObtenerCategoriasEmpleado();
                cmbCategoriaempleado.DataSource = categorias;
                cmbCategoriaempleado.DisplayMember = "cat_empleado";
                cmbCategoriaempleado.ValueMember = "id_cat_empleado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías de empleados: " + ex.Message);
            }
        }

        private void CargarSucursales()
        {
            try
            {
                DataTable sucursales = empleadoDAO.ObtenerSucursales();
                cmbSucursal.DataSource = sucursales;
                cmbSucursal.DisplayMember = "nombre_sucursal";
                cmbSucursal.ValueMember = "id_sucursal";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las sucursales: " + ex.Message);
            }
        }

        private void CargarEmpleados()
        {
            try
            {
                DataTable empleados = empleadoDAO.ObtenerEmpleados();
                dgvEmpleado.DataSource = empleados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los empleados: " + ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string dui = txtDui.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            int? idCatEmpleado = cmbCategoriaempleado.SelectedValue as int?;
            int? idUsuario = string.IsNullOrEmpty(txtIdUsuario.Text) ? (int?)null : Convert.ToInt32(txtIdUsuario.Text);
            int? idCuenta = string.IsNullOrEmpty(txtCuenta.Text) ? (int?)null : Convert.ToInt32(txtCuenta.Text);
            int? idSucursal = cmbSucursal.SelectedValue as int?;

          
            Console.WriteLine($"Nombre: {nombre}, Apellido: {apellido}, DUI: {dui}, Direccion: {direccion}");
            Console.WriteLine($"IdCatEmpleado: {idCatEmpleado}, IdUsuario: {idUsuario}, IdCuenta: {idCuenta}, IdSucursal: {idSucursal}");

            
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El campo Nombre no debe estar vacío.");
                return;
            }

            if (string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("El campo Apellido no debe estar vacío.");
                return;
            }

            if (string.IsNullOrEmpty(dui) || dui.Length != 10)
            {
                MessageBox.Show("El DUI debe tener el formato 00000000-0.");
                return;
            }

            if (string.IsNullOrEmpty(direccion))
            {
                MessageBox.Show("El campo Dirección no debe estar vacío.");
                return;
            }

            if (!idCatEmpleado.HasValue)
            {
                MessageBox.Show("Debe seleccionar una categoría de empleado.");
                return;
            }

            if (!idUsuario.HasValue)
            {
                MessageBox.Show("El campo ID de Usuario no debe estar vacío.");
                return;
            }

            if (!idSucursal.HasValue)
            {
                MessageBox.Show("Debe seleccionar una sucursal.");
                return;
            }

            if (empleadoDAO.ExisteDUI(dui))
            {
                MessageBox.Show("El DUI ya está en uso. Por favor, ingrese otro DUI.");
                return;
            }

            if (!empleadoDAO.ExisteIdUsuarioEnTablaUsuario(idUsuario.Value))
            {
                MessageBox.Show("El ID de usuario no existe. Por favor, ingrese un ID válido.");
                return;
            }

            if (idCuenta.HasValue && !empleadoDAO.ExisteIdCuentaEnTablaCuenta(idCuenta.Value))
            {
                MessageBox.Show("El ID de cuenta no existe. Por favor, ingrese un ID válido.");
                return;
            }

            if (empleadoDAO.ExisteIdUsuario(idUsuario.Value))
            {
                MessageBox.Show("El ID de usuario ya está en uso. Por favor, ingrese otro ID.");
                return;
            }

            if (idCuenta.HasValue && empleadoDAO.ExisteIdCuenta(idCuenta.Value))
            {
                MessageBox.Show("El ID de cuenta ya está en uso. Por favor, ingrese otro ID.");
                return;
            }

            try
            {
                empleadoDAO.CrearEmpleado(nombre, apellido, dui, direccion, idCatEmpleado.Value, idUsuario.Value, idCuenta, idSucursal.Value);
                MessageBox.Show("Empleado creado exitosamente.");
                CargarEmpleados();

            }
            catch (SqlException sqlEx)
            {
                foreach (SqlError error in sqlEx.Errors)
                {
                    Console.WriteLine("Número de error: {0}, Mensaje: {1}", error.Number, error.Message);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el empleado: " + ex.Message);
                Console.WriteLine("Error al crear el empleado: " + ex.ToString());
                Console.WriteLine("Error general: " + ex.Message);
            }
            
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmpleado.Rows[e.RowIndex];

                txtNombre.Text = row.Cells["nombre"].Value.ToString();
                txtApellido.Text = row.Cells["apellido"].Value.ToString();
                txtDui.Text = row.Cells["dui"].Value.ToString();
                txtDireccion.Text = row.Cells["direccion"].Value.ToString();
                cmbCategoriaempleado.SelectedValue = row.Cells["id_cat_empleado"].Value;
                txtIdUsuario.Text = row.Cells["id_usuario"].Value.ToString();
                txtCuenta.Text = row.Cells["id_cuenta"].Value.ToString();
                cmbSucursal.SelectedValue = row.Cells["id_sucursal"].Value;
            }
        }

        private void crearEmpleado_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text)
                && !string.IsNullOrEmpty(txtDui.Text) && !string.IsNullOrEmpty(txtDireccion.Text)
                && !string.IsNullOrEmpty(txtIdUsuario.Text))
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string dui = txtDui.Text;
                string direccion = txtDireccion.Text;
                int idCatEmpleado = Convert.ToInt32(cmbCategoriaempleado.SelectedValue);
                int idUsuario = Convert.ToInt32(txtIdUsuario.Text);
                int? idCuenta = string.IsNullOrEmpty(txtCuenta.Text) ? (int?)null : Convert.ToInt32(txtCuenta.Text);
                int idSucursal = Convert.ToInt32(cmbSucursal.SelectedValue);

                try
                {
                    int idEmpleado = Convert.ToInt32(dgvEmpleado.CurrentRow.Cells["id_empleado"].Value);

                    if (empleadoDAO.ExisteDUI(dui) && dui != dgvEmpleado.CurrentRow.Cells["dui"].Value.ToString())
                    {
                        MessageBox.Show("El DUI ya está en uso. Por favor, ingrese otro DUI.");
                        return;
                    }
                    if (!empleadoDAO.ExisteIdUsuarioEnTablaUsuario(idUsuario) && idUsuario != (int)dgvEmpleado.CurrentRow.Cells["id_usuario"].Value)
                    {
                        MessageBox.Show("El ID de usuario no existe. Por favor, ingrese un ID válido.");
                        return;
                    }

                    if (idCuenta.HasValue)
                    {
                        if (!empleadoDAO.ExisteIdCuentaEnTablaCuenta(idCuenta.Value) && idCuenta.Value != (int)dgvEmpleado.CurrentRow.Cells["id_cuenta"].Value)
                        {
                            MessageBox.Show("El ID de cuenta no existe. Por favor, ingrese un ID válido.");
                            return;
                        }
                        if (empleadoDAO.ExisteIdCuenta(idCuenta.Value) && idCuenta.Value != (int)dgvEmpleado.CurrentRow.Cells["id_cuenta"].Value)
                        {
                            MessageBox.Show("El ID de cuenta ya está en uso. Por favor, ingrese otro ID.");
                            return;
                        }
                    }

                    if (empleadoDAO.ExisteIdUsuario(idUsuario) && idUsuario != (int)dgvEmpleado.CurrentRow.Cells["id_usuario"].Value)
                    {
                        MessageBox.Show("El ID de usuario ya está en uso. Por favor, ingrese otro ID.");
                        return;
                    }

                    empleadoDAO.ActualizarEmpleado(idEmpleado, nombre, apellido, dui, direccion, idCatEmpleado, idUsuario, idCuenta, idSucursal);
                    MessageBox.Show("Empleado actualizado correctamente.");
                    CargarEmpleados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los cambios: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor completa todos los campos antes de guardar los cambios.");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            crearCuenta crearCuentasForm = new crearCuenta();
            crearCuentasForm.CuentaCreada += (idCuenta) =>
            {
                txtCuenta.Text = idCuenta.ToString();
            };
            crearCuentasForm.ShowDialog();
        }

        private void txtDui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtDui.Text.Replace("-", "").Length >= 9 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDui_TextChanged(object sender, EventArgs e)
        {
            string dui = txtDui.Text.Replace("-", "");
            if (dui.Length > 8)
            {
                dui = dui.Insert(8, "-");
            }
            txtDui.TextChanged -= txtDui_TextChanged;
            txtDui.Text = dui;
            txtDui.SelectionStart = dui.Length;
            txtDui.TextChanged += txtDui_TextChanged;
        }

        private void txtDui_Enter(object sender, EventArgs e)
        {
            if (txtDui.Text == placeholderText)
            {
                txtDui.Text = "";
                txtDui.ForeColor = Color.Black;
            }
        }

        private void txtDui_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDui.Text))
            {
                txtDui.Text = placeholderText;
                txtDui.ForeColor = Color.Gray;
            }
        }
    }
}