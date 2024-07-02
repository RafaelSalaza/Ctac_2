using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio.Formularios
{
    public partial class AgregarSucursal : Form
    {
        private SucursalDAO sucursalDAO;

        public AgregarSucursal()
        {
            InitializeComponent();

            var conexion = new Conexion();
            sucursalDAO = new SucursalDAO(conexion); ;

            CargarSucursales();

            dgvSucursal.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            dgvSucursal.AllowUserToAddRows = false;
        }

        private bool ValidarHora(string hora)
        {
            string pattern = @"^(0?[1-9]|1[0-2]):[0-5][0-9]\s[APap][Mm]$";
            return Regex.IsMatch(hora, pattern);
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtIdDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtHoraApertura.Text) ||
                string.IsNullOrWhiteSpace(txtHoraCierre.Text))
            {
                MessageBox.Show("Por favor completa todos los campos obligatorios.");
                return false;
            }

            if (!ValidarHora(txtHoraApertura.Text))
            {
                MessageBox.Show("La hora de apertura debe estar en formato hh:mm AM/PM.");
                return false;
            }

            if (!ValidarHora(txtHoraCierre.Text))
            {
                MessageBox.Show("La hora de cierre debe estar en formato hh:mm AM/PM.");
                return false;
            }

            return true;
        }


        private void CargarSucursales()
        {
            try
            {
                DataTable sucursales = sucursalDAO.ObtenerSucursales();
                dgvSucursal.DataSource = sucursales;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las sucursales: " + ex.Message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                int idDireccion = int.Parse(txtIdDireccion.Text);
                int? idCuenta = string.IsNullOrEmpty(txtCuenta.Text) ? (int?)null : int.Parse(txtCuenta.Text);
                string nombreSucursal = txtNombre.Text;
                string horaApertura = txtHoraApertura.Text;
                string horaCierre = txtHoraCierre.Text;

                if (!sucursalDAO.ExisteDireccion(idDireccion))
                {
                    MessageBox.Show("La dirección no existe.");
                    return;
                }

                if (idCuenta.HasValue && !sucursalDAO.ExisteCuenta(idCuenta.Value))
                {
                    MessageBox.Show("La cuenta no existe.");
                    return;
                }

                try
                {
                    sucursalDAO.CrearSucursal(idDireccion, idCuenta, nombreSucursal, horaApertura, horaCierre);
                    MessageBox.Show("Sucursal agregada exitosamente.");
                    CargarSucursales();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar la sucursal: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvSucursal.CurrentRow != null)
            {
                if (ValidarCampos())
                {
                    DataGridViewRow row = dgvSucursal.CurrentRow;
                    int idSucursal = Convert.ToInt32(row.Cells["id_sucursal"].Value);
                    int idDireccion = int.Parse(txtIdDireccion.Text);
                    int? idCuenta = string.IsNullOrEmpty(txtCuenta.Text) ? (int?)null : int.Parse(txtCuenta.Text);
                    string nombreSucursal = txtNombre.Text;
                    string horaApertura = txtHoraApertura.Text;
                    string horaCierre = txtHoraCierre.Text;

                    if (!sucursalDAO.ExisteDireccion(idDireccion))
                    {
                        MessageBox.Show("La dirección no existe.");
                        return;
                    }

                    if (idCuenta.HasValue && !sucursalDAO.ExisteCuenta(idCuenta.Value))
                    {
                        MessageBox.Show("La cuenta no existe.");
                        return;
                    }

                    try
                    {
                        sucursalDAO.ActualizarSucursal(idSucursal, idDireccion, idCuenta, nombreSucursal, horaApertura, horaCierre);
                        MessageBox.Show("Sucursal actualizada exitosamente.");
                        CargarSucursales();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar la sucursal: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una sucursal para editar.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSucursal.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DataGridViewRow row = dgvSucursal.Rows[e.RowIndex];

                int idDireccion = Convert.ToInt32(row.Cells["id_direccion"].Value);
                int? idCuenta = row.Cells["id_cuenta"].Value != DBNull.Value ? (int?)Convert.ToInt32(row.Cells["id_cuenta"].Value) : null;
                string nombreSucursal = row.Cells["nombre_sucursal"].Value.ToString();
                string horaApertura = row.Cells["hora_apertura"].Value.ToString();
                string horaCierre = row.Cells["hora_cierre"].Value.ToString();

                txtIdDireccion.Text = idDireccion.ToString();
                txtCuenta.Text = idCuenta.HasValue ? idCuenta.ToString() : string.Empty;
                txtNombre.Text = nombreSucursal;
                txtHoraApertura.Text = horaApertura;
                txtHoraCierre.Text = horaCierre;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            crearDireccion crearDireccionForm = new crearDireccion();
            crearDireccionForm.DireccionCreada += (idDireccion) =>
            {
                this.txtIdDireccion.Text = idDireccion.ToString();
            };
            crearDireccionForm.ShowDialog();
        }
    }
    
    
}
