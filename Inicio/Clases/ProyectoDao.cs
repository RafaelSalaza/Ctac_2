
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
    internal class ProyectoDao
    {
        private Conexion conexion;

        public ProyectoDao(Conexion conexion)
        {
            this.conexion = conexion;
        }
        public void AgregarProyecto(Proyecto proyecto, int idUsuario)
        {
            // Verificar si el IdUsuario es igual al Id_empleado del proyecto
            if (idUsuario != proyecto.Id_empleado)
            {
                throw new Exception("El IdUsuario no coincide con el Id_empleado del proyecto.");
            }

            string query = @"INSERT INTO proyecto 
                     (nombre, descripcion, id_direccion, id_empleado, id_categoria_proyecto, id_cliente, precio_proyecto, id_tipo_pago, financiado, pagado, id_estado_proyecto)
                     VALUES (@Nombre, @Descripcion, @IdDireccion, @IdEmpleado, @IdCategoriaProyecto, @IdCliente, @PrecioProyecto, @IdTipoPago, @Financiado, @Pagado, @IdEstadoProyecto)";

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    command.Parameters.AddWithValue("@Nombre", proyecto.Nombre);
                    command.Parameters.AddWithValue("@Descripcion", proyecto.Descripcion);
                    command.Parameters.AddWithValue("@IdDireccion", proyecto.Id_direccion);
                    command.Parameters.AddWithValue("@IdEmpleado", proyecto.Id_empleado);
                    command.Parameters.AddWithValue("@IdCategoriaProyecto", proyecto.Id_categoria_proyecto);
                    command.Parameters.AddWithValue("@IdCliente", proyecto.Id_cliente);
                    command.Parameters.AddWithValue("@PrecioProyecto", proyecto.Precio_proyecto);
                    command.Parameters.AddWithValue("@IdTipoPago", proyecto.Id_tipo_pago);
                    command.Parameters.AddWithValue("@Financiado", proyecto.Financiado);
                    command.Parameters.AddWithValue("@Pagado", proyecto.Pagado);
                    command.Parameters.AddWithValue("@IdEstadoProyecto", proyecto.Id_estado_proyecto);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el proyecto." + ex.Message, ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // Método para modificar un proyecto
        public void ModificarProyecto(Proyecto proyecto)
        {
            string query = @"UPDATE proyecto SET 
                     nombre = @Nombre, 
                     descripcion = @Descripcion, 
                     id_direccion = @IdDireccion, 
                     id_categoria_proyecto = @IdCategoriaProyecto, 
                     id_cliente = @IdCliente, 
                     precio_proyecto = @PrecioProyecto, 
                     id_tipo_pago = @IdTipoPago, 
                     financiado = @Financiado, 
                     pagado = @Pagado, 
                     id_estado_proyecto = @IdEstadoProyecto
                     WHERE id_proyecto = @IdProyecto";

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    command.Parameters.AddWithValue("@IdProyecto", proyecto.Idproyecto);
                    command.Parameters.AddWithValue("@Nombre", proyecto.Nombre);
                    command.Parameters.AddWithValue("@Descripcion", proyecto.Descripcion);
                    command.Parameters.AddWithValue("@IdDireccion", proyecto.Id_direccion);
                    command.Parameters.AddWithValue("@IdCategoriaProyecto", proyecto.Id_categoria_proyecto);
                    command.Parameters.AddWithValue("@IdCliente", proyecto.Id_cliente);
                    command.Parameters.AddWithValue("@PrecioProyecto", proyecto.Precio_proyecto);
                    command.Parameters.AddWithValue("@IdTipoPago", proyecto.Id_tipo_pago);
                    command.Parameters.AddWithValue("@Financiado", proyecto.Financiado);
                    command.Parameters.AddWithValue("@Pagado", proyecto.Pagado);
                    command.Parameters.AddWithValue("@IdEstadoProyecto", proyecto.Id_estado_proyecto);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el proyecto.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }
        public List<Cliente> GetClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            string query = "SELECT id_cliente, nombre, apellido, dui, id_cuenta, direccion, correo, fecha_registro, id_sucursal, telefono FROM cliente";

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente
                        {
                            Id_cliente = reader.GetInt32(0),
                            Nombre = reader.IsDBNull(1) ? null : reader.GetString(1),
                            Apellido = reader.IsDBNull(2) ? null : reader.GetString(2),
                            Dui = reader.IsDBNull(3) ? null : reader.GetString(3),
                            Id_cuenta = reader.IsDBNull(4) ? (int?)null : reader.GetInt32(4),
                            Direccion = reader.IsDBNull(5) ? null : reader.GetString(5),
                            Correo = reader.IsDBNull(6) ? null : reader.GetString(6),
                            Fecha_registro = reader.GetDateTime(7),
                            Id_sucursal = reader.IsDBNull(8) ? (int?)null : reader.GetInt32(8),
                            Telefono = reader.IsDBNull(9) ? null : reader.GetString(9)
                        };
                        clientes.Add(cliente);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los clientes.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return clientes;
        }

        public List<TipoPago> GetTipoPago()
        {
            List<TipoPago> tipopagos = new List<TipoPago>();
            string query = "SELECT id_tipo_pago, nombre FROM tipo_pago";

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TipoPago tipopago = new TipoPago
                        {
                            Id_tipo_pago = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                        };
                        tipopagos.Add(tipopago);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los tipo_pago.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return tipopagos;
        }

        public List<Cat_proyecto> GetCatProyecto()
        {
            List<Cat_proyecto> catProyectos = new List<Cat_proyecto>();
            string query = "SELECT id_categoria_proyecto, nombre_categoria FROM categoria_proyecto";

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                    Cat_proyecto catproyecto = new Cat_proyecto
                    {
                        Id_categoria_proyecto = reader.GetInt32(0),
                        Nombre_categoria = reader.GetString(1),
                    };
                      catProyectos.Add(catproyecto);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los categoria_proyecto.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return catProyectos;
        }

        public List<Direccion> GetDireccion()
        {
            List<Direccion> direcciones = new List<Direccion>();
            string query = "SELECT id_direccion,id_distrito, descripcion, referencia FROM direcciones";

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Direccion direccion = new Direccion
                        {
                            Id_direccion = reader.GetInt32(0),
                            Id_distrito = reader.GetInt32(1),
                            Descripcion = reader.GetString(2),
                            Referencia = reader.GetString(3),
                        };
                        direcciones.Add(direccion);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los direcciones.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return direcciones;
        }

        public List<EstadoProyecto> GetEstadoProyecto()
        {
            List<EstadoProyecto> estados = new List<EstadoProyecto>();
            string query = "SELECT id_estado_proyecto,nombre FROM estado_proyecto";

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EstadoProyecto estadoProyecto = new EstadoProyecto
                        {
                            Id_estado_proyecto = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                        };
                        estados.Add(estadoProyecto);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los estado_proyecto.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return estados;
        }


        public List<Proyecto> ObtenerProyectosCreados()
        {
            List<Proyecto> proyectos = new List<Proyecto>();
            string query = @"SELECT p.id_proyecto, p.nombre, p.descripcion, d.descripcion as nombre_direccion, 
                            e.nombre as nombre_empleado, c.nombre AS nombre_cliente, 
                            cp.nombre_categoria AS nombre_categoria, p.precio_proyecto, 
                            t.nombre as tipo_de_pago, p.financiado, p.pagado, 
                            es.nombre as estado_proyecto
                     FROM Proyecto p
                     INNER JOIN Cliente c ON p.id_cliente = c.id_cliente
                     INNER JOIN Categoria_Proyecto cp ON p.id_categoria_proyecto = cp.id_categoria_proyecto
                     INNER JOIN empleado e ON p.id_empleado = e.id_empleado
                     INNER JOIN direcciones d ON p.id_direccion = d.id_direccion
                     INNER JOIN tipo_pago t ON p.id_tipo_pago = t.id_tipo_pago
                     INNER JOIN estado_proyecto es ON p.id_estado_proyecto = es.id_estado_proyecto";

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Proyecto proyecto = new Proyecto
                        {
                            Idproyecto = reader.GetInt32(reader.GetOrdinal("id_proyecto")),
                            Nombre = reader.GetString(reader.GetOrdinal("nombre")),
                            Descripcion = reader.GetString(reader.GetOrdinal("descripcion")),
                            NombreDireccion = reader.GetString(reader.GetOrdinal("nombre_direccion")),
                            NombreEmpleado = reader.GetString(reader.GetOrdinal("nombre_empleado")),
                            NombreCliente = reader.GetString(reader.GetOrdinal("nombre_cliente")),
                            NombreCategoria = reader.GetString(reader.GetOrdinal("nombre_categoria")),
                            Precio_proyecto = reader.GetDecimal(reader.GetOrdinal("precio_proyecto")),
                            NombreTipoPago = reader.GetString(reader.GetOrdinal("tipo_de_pago")),
                            Financiado = reader.GetBoolean(reader.GetOrdinal("financiado")),
                            Pagado = reader.GetBoolean(reader.GetOrdinal("pagado")),
                            NombreEstadoProyecto = reader.GetString(reader.GetOrdinal("estado_proyecto")),
                        };
                        proyectos.Add(proyecto);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los proyectos: " + ex.Message, ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return proyectos;
        }

        //public List<Proyecto> ObtenerProyectosPorNombre(string nombreProyecto)
        //{
        //    List<Proyecto> proyectos = new List<Proyecto>();
        //    string query = @"SELECT p.id_proyecto, p.nombre, p.descripcion, d.descripcion as nombre_direccion, 
        //            e.nombre as nombre_empleado, c.nombre AS nombre_cliente, 
        //            cp.nombre_categoria AS nombre_categoria, p.precio_proyecto, 
        //            t.nombre as tipo_de_pago, p.financiado, p.pagado, 
        //            es.nombre as estado_proyecto
        //     FROM Proyecto p
        //     INNER JOIN Cliente c ON p.id_cliente = c.id_cliente
        //     INNER JOIN Categoria_Proyecto cp ON p.id_categoria_proyecto = cp.id_categoria_proyecto
        //     INNER JOIN empleado e ON p.id_empleado = e.id_empleado
        //     INNER JOIN direcciones d ON p.id_direccion = d.id_direccion
        //     INNER JOIN tipo_pago t ON p.id_tipo_pago = t.id_tipo_pago
        //     INNER JOIN estado_proyecto es ON p.id_estado_proyecto = es.id_estado_proyecto
        //     WHERE p.nombre LIKE @Nombre";

        //    try
        //    {
        //        conexion.AbrirConexion();
        //        using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
        //        {
        //            command.Parameters.AddWithValue("@Nombre", "%" + nombreProyecto + "%");
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    Proyecto proyecto = new Proyecto
        //                    {
        //                        Idproyecto = reader.GetInt32(reader.GetOrdinal("id_proyecto")),
        //                        Nombre = reader.GetString(reader.GetOrdinal("nombre")),
        //                        Descripcion = reader.GetString(reader.GetOrdinal("descripcion")),
        //                        NombreDireccion = reader.GetString(reader.GetOrdinal("nombre_direccion")),
        //                        NombreEmpleado = reader.GetString(reader.GetOrdinal("nombre_empleado")),
        //                        NombreCliente = reader.GetString(reader.GetOrdinal("nombre_cliente")),
        //                        NombreCategoria = reader.GetString(reader.GetOrdinal("nombre_categoria")),
        //                        Precio_proyecto = reader.GetDecimal(reader.GetOrdinal("precio_proyecto")),
        //                        NombreTipoPago = reader.GetString(reader.GetOrdinal("tipo_de_pago")),
        //                        Financiado = reader.GetBoolean(reader.GetOrdinal("financiado")),
        //                        Pagado = reader.GetBoolean(reader.GetOrdinal("pagado")),
        //                        NombreEstadoProyecto = reader.GetString(reader.GetOrdinal("estado_proyecto")),
        //                    };
        //                    proyectos.Add(proyecto);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error al obtener los proyectos por nombre: " + ex.Message, ex);
        //    }
        //    finally
        //    {
        //        conexion.CerrarConexion();
        //    }

        //    return proyectos;
        //}

        public int ObtenerIdProyectoPorNombre(string nombreProyecto)
        {
            string query = "SELECT id_proyecto FROM proyecto WHERE nombre = @Nombre";
            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    command.Parameters.AddWithValue("@Nombre", nombreProyecto);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception("No se encontró ningún proyecto con ese nombre.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el ID del proyecto por nombre: " + ex.Message, ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }


        public List<Proyecto> ObtenerProyectosPorNombres(string nombreProyecto)
        {
            List<Proyecto> proyectos = new List<Proyecto>();
            string query = @"SELECT p.id_proyecto, p.nombre, p.descripcion, d.descripcion as nombre_direccion, 
                    e.nombre as nombre_empleado, c.nombre AS nombre_cliente, 
                    cp.nombre_categoria AS nombre_categoria, p.precio_proyecto, 
                    t.nombre as tipo_de_pago, p.pagado, 
                    es.nombre as estado_proyecto
             FROM Proyecto p
             INNER JOIN Cliente c ON p.id_cliente = c.id_cliente
             INNER JOIN Categoria_Proyecto cp ON p.id_categoria_proyecto = cp.id_categoria_proyecto
             INNER JOIN empleado e ON p.id_empleado = e.id_empleado
             INNER JOIN direcciones d ON p.id_direccion = d.id_direccion
             INNER JOIN tipo_pago t ON p.id_tipo_pago = t.id_tipo_pago
             INNER JOIN estado_proyecto es ON p.id_estado_proyecto = es.id_estado_proyecto
             WHERE p.nombre LIKE @Nombre";

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    command.Parameters.AddWithValue("@Nombre", "%" + nombreProyecto + "%");
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Proyecto proyecto = new Proyecto
                            {
                                Idproyecto = reader.GetInt32(reader.GetOrdinal("id_proyecto")),
                                Nombre = reader.GetString(reader.GetOrdinal("nombre")),
                                Descripcion = reader.GetString(reader.GetOrdinal("descripcion")),
                                NombreDireccion = reader.GetString(reader.GetOrdinal("nombre_direccion")),
                                NombreEmpleado = reader.GetString(reader.GetOrdinal("nombre_empleado")),
                                NombreCliente = reader.GetString(reader.GetOrdinal("nombre_cliente")),
                                NombreCategoria = reader.GetString(reader.GetOrdinal("nombre_categoria")),
                                Precio_proyecto = reader.GetDecimal(reader.GetOrdinal("precio_proyecto")),
                                NombreTipoPago = reader.GetString(reader.GetOrdinal("tipo_de_pago")),
                                Pagado = reader.GetBoolean(reader.GetOrdinal("pagado")),
                                NombreEstadoProyecto = reader.GetString(reader.GetOrdinal("estado_proyecto")),
                            };
                            proyectos.Add(proyecto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los proyectos por nombre: " + ex.Message, ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return proyectos;
        }
        public bool ExisteProyectoConNombre(string nombreProyecto)
        {
            string query = "SELECT COUNT(*) FROM proyecto WHERE nombre = @Nombre";
            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    command.Parameters.AddWithValue("@Nombre", nombreProyecto);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar la existencia del proyecto: " + ex.Message, ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

    }
}
