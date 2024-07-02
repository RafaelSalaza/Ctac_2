using System.Data.SqlClient;
using System.Data;
using System;

namespace Inicio
{
    internal class EmpleadoDAO
    {
        private Conexion conexion;

        public EmpleadoDAO(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void CrearEmpleado(string nombre, string apellido, string dui, string direccion, int idCatEmpleado, int idUsuario, int? idCuenta, int idSucursal)
        {
            try
            {
                conexion.AbrirConexion();

                string query = @"
            INSERT INTO empleado (nombre, apellido, dui, direccion, id_cat_empleado, id_usuario, id_cuenta, id_sucursal)
            VALUES (@Nombre, @Apellido, @Dui, @Direccion, @IdCatEmpleado, @IdUsuario, @IdCuenta, @IdSucursal)";

                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Dui", dui);
                    command.Parameters.AddWithValue("@Direccion", direccion);
                    command.Parameters.AddWithValue("@IdCatEmpleado", idCatEmpleado);
                    command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    command.Parameters.AddWithValue("@IdSucursal", idSucursal);

                    if (idCuenta.HasValue)
                    {
                        command.Parameters.AddWithValue("@IdCuenta", idCuenta.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@IdCuenta", DBNull.Value);
                    }

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                // Capturar errores específicos de SQL
                throw new Exception("Error SQL al crear el empleado.", sqlEx);

            }
            catch (Exception ex)
            {
                // Capturar otras excepciones
                throw new Exception("Error al crear el empleado.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }





        public DataTable ObtenerCategoriasEmpleado()
        {
            DataTable categorias = new DataTable();

            try
            {
                conexion.AbrirConexion();

                string query = "SELECT id_cat_empleado, cat_empleado FROM cat_empleado";

                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        categorias.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las categorías de empleados.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return categorias;
        }

        public DataTable ObtenerSucursales()
        {
            DataTable sucursales = new DataTable();

            try
            {
                conexion.AbrirConexion();

                string query = "SELECT id_sucursal, nombre_sucursal FROM sucursal";

                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        sucursales.Load(reader);
                    }
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

            return sucursales;
        }

        public DataTable ObtenerEmpleados()
        {
            DataTable empleados = new DataTable();

            try
            {
                conexion.AbrirConexion();

                string query = "SELECT * FROM empleado";

                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        empleados.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los empleados.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return empleados;
        }

        public void ActualizarEmpleado(int idEmpleado, string nombre, string apellido, string dui, string direccion, int idCatEmpleado, int idUsuario, int? idCuenta, int idSucursal)
        {
            try
            {
                conexion.AbrirConexion();

                string query = @"
        UPDATE empleado
        SET nombre = @Nombre,
            apellido = @Apellido,
            dui = @Dui,
            direccion = @Direccion,
            id_cat_empleado = @IdCatEmpleado,
            id_usuario = @IdUsuario,
            id_cuenta = @IdCuenta,
            id_sucursal = @IdSucursal
        WHERE id_empleado = @IdEmpleado";

                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Dui", dui);
                    command.Parameters.AddWithValue("@Direccion", direccion);
                    command.Parameters.AddWithValue("@IdCatEmpleado", idCatEmpleado);
                    command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    command.Parameters.AddWithValue("@IdSucursal", idSucursal);
                    command.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                    // Usar DBNull.Value si idCuenta es null
                    if (idCuenta.HasValue)
                    {
                        command.Parameters.AddWithValue("@IdCuenta", idCuenta.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@IdCuenta", DBNull.Value);
                    }

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el empleado.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }


        public bool ExisteIdUsuario(int idUsuario)
        {
            string query = "SELECT COUNT(*) FROM empleado WHERE id_usuario = @IdUsuario";
            using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
            {
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                conexion.AbrirConexion();
                int count = (int)command.ExecuteScalar();
                conexion.CerrarConexion();
                return count > 0;
            }
        }

        public bool ExisteIdCuenta(int idCuenta)
        {
            string query = "SELECT COUNT(*) FROM empleado WHERE id_cuenta = @IdCuenta";
            using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
            {
                command.Parameters.AddWithValue("@IdCuenta", idCuenta);
                conexion.AbrirConexion();
                int count = (int)command.ExecuteScalar();
                conexion.CerrarConexion();
                return count > 0;
            }
        }

        public bool ExisteIdUsuario1(int idUsuario)
        {
            string query = "SELECT COUNT(*) FROM empleado WHERE id_usuario = @IdUsuario";
            using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
            {
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                conexion.AbrirConexion();
                int count = (int)command.ExecuteScalar();
                conexion.CerrarConexion();
                return count > 0;
            }
        }

        public bool ExisteDUI(string dui)
        {
            string query = "SELECT COUNT(*) FROM empleado WHERE dui = @Dui";
            using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
            {
                command.Parameters.AddWithValue("@Dui", dui);
                conexion.AbrirConexion();
                int count = (int)command.ExecuteScalar();
                conexion.CerrarConexion();
                return count > 0;
            }
        }

        public bool ExisteIdUsuarioEnTablaUsuario(int idUsuario)
        {
            string query = "SELECT COUNT(*) FROM usuario WHERE id_usuario = @IdUsuario";
            using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
            {
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                conexion.AbrirConexion();
                int count = (int)command.ExecuteScalar();
                conexion.CerrarConexion();
                return count > 0;
            }
        }

        public bool ExisteIdCuentaEnTablaCuenta(int idCuenta)
        {
            string query = "SELECT COUNT(*) FROM cuenta WHERE id_cuenta = @IdCuenta";
            using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
            {
                command.Parameters.AddWithValue("@IdCuenta", idCuenta);
                conexion.AbrirConexion();
                int count = (int)command.ExecuteScalar();
                conexion.CerrarConexion();
                return count > 0;
            }
        }
    }
}
