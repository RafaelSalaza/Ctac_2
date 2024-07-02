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
    public partial class CrearSueldo : Form
    {
        private Sueldod sueldoDAO;

        public CrearSueldo()
        {
            InitializeComponent();

            var conexion = new Conexion();
            sueldoDAO = new Sueldod(conexion); ;
        }

        private void CargarSueldos()
        {
            try
            {
                DataTable sueldos = sueldoDAO.ObtenerSueldos();
                dgvSueldo.DataSource = sueldos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los sueldos: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdEmpleado.Text) || string.IsNullOrWhiteSpace(txtSueldo.Text))
            {
                MessageBox.Show("No se permiten campos vacíos. Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idEmpleado = int.Parse(txtIdEmpleado.Text);
            decimal sueldo = decimal.Parse(txtSueldo.Text);

            if (sueldo < 350.00m)
            {
                MessageBox.Show("El sueldo mínimo permitido es de $350.00", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar si el ID de empleado existe en la tabla Empleado
            if (!sueldoDAO.ExisteIdEmpleadoEnTablaEmpleado(idEmpleado))
            {
                MessageBox.Show("El ID de empleado ingresado no existe en la tabla de empleados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar si el ID de empleado existe en la tabla Sueldo
            if (sueldoDAO.ExisteIdEmpleadoEnTablaSueldo(idEmpleado))
            {
                MessageBox.Show("El ID de empleado ingresado ya tiene un sueldo registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                sueldoDAO.CalcularSueldo(idEmpleado, sueldo);
                MessageBox.Show("Sueldo calculado y guardado exitosamente.");
                CargarSueldos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el sueldo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdEmpleado.Text) || string.IsNullOrWhiteSpace(txtSueldo.Text))
            {
                MessageBox.Show("No se permiten campos vacíos. Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idEmpleado = int.Parse(txtIdEmpleado.Text);
            decimal nuevoSueldo = decimal.Parse(txtSueldo.Text);

            if (nuevoSueldo < 350.00m)
            {
                MessageBox.Show("El sueldo mínimo permitido es de $350.00", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar si el ID de empleado existe en la tabla Empleado
            if (!sueldoDAO.ExisteIdEmpleadoEnTablaEmpleado(idEmpleado))
            {
                MessageBox.Show("El ID de empleado ingresado no existe en la tabla de empleados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                sueldoDAO.ActualizarSueldo(idEmpleado, nuevoSueldo);
                MessageBox.Show("Sueldo actualizado exitosamente.");
                CargarSueldos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el sueldo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CrearSueldo_Load_1(object sender, EventArgs e)
        {
            CargarSueldos();
        }

        private void dgvSueldo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSueldo.Rows[e.RowIndex];
                this.txtIdEmpleado.Text = row.Cells["id_empleado"].Value.ToString();
                txtSueldo.Text = row.Cells["sueldo_bruto"].Value.ToString();
            }
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            else if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (e.KeyChar != '.' && char.IsDigit(e.KeyChar))
            {
                TextBox textBox = (TextBox)sender;
                string currentText = textBox.Text.Insert(textBox.SelectionStart, e.KeyChar.ToString());
                decimal value;
                if (!decimal.TryParse(currentText, out value) || currentText.Split('.').Length > 1 && currentText.Split('.')[1].Length > 2)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtSueldo_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            decimal value;
            if (decimal.TryParse(textBox.Text, out value))
            {
                textBox.Text = value.ToString("0.00");
                if (value < 350.00m)
                {
                    MessageBox.Show("El sueldo mínimo es de 350.00");
                    textBox.Text = "350.00";
                }
            }
            else
            {
                textBox.Text = "0.00";
            }
        }
    }
}
