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
    internal class CompraDao
    {


        private readonly Conexion con;

        public CompraDao(Conexion con)
        {
            this.con = con;
        }

        public bool InsertarCompraConDetalles(Compra compra)
        {
            try
            {
                if (con.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("InsertarCompraConDetalles", con.Conexion_))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_proveedor", compra.IdProveedor);
                        cmd.Parameters.AddWithValue("@id_usuario", compra.IdUsuario);
                        cmd.Parameters.AddWithValue("@id_tipo_pago", compra.IdTipoPago);

                        // Create a DataTable for @detalles
                        DataTable detallesTable = CreateDetallesTable(compra.Detalles);

                        SqlParameter detallesParam = cmd.Parameters.AddWithValue("@detalles", detallesTable);
                        detallesParam.SqlDbType = SqlDbType.Structured;
                        detallesParam.TypeName = "dbo.DetalleCompraType";

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine($"Error al insertar la compra: {ex.Message}");
                return false;
            }
            finally
            {
                con.CerrarConexion();
            }
        }

        private DataTable CreateDetallesTable(List<DetalleCompra> detalles)
        {
            DataTable table = new DataTable();
            table.Columns.Add("id_producto", typeof(int));
            table.Columns.Add("cantidad", typeof(int));
            table.Columns.Add("precio_compra", typeof(decimal));
            table.Columns.Add("subtotal", typeof(decimal));

            foreach (var detalle in detalles)
            {
                table.Rows.Add(detalle.IdProducto, detalle.Cantidad, detalle.PrecioCompra, detalle.Subtotal);
            }

            return table;
        }




        public DataTable CargarCategorias()
        {
            DataTable dataTable = new DataTable();

            try
            {
                con.AbrirConexion();

                string query = "SELECT id_categoria_producto, nombre_categoria FROM categoria_producto";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con.Conexion_);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}");
            }
            finally
            {
                con.CerrarConexion();
            }

            return dataTable;
        }




        public DataTable CargarProveedor()
        {
            DataTable dataTable = new DataTable();

            try
            {
                con.AbrirConexion();

                string query = "SELECT id_proveedor,nombre_proveedor FROM proveedor";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con.Conexion_);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los proveedores: {ex.Message}");
            }
            finally
            {
                con.CerrarConexion();
            }

            return dataTable;
        }



        public DataTable CargarTiposPago()
        {
            DataTable dataTable = new DataTable();

            try
            {
                con.AbrirConexion();

                string query = "SELECT id_tipo_pago, nombre FROM tipo_pago";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con.Conexion_);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}");
            }
            finally
            {
                con.CerrarConexion();
            }

            return dataTable;
        }


        public DataTable ObtenerProductosPorCategoria(int idCategoria)
        {
            DataTable dataTable = new DataTable();

            try
            {
                con.AbrirConexion();
                string query = "SELECT id_producto AS ID, nombre_producto AS PRODUCTO, stock AS STOCK FROM producto WHERE id_categoria_producto = @idCategoria";
                SqlCommand cmd = new SqlCommand(query, con.Conexion_);
                cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos: {ex.Message}");
            }
            finally
            {
                con.CerrarConexion();
            }

            return dataTable;
        }



        public DataTable CargarSucursales()
        {
            DataTable sucursales = new DataTable();

            try
            {
                if (con.AbrirConexion())
                {
                    string query = "SELECT id_sucursal, nombre_sucursal FROM sucursal";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con.Conexion_);
                    adapter.Fill(sucursales);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar las sucursales: {ex.Message}");
            }
            finally
            {
                con.CerrarConexion();
            }

            return sucursales;
        }


        public DataTable CargarUsuariosPorSucursal(int idSucursal)
        {
            DataTable usuarios = new DataTable();

            try
            {
                if (con.AbrirConexion())
                {
                    string query = @"
                SELECT u.id_usuario, u.nombre_usuario 
                FROM usuario u
                INNER JOIN empleado e ON u.id_usuario = e.id_usuario
                WHERE e.id_sucursal = @idSucursal";
                    SqlCommand cmd = new SqlCommand(query, con.Conexion_);
                    cmd.Parameters.AddWithValue("@idSucursal", idSucursal);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(usuarios);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar los usuarios: {ex.Message}");
            }
            finally
            {
                con.CerrarConexion();
            }

            return usuarios;
        }



        public DataTable ConsultarHistorialCompras(int idSucursal, DateTime fechaInicio, DateTime fechaFin, int? idUsuario = null)
        {
            DataTable historialCompras = new DataTable();

            try
            {
                if (con.AbrirConexion())
                {
                    string query = @"
                SELECT 
                    c.id_compra, 
                    p.nombre_proveedor, 
                    c.fecha_compra, 
                    c.total, 
                    e.nombre + ' ' + e.apellido AS nombre_completo_empleado, 
                    tp.nombre AS nombre_tipo_pago, 
                    s.nombre_sucursal
                FROM compra c
                INNER JOIN proveedor p ON c.id_proveedor = p.id_proveedor
                INNER JOIN usuario u ON c.id_usuario = u.id_usuario
                INNER JOIN empleado e ON u.id_usuario = e.id_usuario
                INNER JOIN tipo_pago tp ON c.id_tipo_pago = tp.id_tipo_pago
                INNER JOIN sucursal s ON e.id_sucursal = s.id_sucursal
                WHERE s.id_sucursal = @idSucursal 
                AND c.fecha_compra BETWEEN @fechaInicio AND @fechaFin";

                    if (idUsuario.HasValue)
                    {
                        query += " AND c.id_usuario = @idUsuario";
                    }

                    SqlCommand cmd = new SqlCommand(query, con.Conexion_);
                    cmd.Parameters.AddWithValue("@idSucursal", idSucursal);
                    cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

                    if (idUsuario.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@idUsuario", idUsuario.Value);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(historialCompras);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar el historial de compras: {ex.Message}");
            }
            finally
            {
                con.CerrarConexion();
            }

            return historialCompras;
        }






    }
}
