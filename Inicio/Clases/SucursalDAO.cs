using Inicio;
using System.Data.SqlClient;
using System;
using System.Data;

public class SucursalDAO
{
    private Conexion conexion;

    public SucursalDAO(Conexion conexion)
    {
        this.conexion = conexion;
    }
    public DataTable ObtenerSucursales()
    {
        try
        {
            conexion.AbrirConexion();

            string query = "SELECT * FROM sucursal";

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
    public void CrearSucursal(int idDireccion, int? idCuenta, string nombreSucursal, string horaApertura, string horaCierre)
    {
        if (idCuenta.HasValue && CuentaAsignadaAOtraSucursal(idCuenta.Value))
        {
            throw new Exception("La cuenta ya está asignada a otra sucursal.");
        }

        try
        {
            conexion.AbrirConexion();

            string query = "INSERT INTO sucursal (id_direccion, id_cuenta, nombre_sucursal, hora_apertura, hora_cierre) " +
                           "VALUES (@IdDireccion, @IdCuenta, @NombreSucursal, @HoraApertura, @HoraCierre)";

            using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
            {
                command.Parameters.AddWithValue("@IdDireccion", idDireccion);
                command.Parameters.AddWithValue("@IdCuenta", (object)idCuenta ?? DBNull.Value);
                command.Parameters.AddWithValue("@NombreSucursal", nombreSucursal);
                command.Parameters.AddWithValue("@HoraApertura", horaApertura);
                command.Parameters.AddWithValue("@HoraCierre", horaCierre);

                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al crear la sucursal.", ex);
        }
        finally
        {
            conexion.CerrarConexion();
        }
    }

    public void ActualizarSucursal(int idSucursal, int idDireccion, int? idCuenta, string nombreSucursal, string horaApertura, string horaCierre)
    {
        if (idCuenta.HasValue && CuentaAsignadaAOtraSucursal(idCuenta.Value, idSucursal))
        {
            throw new Exception("La cuenta ya está asignada a otra sucursal.");
        }

        try
        {
            conexion.AbrirConexion();

            string query = "UPDATE sucursal SET id_direccion = @IdDireccion, id_cuenta = @IdCuenta, nombre_sucursal = @NombreSucursal, " +
                           "hora_apertura = @HoraApertura, hora_cierre = @HoraCierre WHERE id_sucursal = @IdSucursal";

            using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
            {
                command.Parameters.AddWithValue("@IdDireccion", idDireccion);
                command.Parameters.AddWithValue("@IdCuenta", (object)idCuenta ?? DBNull.Value);
                command.Parameters.AddWithValue("@NombreSucursal", nombreSucursal);
                command.Parameters.AddWithValue("@HoraApertura", horaApertura);
                command.Parameters.AddWithValue("@HoraCierre", horaCierre);
                command.Parameters.AddWithValue("@IdSucursal", idSucursal);

                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al actualizar la sucursal.", ex);
        }
        finally
        {
            conexion.CerrarConexion();
        }
    }

    public bool ExisteSucursal(int idSucursal)
    {
        try
        {
            conexion.AbrirConexion();

            string query = "SELECT COUNT(*) FROM sucursal WHERE id_sucursal = @IdSucursal";

            using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
            {
                command.Parameters.AddWithValue("@IdSucursal", idSucursal);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al verificar la existencia de la sucursal.", ex);
        }
        finally
        {
            conexion.CerrarConexion();
        }
    }

    public bool ExisteDireccion(int idDireccion)
    {
        try
        {
            conexion.AbrirConexion();

            string query = "SELECT COUNT(*) FROM direcciones WHERE id_direccion = @IdDireccion";

            using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
            {
                command.Parameters.AddWithValue("@IdDireccion", idDireccion);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al verificar la existencia de la dirección.", ex);
        }
        finally
        {
            conexion.CerrarConexion();
        }
    }

    public bool ExisteCuenta(int idCuenta)
    {
        try
        {
            conexion.AbrirConexion();

            string query = "SELECT COUNT(*) FROM cuenta WHERE id_cuenta = @IdCuenta";

            using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
            {
                command.Parameters.AddWithValue("@IdCuenta", idCuenta);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al verificar la existencia de la cuenta.", ex);
        }
        finally
        {
            conexion.CerrarConexion();
        }
    }

    public bool CuentaAsignadaAOtraSucursal(int idCuenta, int? idSucursalActual = null)
    {
        try
        {
            conexion.AbrirConexion();

            string query = idSucursalActual.HasValue ?
                "SELECT COUNT(*) FROM sucursal WHERE id_cuenta = @IdCuenta AND id_sucursal != @IdSucursal" :
                "SELECT COUNT(*) FROM sucursal WHERE id_cuenta = @IdCuenta";

            using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
            {
                command.Parameters.AddWithValue("@IdCuenta", idCuenta);
                if (idSucursalActual.HasValue)
                {
                    command.Parameters.AddWithValue("@IdSucursal", idSucursalActual.Value);
                }
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al verificar si la cuenta está asignada a otra sucursal.", ex);
        }
        finally
        {
            conexion.CerrarConexion();
        }
    }
}
