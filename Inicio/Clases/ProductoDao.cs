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
    internal class ProductoDao
    {


        private Conexion conexion;

        public ProductoDao(Conexion conexion)
        {
            this.conexion = conexion;
        }


        public void CargarProductos(DataGridView dataGridView)
        {
            try
            {
            
                conexion.AbrirConexion();

               
                string query = "SELECT id_producto, nombre_producto, descripccion, precio_venta, precio_compra, stock, sucursal_id, id_categoria_producto, id_marca FROM producto";

              
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion.Conexion_);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}");
            }
            finally
            {
                
                conexion.CerrarConexion();
            }
        }
        public bool Agregar(Producto producto)
        {
            bool resultado = false;

            try
            {
                conexion.AbrirConexion();

                string query = "INSERT INTO producto (nombre_producto, descripccion, precio_venta, precio_compra, stock, sucursal_id, id_categoria_producto, id_marca) " +
                               "VALUES (@nombre, @descripcion, @precioVenta, @precioCompra, @stock, @sucursalId, @idCategoriaProducto, @idMarca)";

                SqlCommand command = new SqlCommand(query, conexion.Conexion_);
                command.Parameters.AddWithValue("@nombre", producto.NombreProducto);
                command.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                command.Parameters.AddWithValue("@precioVenta", producto.PrecioVenta);  // Será 0
                command.Parameters.AddWithValue("@precioCompra", producto.PrecioCompra);  // Será 0
                command.Parameters.AddWithValue("@stock", producto.Stock);  // Será 0
                command.Parameters.AddWithValue("@sucursalId", producto.SucursalId);
                command.Parameters.AddWithValue("@idCategoriaProducto", producto.IdCategoriaProducto);
                command.Parameters.AddWithValue("@idMarca", producto.IdMarca);

                int filasAfectadas = command.ExecuteNonQuery();
                resultado = filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el producto: {ex.Message}");
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return resultado;
        }


        public DataTable CargarCategorias()
        {
            DataTable dataTable = new DataTable();

            try
            {
                conexion.AbrirConexion();

                string query = "SELECT id_categoria_producto, nombre_categoria FROM categoria_producto";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion.Conexion_);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}");
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return dataTable;
        }


        public DataTable CargarMarcas()
        {
            DataTable dataTable = new DataTable();

            try
            {
                conexion.AbrirConexion();

                string query = "SELECT id_marca, nombre FROM marca";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion.Conexion_);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las marcas: {ex.Message}");
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return dataTable;
        }

        public DataTable ObtenerProductosPorSucursalYCategoria(int idSucursal, int idCategoria)
        {
            DataTable productos = new DataTable();

            try
            {
                if (conexion.AbrirConexion())
                {
                    string query = @"
                SELECT 
                    p.id_producto,
                    p.nombre_producto,
                    p.descripccion AS descripcion,
                    p.precio_venta,
                    p.precio_compra,
                    p.stock,
                    m.nombre AS nombre_marca
                FROM producto p
                INNER JOIN marca m ON p.id_marca = m.id_marca
                WHERE p.sucursal_id = @idSucursal AND p.id_categoria_producto = @idCategoria";

                    SqlCommand cmd = new SqlCommand(query, conexion.Conexion_);
                    cmd.Parameters.AddWithValue("@idSucursal", idSucursal);
                    cmd.Parameters.AddWithValue("@idCategoria", idCategoria);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(productos);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener productos: {ex.Message}");
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return productos;
        }

        public bool ActualizarProducto(int idProducto, string nombreProducto, string descripcion, decimal precioVenta)
        {
            try
            {
                if (conexion.AbrirConexion())
                {
                    string query = @"
                UPDATE producto
                SET nombre_producto = @nombreProducto, 
                    descripccion = @descripcion, 
                    precio_venta = @precioVenta
                WHERE id_producto = @idProducto";

                    SqlCommand cmd = new SqlCommand(query, conexion.Conexion_);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    cmd.Parameters.AddWithValue("@nombreProducto", nombreProducto);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@precioVenta", precioVenta);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar el producto: {ex.Message}");
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return false;
        }


        public DataTable CargarProductosVenta(int sucursalId, int categoriaId)
        {
            DataTable productos = new DataTable();

            try
            {
                if (conexion.AbrirConexion())
                {
                    string query = @"
                SELECT 
                    p.id_producto AS ID, 
                    p.nombre_producto AS PRODUCTO, 
                    p.precio_venta AS PRECIO, 
                    p.stock AS STOCK, 
                    m.nombre  AS MARCA
                FROM producto p
                INNER JOIN marca m ON p.id_marca = m.id_marca
                WHERE (@sucursalId = 0 OR p.sucursal_id = @sucursalId)
                  AND (@categoriaId = 0 OR p.id_categoria_producto = @categoriaId) ANd p.precio_venta > 0 and p.stock >0";

                    SqlCommand cmd = new SqlCommand(query, conexion.Conexion_);
                    cmd.Parameters.AddWithValue("@sucursalId", sucursalId);
                    cmd.Parameters.AddWithValue("@categoriaId", categoriaId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(productos);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar los productos: {ex.Message}");
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return productos;
        }






    }




}
