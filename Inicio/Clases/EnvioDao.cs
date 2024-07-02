using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    internal class EnvioDao
    {


        private readonly Conexion con;

        public EnvioDao(Conexion conexion)
        {
            this.con = conexion;
        }

        public DataTable CargarEnviosNoEntregados(int idSucursal)
        {
            DataTable enviosNoEntregados = new DataTable();

            try
            {
                if (con.AbrirConexion())
                {
                    string query = @"
                   SELECT
    e.id_envio,
    v.id_venta,
    COALESCE(c.nombre + ' ' + c.apellido, 'Cliente sin nombre') AS nombre_cliente,
    v.fecha,
    COALESCE(v.monto_envio, 0) AS monto_envio
FROM
    envio e
    INNER JOIN venta v ON e.id_venta = v.id_venta
    LEFT JOIN cliente c ON v.id_cliente = c.id_cliente
WHERE
    v.id_sucursal = @idSucursal
    AND e.entrega IS NULL
                    "; 

                    SqlCommand cmd = new SqlCommand(query, con.Conexion_);
                    cmd.Parameters.AddWithValue("@idSucursal", idSucursal);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(enviosNoEntregados);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar los envíos no entregados: {ex.Message}");
            }
            finally
            {
                con.CerrarConexion();
            }

            return enviosNoEntregados;
        }


        public DataTable CargarConductores(int idSucursal)
        {
            DataTable conductores = new DataTable();

            try
            {
                if (con.AbrirConexion())
                {
                    string query = @"
                    SELECT 
                        e.id_empleado, 
                        e.nombre + ' ' + e.apellido AS nombre_completo 
                    FROM empleado e
                    INNER JOIN cat_empleado ce ON e.id_cat_empleado = ce.id_cat_empleado
                    WHERE ce.cat_empleado = 'Conductor'
                    AND e.id_sucursal = @idSucursal";

                    SqlCommand cmd = new SqlCommand(query, con.Conexion_);
                    cmd.Parameters.AddWithValue("@idSucursal", idSucursal);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(conductores);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar los conductores: {ex.Message}");
            }
            finally
            {
                con.CerrarConexion();
            }

            return conductores;
        }

        public DataTable CargarVehiculos(int idSucursal)
        {
            DataTable vehiculos = new DataTable();

            try
            {
                if (con.AbrirConexion())
                {
                    string query = @"
                    SELECT 
                        id_vehiculo, 
                        placa + ' - ' + descripcion AS descripcion_vehiculo 
                    FROM vehiculo
                    WHERE id_sucursal = @idSucursal";

                    SqlCommand cmd = new SqlCommand(query, con.Conexion_);
                    cmd.Parameters.AddWithValue("@idSucursal", idSucursal);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(vehiculos);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar los vehículos: {ex.Message}");
            }
            finally
            {
                con.CerrarConexion();
            }

            return vehiculos;
        }

        public bool ActualizarEnvio(int idEnvio, int idEmpleado, int idVehiculo)
        {
            try
            {
                if (con.AbrirConexion())
                {
                    string query = @"
                    UPDATE envio
                    SET id_empleado = @idEmpleado,
                        id_vehiculo = @idVehiculo,
                        entrega = 1
                    WHERE id_envio = @idEnvio";

                    SqlCommand cmd = new SqlCommand(query, con.Conexion_);
                    cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    cmd.Parameters.AddWithValue("@idVehiculo", idVehiculo);
                    cmd.Parameters.AddWithValue("@idEnvio", idEnvio);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar el envío: {ex.Message}");
            }
            finally
            {
                con.CerrarConexion();
            }

            return false;
        }

        public DataTable CargarEnviosEntregados(int idSucursal)
        {
            DataTable enviosEntregados = new DataTable();

            try
            {
                if (con.AbrirConexion())
                {
                    string query = @"
                    SELECT 
                        e.id_envio, 
                        v.id_venta, 
                        c.nombre + ' ' + c.apellido AS nombre_cliente, 
                        v.fecha, 
                        v.monto_envio
                    FROM envio e
                    INNER JOIN venta v ON e.id_venta = v.id_venta
                    LEFT JOIN cliente c ON v.id_cliente = c.id_cliente
                    WHERE e.entrega = 1
                    AND v.id_sucursal = @idSucursal";

                    SqlCommand cmd = new SqlCommand(query, con.Conexion_);
                    cmd.Parameters.AddWithValue("@idSucursal", idSucursal);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(enviosEntregados);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar los envíos entregados: {ex.Message}");
            }
            finally
            {
                con.CerrarConexion();
            }

            return enviosEntregados;
        }





    }
}
