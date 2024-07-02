using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    internal class MarcaDao
    {

        private Conexion con;

        public MarcaDao(Conexion conexion)
        {
            this.con = conexion;
        }

        /* public void ConsultarMarcas(DataGridView dataGridView)
         {
             try
             {
                 conexion.AbrirConexion();

                 string query = "SELECT * FROM marca";
                 SqlDataAdapter adapter = new SqlDataAdapter(query, conexion.Conexion_);
                 DataTable dt = new DataTable();
                 adapter.Fill(dt);

                 dataGridView.DataSource = dt;
             }
             finally
             {
                 conexion.CerrarConexion();
             }
         }
        */
        public void ConsultarMarcas(DataGridView dataGridView)
        {
            try
            {
                con.AbrirConexion();

                string query = "SELECT id_marca, nombre FROM marca";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con.Conexion_);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Limpiar las columnas existentes en el DataGridView
                dataGridView.Columns.Clear();

                // Agregar manualmente las columnas al DataGridView
                dataGridView.Columns.Add("IdMarca", "ID");
                dataGridView.Columns.Add("Nombre", "Nombre");

                // Asignar los datos del DataTable al DataGridView
                foreach (DataRow row in dt.Rows)
                {
                    int index = dataGridView.Rows.Add();
                    dataGridView.Rows[index].Cells["IdMarca"].Value = row["id_marca"];
                    dataGridView.Rows[index].Cells["Nombre"].Value = row["nombre"];
                }
            }
            finally
            {
                con.CerrarConexion();
            }
        }

        public void AgregarMarca(string nombre)
        {
            try
            {
                con.AbrirConexion();

                string query = "INSERT INTO marca (nombre) VALUES (@Nombre)";
                SqlCommand command = new SqlCommand(query, con.Conexion_);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.ExecuteNonQuery();
            }
            finally
            {
                con.CerrarConexion();
            }
        }



        public void ActualizarTabla(DataGridView dataGridView)
        {
            // Llama al método ConsultarMarcas para volver a cargar los datos en el DataGridView
            ConsultarMarcas(dataGridView);
        }


        public DataTable BuscarMarcasPorNombre(string nombre)
        {
            DataTable dt = new DataTable();

            try
            {
                con.AbrirConexion();

                string query = "SELECT id_marca, nombre FROM marca WHERE nombre LIKE @Nombre";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con.Conexion_);
                adapter.SelectCommand.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");
                adapter.Fill(dt);
            }
            finally
            {
                con.CerrarConexion();
            }

            return dt;
        }

        public void ActualizarMarca(int idMarca, string nuevoNombre)
        {
            try
            {
                con.AbrirConexion();

                string query = "UPDATE marca SET nombre = @NuevoNombre WHERE id_marca = @IdMarca";
                SqlCommand command = new SqlCommand(query, con.Conexion_);
                command.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
                command.Parameters.AddWithValue("@IdMarca", idMarca);
                command.ExecuteNonQuery();
            }
            finally
            {
                con.CerrarConexion();
            }
        }

    }
}
