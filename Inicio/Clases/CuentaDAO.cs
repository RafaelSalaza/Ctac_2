using Inicio;
using System;
using System.Data;
using System.Data.SqlClient;

public class CuentaDAO
{
    private Conexion conexion;

    public CuentaDAO(Conexion conexion)
    {
        this.conexion = conexion;
    }

    public bool ExisteNumeroCuenta(string numeroCuenta)
    {
        try
        {
            conexion.AbrirConexion();

            string query = "SELECT COUNT(*) FROM cuenta WHERE numero_cuenta = @NumeroCuenta";
            using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
            {
                command.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al verificar si existe el número de cuenta.", ex);
        }
        finally
        {
            conexion.CerrarConexion();
        }
    }

    public void CrearCuenta(string numeroCuenta, string banco, int idCategoriaCuenta)
    {
        if (string.IsNullOrEmpty(numeroCuenta) || string.IsNullOrEmpty(banco))
        {
            throw new ArgumentException("Los campos número de cuenta y banco no pueden estar vacíos.");
        }

        if (ExisteNumeroCuenta(numeroCuenta))
        {
            throw new InvalidOperationException("Ya existe una cuenta con ese número.");
        }

        try
        {
            conexion.AbrirConexion();

            string query = @"
            INSERT INTO cuenta (numero_cuenta, banco, id_categoria_cuenta)
            VALUES (@NumeroCuenta, @Banco, @IdCategoriaCuenta)";

            using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
            {
                command.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);
                command.Parameters.AddWithValue("@Banco", banco);
                command.Parameters.AddWithValue("@IdCategoriaCuenta", idCategoriaCuenta);

                command.ExecuteNonQuery();
            }
        }
        catch (SqlException sqlEx)
        {
            throw new Exception("Error SQL al crear la cuenta.", sqlEx);
        }
        catch (Exception ex)
        {
            throw new Exception("Error al crear la cuenta.", ex);
        }
        finally
        {
            conexion.CerrarConexion();
        }
    }

    public DataTable ObtenerCategoriasCuenta()
    {
        try
        {
            conexion.AbrirConexion();

            string query = "SELECT id_categoria_cuenta, tipo_cuenta FROM categoria_cuenta";

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conexion.Conexion_))
            {
                DataTable categorias = new DataTable();
                adapter.Fill(categorias);
                return categorias;
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener las categorías de cuenta.", ex);
        }
        finally
        {
            conexion.CerrarConexion();
        }
    }

    public DataTable ObtenerCuentas()
    {
        try
        {
            conexion.AbrirConexion();

            string query = "SELECT * FROM cuenta";

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conexion.Conexion_))
            {
                DataTable cuentas = new DataTable();
                adapter.Fill(cuentas);
                return cuentas;
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener las cuentas.", ex);
        }
        finally
        {
            conexion.CerrarConexion();
        }
    }

    public void ActualizarCuenta(int idCuenta, string numeroCuenta, string banco, int idCategoriaCuenta)
    {
        try
        {
            conexion.AbrirConexion();

            string query = "UPDATE cuenta SET numero_cuenta = @NumeroCuenta, banco = @Banco, id_categoria_cuenta = @IdCategoriaCuenta WHERE id_cuenta = @IdCuenta";

            using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
            {
                command.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);
                command.Parameters.AddWithValue("@Banco", banco);
                command.Parameters.AddWithValue("@IdCategoriaCuenta", idCategoriaCuenta);
                command.Parameters.AddWithValue("@IdCuenta", idCuenta);

                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al actualizar la cuenta.", ex);
        }
        finally
        {
            conexion.CerrarConexion();
        }
    }
    public int ObtenerUltimoIdCuenta()
    {
        try
        {
            conexion.AbrirConexion();

            string query = "SELECT MAX(id_cuenta) FROM cuenta";

            using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
            {
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener el último ID de cuenta.", ex);
        }
        finally
        {
            conexion.CerrarConexion();
        }
    }

}
