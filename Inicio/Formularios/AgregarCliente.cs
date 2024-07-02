
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
    public partial class AgregarCliente : Form
    {

        private ClienteDao clienteDao;
        private const string placeholderText = "00000000-0";
        private const string placeholderText2 = "0000-0000";
        public int IdUsuario { get; set; }


        public AgregarCliente()
        {
            InitializeComponent();

            var conexion = new Conexion();
            clienteDao = new ClienteDao(conexion);
            txtDui.Text = placeholderText;
            txtDui.ForeColor = Color.Gray;
            txtDui.Enter += txtDui_Enter;
            txtDui.Leave += txtDui_Leave;
            txtDui.KeyPress += txtDui_KeyPress;
            txtDui.TextChanged += txtDui_TextChanged;

            CargarSucursales();
            //Cargarcuentas();
            txtTelefono.Text = placeholderText2;
            txtTelefono.ForeColor = Color.Gray;
            txtTelefono.Enter += txtTelefono_Enter;
            txtTelefono.Leave += txtTelefono_Leave;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
        }

        private void CargarSucursales()
        {
            try
            {
                var sucursales = clienteDao.Getsucursales();

                cmbSucursal.DataSource = sucursales;
                cmbSucursal.DisplayMember = "Nombre_sucursal";
                cmbSucursal.ValueMember = "Id_sucursal";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las sucursales: " + ex.Message);
            }
        }

       /* private void Cargarcuentas()
        {
            try
            {
                var cuentas = clienteDao.GetCuentas();

                cmbCuenta.DataSource = cuentas;
                cmbCuenta.DisplayMember = "Numero_cuenta";
                cmbCuenta.ValueMember = "Id_cuenta";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las sucursales: " + ex.Message);
            }
        }*/




        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente nuevoCliente = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Dui = txtDui.Text,
                    Id_cuenta = string.IsNullOrEmpty(txtCuenta.Text) ? (int?)null : Convert.ToInt32(txtCuenta.Text),
                    Direccion = txtDireccion.Text,
                    Correo = txtCorreo.Text,
                    Fecha_registro = dtpRegistro.Value,
                    Id_sucursal = (int)cmbSucursal.SelectedValue,
                    Telefono = txtTelefono.Text,
                };

                clienteDao.AgregarCliente(nuevoCliente);

                MessageBox.Show("Cliente agregado exitosamente.");
                // Aquí puedes añadir código para limpiar los controles si es necesario
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el cliente: " + ex.Message);
            }
        }

        private void txtdui_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            string telefono = txtTelefono.Text.Replace("-", "");
            if (telefono.Length > 4)
            {
                telefono = telefono.Insert(4, "-");
            }
            txtTelefono.TextChanged -= txtTelefono_TextChanged;
            txtTelefono.Text = telefono;
            txtTelefono.SelectionStart = telefono.Length;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == placeholderText2)
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.Black;
            }
        }

       

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtTelefono.Text.Replace("-", "").Length >= 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

   
      

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                txtTelefono.Text = placeholderText2;
                txtTelefono.ForeColor = Color.Gray;
            }
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

        private void botonCrearCuenta_Click(object sender, EventArgs e)
        {
            crearCuenta crearCuentasForm = new crearCuenta();
            crearCuentasForm.CuentaCreada += (idCuenta) =>
            {
                txtCuenta.Text = idCuenta.ToString();
            };
            crearCuentasForm.ShowDialog();
        }
    }
}
