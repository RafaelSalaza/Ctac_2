using Inicio;
using System;
using System.Data;
using System.Data.SqlClient;

public class Sueldod
{
    private Conexion conexion;

    public Sueldod(Conexion conexion)
    {
        this.conexion = conexion;
    }

    public void CalcularSueldo(int idEmpleado, decimal sueldo)
    {
        try
        {
            conexion.AbrirConexion();

            string query = "CalcularSueldo";

            using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id_empleado", idEmpleado);
                command.Parameters.AddWithValue("@sueldo", sueldo);

                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al calcular el sueldo.", ex);
        }
        finally
        {
            conexion.CerrarConexion();
        }
    }

    public void ActualizarSueldo(int idEmpleado, decimal nuevoSueldo)
    {
        try
        {
            conexion.AbrirConexion();

            string query = "ActualizarSueldo";

            using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id_empleado", idEmpleado);
                command.Parameters.AddWithValue("@nuevo_sueldo", nuevoSueldo);

                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al actualizar el sueldo.", ex);
        }
        finally
        {
            conexion.CerrarConexion();
        }
    }

    public DataTable ObtenerSueldos()
    {
        try
        {
            conexion.AbrirConexion();

            string query = "SELECT * FROM sueldo";

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conexion.Conexion_))
            {
                DataTable sueldos = new DataTable();
                adapter.Fill(sueldos);
                return sueldos;
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener los sueldos.", ex);
        }
        finally
        {
            conexion.CerrarConexion();
        }
    }
    public bool ExisteIdEmpleadoEnTablaSueldo(int idEmpleado)
    {
        string query = "SELECT COUNT(*) FROM sueldo WHERE id_empleado = @IdEmpleado";
        using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
        {
            command.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
            conexion.AbrirConexion();
            int count = (int)command.ExecuteScalar();
            conexion.CerrarConexion();
            return count > 0;
        }
    }

    public bool ExisteIdEmpleadoEnTablaEmpleado(int idEmpleado)
    {
        string query = "SELECT COUNT(*) FROM empleado WHERE id_empleado = @IdEmpleado";
        using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
        {
            command.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
            conexion.AbrirConexion();
            int count = (int)command.ExecuteScalar();
            conexion.CerrarConexion();
            return count > 0;
        }
    }

}
