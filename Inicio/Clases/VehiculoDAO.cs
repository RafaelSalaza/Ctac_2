using Inicio;
using System;
using System.Data;
using System.Data.SqlClient;

public class VehiculoDAO
{
    private Conexion conexion;

    public VehiculoDAO(Conexion conexion)
    {
        this.conexion = conexion;
    }

    public void CrearVehiculo(int idCategoriaVehiculo, string placa, string descripcion, string anio, int idSucursal)
    {
        try
        {
            conexion.AbrirConexion();

            string query = "INSERT INTO vehiculo (id_categoria_vehiculo, placa, descripcion, anio, id_sucursal) VALUES (@IdCategoriaVehiculo, @Placa, @Descripcion, @Anio, @IdSucursal)";

            using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
            {
                command.Parameters.AddWithValue("@IdCategoriaVehiculo", idCategoriaVehiculo);
                command.Parameters.AddWithValue("@Placa", placa);
                command.Parameters.AddWithValue("@Descripcion", descripcion);
                command.Parameters.AddWithValue("@Anio", anio);
                command.Parameters.AddWithValue("@IdSucursal", idSucursal);

                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al crear el vehículo.", ex);
        }
        finally
        {
            conexion.CerrarConexion();
        }
    }

    public DataTable ObtenerCategoriasVehiculo()
    {
        try
        {
            conexion.AbrirConexion();

            string query = "SELECT id_categoria_vehiculo, tipo FROM categoria_vehiculo";

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conexion.Conexion_))
            {
                DataTable categorias = new DataTable();
                adapter.Fill(categorias);
                return categorias;
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener las categorías de vehículos.", ex);
        }
        finally
        {
            conexion.CerrarConexion();
        }
    }

    public DataTable ObtenerSucursales()
    {
        try
        {
            conexion.AbrirConexion();

            string query = "SELECT id_sucursal, nombre_sucursal FROM sucursal";

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conexion.Conexion_))
            {
                DataTable sucursales = new DataTable();
                adapter.Fill(sucursales);
                return sucursales;
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener las sucursales.", ex);
        }
        finally
        {
            conexion.CerrarConexion();
        }
    }

    public DataTable ObtenerVehiculos()
    {
        try
        {
            conexion.AbrirConexion();

            string query = "SELECT * FROM vehiculo";

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conexion.Conexion_))
            {
                DataTable vehiculos = new DataTable();
                adapter.Fill(vehiculos);
                return vehiculos;
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener los vehículos.", ex);
        }
        finally
        {
            conexion.CerrarConexion();
        }
    }

    public void ActualizarVehiculo(int idVehiculo, int idCategoriaVehiculo, string placa, string descripcion, string anio, int idSucursal)
    {
        try
        {
            conexion.AbrirConexion();

            string query = "UPDATE vehiculo SET id_categoria_vehiculo = @IdCategoriaVehiculo, placa = @Placa, descripcion = @Descripcion, anio = @Anio, id_sucursal = @IdSucursal WHERE id_vehiculo = @IdVehiculo";

            using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
            {
                command.Parameters.AddWithValue("@IdCategoriaVehiculo", idCategoriaVehiculo);
                command.Parameters.AddWithValue("@Placa", placa);
                command.Parameters.AddWithValue("@Descripcion", descripcion);
                command.Parameters.AddWithValue("@Anio", anio);
                command.Parameters.AddWithValue("@IdSucursal", idSucursal);
                command.Parameters.AddWithValue("@IdVehiculo", idVehiculo);

                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al actualizar el vehículo.", ex);
        }
        finally
        {
            conexion.CerrarConexion();
        }
    }
}
