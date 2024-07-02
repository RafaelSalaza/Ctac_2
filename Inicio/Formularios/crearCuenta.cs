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
    public partial class crearCuenta : Form
    {
        private CuentaDAO cuentaDAO;
        public event Action<int> CuentaCreada;

        public crearCuenta()
        {
            InitializeComponent();

            var conexion = new Conexion();
            cuentaDAO = new CuentaDAO(conexion); ;

            CargarCategoriasCuenta();
            CargarCuentas();
            dgvCuenta.AllowUserToAddRows = false;
            this.txtIdCuenta.Enabled = false;
        }

        private void CargarCategoriasCuenta()
        {
            try
            {
    
                var categorias = cuentaDAO.ObtenerCategoriasCuenta();

                cmbTipoCuenta.DataSource = categorias;
                cmbTipoCuenta.DisplayMember = "tipo_cuenta";
                cmbTipoCuenta.ValueMember = "id_categoria_cuenta";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías de cuenta: " + ex.Message);
            }
        }

        private void CargarCuentas()
        {
            try
            {
                DataTable cuentas = cuentaDAO.ObtenerCuentas();
                dgvCuenta.DataSource = cuentas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las cuentas: " + ex.Message);
            }
        }

        private void crearCuenta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numeroCuenta = txtNumeroCuenta.Text;
            string banco = txtBanco.Text;
            int idCategoriaCuenta = (int)cmbTipoCuenta.SelectedValue;

            try
            {
                cuentaDAO.CrearCuenta(numeroCuenta, banco, idCategoriaCuenta);

                int idCuenta = cuentaDAO.ObtenerUltimoIdCuenta();

                MessageBox.Show("Cuenta creada exitosamente.");
                CuentaCreada?.Invoke(idCuenta);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la cuenta: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdCuenta.Text) && !string.IsNullOrEmpty(txtNumeroCuenta.Text) && !string.IsNullOrEmpty(txtBanco.Text))
            {
                int idCuenta = Convert.ToInt32(txtIdCuenta.Text);
                string numeroCuenta = txtNumeroCuenta.Text;
                string banco = txtBanco.Text;
                int idCategoriaCuenta = (int)cmbTipoCuenta.SelectedValue;

                try
                {
                    cuentaDAO.ActualizarCuenta(idCuenta, numeroCuenta, banco, idCategoriaCuenta);

                    MessageBox.Show("Cuenta actualizada correctamente.");
                    CargarCuentas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la cuenta: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor completa todos los campos antes de guardar los cambios.");
            }
        }

        private void dgvCuenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCuenta.Rows[e.RowIndex];
                int idCuenta = Convert.ToInt32(row.Cells["id_cuenta"].Value);
                string numeroCuenta = row.Cells["numero_cuenta"].Value.ToString();
                string banco = row.Cells["banco"].Value.ToString();
                int idCategoriaCuenta = Convert.ToInt32(row.Cells["id_categoria_cuenta"].Value);

                txtIdCuenta.Text = idCuenta.ToString();
                txtNumeroCuenta.Text = numeroCuenta;
                txtBanco.Text = banco;
                cmbTipoCuenta.SelectedValue = idCategoriaCuenta;
            }
        }

        private void seleccionar_Click(object sender, EventArgs e)
        {
            if (dgvCuenta.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCuenta.SelectedRows[0];
                int idCuenta = Convert.ToInt32(selectedRow.Cells["id_cuenta"].Value);

                // Invoca el evento para notificar la selección
                CuentaCreada?.Invoke(idCuenta);
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una dirección.");
            }
        }
    }
}
