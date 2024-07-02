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
    internal class VentaDao
    {
        private readonly Conexion Conexion;

        public VentaDao(Conexion con)
        {
            this.Conexion = con;
        }


        public bool InsertarVentaConDetalles(Venta venta)
        {
            try
            {
                if (Conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("InsertarVentaConDetalles", Conexion.Conexion_))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        if (venta.Idcliente.HasValue)
                        {
                            cmd.Parameters.AddWithValue("@id_cliente", venta.Idcliente.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@id_cliente", DBNull.Value);
                        }
                        cmd.Parameters.AddWithValue("@id_usuario", venta.IdUsuario);
                        cmd.Parameters.AddWithValue("@id_tipo_pago", venta.IdTipoPago);
                        cmd.Parameters.AddWithValue("@monto_envio", venta.MontoEnvio);
                        cmd.Parameters.AddWithValue("@id_sucursal", venta.IdSucursal);

                        DataTable detallesTable = CreateDetallesTable(venta.Detalles);

                        SqlParameter detallesParam = cmd.Parameters.AddWithValue("@detalles", detallesTable);
                        detallesParam.SqlDbType = SqlDbType.Structured;
                        detallesParam.TypeName = "dbo.DetalleVentaType";

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar la venta: {ex.Message}");
                return false;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }

        /*public bool InsertarVentaConDetalles(Venta venta)
        {
            try
            {
                if (Conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("InsertarVentaConDetalles", Conexion.Conexion_))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_cliente", venta.Idcliente);
                        cmd.Parameters.AddWithValue("@id_usuario", venta.IdUsuario);
                        cmd.Parameters.AddWithValue("@id_tipo_pago", venta.IdTipoPago);
                        cmd.Parameters.AddWithValue("@monto_envio", venta.MontoEnvio);
                        cmd.Parameters.AddWithValue("@id_sucursal", venta.IdSucursal);

                        // Create a DataTable for @detalles
                        DataTable detallesTable = CreateDetallesTable(venta.Detalles);

                        SqlParameter detallesParam = cmd.Parameters.AddWithValue("@detalles", detallesTable);
                        detallesParam.SqlDbType = SqlDbType.Structured;
                        detallesParam.TypeName = "dbo.DetalleVentaType";

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine($"Error al insertar la venta: {ex.Message}");
                return false;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }*/

        private DataTable CreateDetallesTable(List<DetalleVenta> detalles)
        {
            DataTable table = new DataTable();
            table.Columns.Add("id_producto", typeof(int));
            table.Columns.Add("cantidad", typeof(int));
            table.Columns.Add("precio", typeof(decimal));
            table.Columns.Add("subtotal", typeof(decimal));

            foreach (var detalle in detalles)
            {
                table.Rows.Add(detalle.IdProducto, detalle.Cantidad, detalle.Precio, detalle.Subtotal);
            }

            return table;


        }

        public DataTable CargarTiposPago()
        {
            DataTable dataTable = new DataTable();

            try
            {
                Conexion.AbrirConexion();

                string query = "SELECT id_tipo_pago, nombre FROM tipo_pago";

                SqlDataAdapter adapter = new SqlDataAdapter(query, Conexion.Conexion_);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}");
            }
            finally
            {
                Conexion.CerrarConexion();
            }

            return dataTable;
        }



        public bool AgregarEnvio(int idVenta, decimal montoEnvio)
        {
            try
            {
                if (Conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("AgregarEnvio", Conexion.Conexion_))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_venta", idVenta);
                        cmd.Parameters.AddWithValue("@monto_envio", montoEnvio);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar el envío: {ex.Message}");
                return false;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }


        public DataTable ConsultarHistorialVentas(int idSucursal, DateTime fechaInicio, DateTime fechaFin, int? idUsuario = null)
        {
            DataTable historialVentas = new DataTable();

            try
            {
                if (Conexion.AbrirConexion())
                {
                    string query = @"
            SELECT 
                v.id_venta, 
                e.nombre + ' ' + e.apellido AS nombre_completo_empleado, 
                v.fecha AS fecha_venta, 
                c.nombre + ' ' + c.apellido AS nombre_completo_cliente, 
                v.monto_envio, 
                v.monto_total, 
                s.nombre_sucursal
            FROM venta v
            Inner JOIN cliente c ON v.id_cliente = c.id_cliente
            INNER JOIN usuario u ON v.id_usuario = u.id_usuario
            INNER JOIN empleado e ON u.id_usuario = e.id_usuario
            INNER JOIN sucursal s ON v.id_sucursal = s.id_sucursal
            WHERE s.id_sucursal = @idSucursal 
            AND v.fecha BETWEEN @fechaInicio AND @fechaFin";

                    if (idUsuario.HasValue)
                    {
                        query += " AND v.id_usuario = @idUsuario";
                    }

                    SqlCommand cmd = new SqlCommand(query, Conexion.Conexion_);
                    cmd.Parameters.AddWithValue("@idSucursal", idSucursal);
                    cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

                    if (idUsuario.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@idUsuario", idUsuario.Value);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(historialVentas);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar el historial de ventas: {ex.Message}");
            }
            finally
            {
                Conexion.CerrarConexion();
            }

            return historialVentas;
        }

       
    }
}
