using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class Marcaformcs : Form
    {

        private MarcaDao marcaDao;
        private Conexion con = new Conexion();
        private int idMarcaSeleccionada;
        public Marcaformcs()
        {
            InitializeComponent();
            marcaDao = new MarcaDao(con);


        }





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


       
        private void Marcaformcs_Load(object sender, EventArgs e)
        {
            marcaDao.ConsultarMarcas(tablaMarcas);


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {

            string nombreMarca = txtNombremarca.Text;

            if (string.IsNullOrWhiteSpace(nombreMarca))
            {
                MessageBox.Show("El nombre de la marca no puede estar vacío.");
                return;
            }

            try
            {
                marcaDao.AgregarMarca(nombreMarca);
                MessageBox.Show("La marca se ha agregado correctamente.");

                marcaDao.ActualizarTabla(tablaMarcas);
                txtNombremarca.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la marca: {ex.Message}");
            }

            txtNombremarca.Text = "";


        }

        private void botonbuscar_Click(object sender, EventArgs e)
        {
            string nombreMarca = txtBuscar.Text;

            try
            {
                DataTable dt = marcaDao.BuscarMarcasPorNombre(nombreMarca);
                tablaMarcas.Columns.Clear();
                // Asigna el resultado de la búsqueda al DataGridView
                tablaMarcas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar la marca: {ex.Message}");
            }
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txtactualizar.Text;

            if (string.IsNullOrWhiteSpace(nuevoNombre))
            {
                MessageBox.Show("El nuevo nombre de la marca no puede estar vacío.");
                return;
            }

            try
            {
                if (idMarcaSeleccionada != 0)
                {
                    marcaDao.ActualizarMarca(idMarcaSeleccionada, nuevoNombre);
                    MessageBox.Show("El nombre de la marca se ha actualizado correctamente.");

                    marcaDao.ActualizarTabla(tablaMarcas);
                    txtactualizar.Text = "";
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una marca antes de actualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el nombre de la marca: {ex.Message}");
            }

        }

        private void tablaMarcas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si se hizo clic en una celda válida (no en el encabezado de columna)
            if (e.RowIndex >= 0)
            {
                // Obtiene el valor de la celda correspondiente a la columna del ID de la marca
                DataGridViewRow row = tablaMarcas.Rows[e.RowIndex];
                idMarcaSeleccionada = Convert.ToInt32(row.Cells["IdMarca"].Value);
            }

        }




    }
}