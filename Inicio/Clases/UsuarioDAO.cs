using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Inicio
{
    internal class UsuarioDAO
    {
        private Conexion conexion;

        public UsuarioDAO(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public Usuario AutenticarUsuario(string codigoUsuario, string clave)
        {
            conexion.AbrirConexion();

            string query = "SELECT * FROM usuario WHERE codigo_usuario = @CodigoUsuario AND clave = @Clave";

            using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
            {
                command.Parameters.AddWithValue("@CodigoUsuario", codigoUsuario);
                command.Parameters.AddWithValue("@Clave", clave);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    Usuario usuario = new Usuario
                    {
                        IdUsuario = reader.GetInt32(0),
                        Clave = reader.GetString(1),
                        NombreUsuario = reader.GetString(2),
                        CodigoUsuario = reader.GetString(3),
                        IdRol = reader.GetInt32(4),
                        FechaCreacion = reader.GetDateTime(5)
                    };
                    return usuario;
                }
                else
                {
                    return null;
                }
            }
        }

        public (string nombreEmpleado, string apellidoEmpleado, int idSucursal, string nombreSucursal) ObtenerInformacionUsuario(int idUsuario)
        {
            string nombreEmpleado = "";
            string apellidoEmpleado = "";
            int idSucursal = 0;
            string nombreSucursal = "";

            try
            {
                conexion.AbrirConexion();

                string query = @"
                SELECT e.nombre, e.apellido, s.id_sucursal, s.nombre_sucursal
                FROM empleado e
                INNER JOIN sucursal s ON e.id_sucursal = s.id_sucursal
                WHERE e.id_usuario = @IdUsuario";

                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    command.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nombreEmpleado = reader.GetString(0);
                            apellidoEmpleado = reader.GetString(1);
                            idSucursal = reader.GetInt32(2);
                            nombreSucursal = reader.GetString(3);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la información del usuario.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return (nombreEmpleado, apellidoEmpleado, idSucursal, nombreSucursal);
        }

        public void CrearUsuario(string clave, string nombreUsuario, string codigoUsuario, int idRol)
        {
            try
            {
                // Verificar si algún campo está vacío o el idRol es 0
                if (string.IsNullOrWhiteSpace(clave) || string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(codigoUsuario) || idRol == 0)
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return; // Salir del método sin crear el usuario
                }

                // Verificar si el código de usuario ya existe
                if (ExisteCodigoUsuario(codigoUsuario))
                {
                    MessageBox.Show("El código de usuario ya existe. Por favor, elija otro.");
                    return; // Salir del método sin crear el usuario
                }

                // Abrir la conexión
                conexion.AbrirConexion();

                // Consulta SQL para insertar el nuevo usuario
                string query = @"
        INSERT INTO usuario (clave, nombre_usuario, codigo_usuario, id_rol)
        VALUES (@Clave, @NombreUsuario, @CodigoUsuario, @IdRol)";

                // Crear el comando SQL
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    // Agregar parámetros al comando
                    command.Parameters.AddWithValue("@Clave", clave);
                    command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    command.Parameters.AddWithValue("@CodigoUsuario", codigoUsuario);
                    command.Parameters.AddWithValue("@IdRol", idRol);

                    // Ejecutar el comando para insertar el usuario
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                // En caso de excepción SQL (relacionada con la base de datos)
                MessageBox.Show("Error al crear el usuario en la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                // En caso de otras excepciones
                MessageBox.Show("Error al crear el usuario: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión en cualquier caso
                conexion.CerrarConexion();
            }

            // Mostrar mensaje de éxito solo si no se ha producido ninguna excepción
            MessageBox.Show("Usuario creado exitosamente.");
        }




        public void ActualizarUsuario(int idUsuario, string clave, string nombreUsuario, string codigoUsuario, int idRol)
        {
            if (string.IsNullOrWhiteSpace(clave) || string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(codigoUsuario) || idRol == 0)
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            if (ExisteCodigoUsuario(codigoUsuario, idUsuario))
            {
                MessageBox.Show("El código de usuario ya existe. Por favor, elija otro.");
                return;
            }

            try
            {
                conexion.AbrirConexion();

                string query = @"
                UPDATE usuario 
                SET clave = @Clave, nombre_usuario = @NombreUsuario, codigo_usuario = @CodigoUsuario, id_rol = @IdRol 
                WHERE id_usuario = @IdUsuario";

                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    command.Parameters.AddWithValue("@Clave", clave);
                    command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    command.Parameters.AddWithValue("@CodigoUsuario", codigoUsuario);
                    command.Parameters.AddWithValue("@IdRol", idRol);
                    command.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Usuario actualizado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        private bool ExisteCodigoUsuario(string codigoUsuario, int? idUsuario = null)
        {
            try
            {
                conexion.AbrirConexion();

                string query = idUsuario.HasValue ?
                    "SELECT COUNT(*) FROM usuario WHERE codigo_usuario = @CodigoUsuario AND id_usuario != @IdUsuario" :
                    "SELECT COUNT(*) FROM usuario WHERE codigo_usuario = @CodigoUsuario";

                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    command.Parameters.AddWithValue("@CodigoUsuario", codigoUsuario);
                    if (idUsuario.HasValue)
                    {
                        command.Parameters.AddWithValue("@IdUsuario", idUsuario.Value);
                    }

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el código de usuario: " + ex.Message);
                return true; // Prevent further action if there's an error
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public List<Rol> ObtenerRoles()
        {
            List<Rol> roles = new List<Rol>();

            try
            {
                conexion.AbrirConexion();

                string query = "SELECT id_rol, nombre_rol FROM rol";

                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rol rol = new Rol
                            {
                                IdRol = reader.GetInt32(0),
                                NombreRol = reader.GetString(1)
                            };
                            roles.Add(rol);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los roles: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return roles;
        }

        public DataTable ObtenerUsuarios()
        {
            DataTable usuarios = new DataTable();

            try
            {
                conexion.AbrirConexion();

                string query = "SELECT id_usuario, clave, nombre_usuario, codigo_usuario, id_rol, fechacreacion FROM usuario";

                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        usuarios.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los usuarios: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return usuarios;
        }
    }
}


