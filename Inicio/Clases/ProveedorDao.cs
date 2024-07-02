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
    internal class ProveedorDao
    {

        private Conexion conexion;

        public ProveedorDao(Conexion conexion)
        {
           this.conexion = conexion;
        }

         public void Mostrar(DataGridView dataGridView)
         {
             try
             {
                 conexion.AbrirConexion();

                 string query = "SELECT id_proveedor, nombre_proveedor, correo, numero_telefono, id_direccion FROM proveedor";

                 SqlDataAdapter adapter = new SqlDataAdapter(query, conexion.Conexion_);
                 DataTable dataTable = new DataTable();
                 adapter.Fill(dataTable);

                 dataGridView.DataSource = dataTable;
             }
             catch (Exception ex)
             {
                 MessageBox.Show($"Error al mostrar los datos: {ex.Message}");
             }
             finally
             {
                 conexion.CerrarConexion();
             }
         }


        public bool Agregar(Proveedorn proveedor)
        {
            bool resultado = false;

            try
            {
                conexion.AbrirConexion();

                string query = "INSERT INTO proveedor (nombre_proveedor, correo, numero_telefono, id_direccion) " +
                               "VALUES (@nombre, @correo, @telefono, @direccion)";

                SqlCommand command = new SqlCommand(query, conexion.Conexion_);
                command.Parameters.AddWithValue("@nombre", proveedor.NombreProveedor);
                command.Parameters.AddWithValue("@correo", proveedor.Correo);
                command.Parameters.AddWithValue("@telefono", proveedor.NumeroTelefono);
                command.Parameters.AddWithValue("@direccion", proveedor.IdDireccion);

                int filasAfectadas = command.ExecuteNonQuery();
                resultado = filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                // Manejo de la excepción
                MessageBox.Show($"Error al agregar el proveedor: {ex.Message}");
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return resultado;
        }




        public bool Editar(Proveedorn proveedor)
        {
            bool resultado = false;

            try
            {
                conexion.AbrirConexion();

                string query = "UPDATE proveedor SET nombre_proveedor = @nombre, correo = @correo, numero_telefono = @telefono, id_direccion = @direccion WHERE id_proveedor = @id";

                SqlCommand command = new SqlCommand(query, conexion.Conexion_);
                command.Parameters.AddWithValue("@nombre", proveedor.NombreProveedor);
                command.Parameters.AddWithValue("@correo", proveedor.Correo);
                command.Parameters.AddWithValue("@telefono", proveedor.NumeroTelefono);
                command.Parameters.AddWithValue("@direccion", proveedor.IdDireccion);
                command.Parameters.AddWithValue("@id", proveedor.IdProveedor);

                int filasAfectadas = command.ExecuteNonQuery();
                resultado = filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar el proveedor: {ex.Message}");
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return resultado;
        }




        public DataTable Buscar(string textoBusqueda)
        {
            DataTable dataTable = new DataTable();

            try
            {
                conexion.AbrirConexion();

                string query = "SELECT id_proveedor, nombre_proveedor, correo, numero_telefono, id_direccion " +
                               "FROM proveedor " +
                               "WHERE nombre_proveedor LIKE @textoBusqueda";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion.Conexion_);
                adapter.SelectCommand.Parameters.AddWithValue("@textoBusqueda", "%" + textoBusqueda + "%");
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar los proveedores: {ex.Message}");
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return dataTable;
        }








    }
}
