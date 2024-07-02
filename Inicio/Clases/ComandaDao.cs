
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    internal class ComandaDao
    {
        private Conexion conexion;

        public ComandaDao(Conexion conexion)
        {
            this.conexion = conexion;
        }


        public void AgregarComanda(Comanda comanda)
        {

            string query = @"INSERT INTO comanda (nombre, id_vehiculo, id_proyecto)
                             VALUES (@Nombre, @IdVehiculo, @IdProyecto)";

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    command.Parameters.AddWithValue("@Nombre", comanda.Nombre);
                    command.Parameters.AddWithValue("@IdVehiculo", comanda.Id_vehiculo);
                    command.Parameters.AddWithValue("@IdProyecto", comanda.Id_proyecto);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la comanda." + ex.Message, ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void ModificarComanda(Comanda comanda)
        {
            string query = @"UPDATE comanda SET 
                             nombre = @Nombre, 
                             id_vehiculo = @IdVehiculo, 
                             id_proyecto = @IdProyecto
                             WHERE id_comanda = @IdComanda";
            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    command.Parameters.AddWithValue("@IdComanda", comanda.Id_comanda);
                    command.Parameters.AddWithValue("@Nombre", comanda.Nombre);
                    command.Parameters.AddWithValue("@IdVehiculo", comanda.Id_vehiculo);
                    command.Parameters.AddWithValue("@IdProyecto", comanda.Id_proyecto);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar la comanda: " + ex.Message, ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public Vehiculo GetVehiculoPorId(int idVehiculo)
        {
            Vehiculo vehiculo = null;
            string query = "SELECT id_vehiculo, placa, descripcion, anio FROM vehiculo WHERE id_vehiculo = @IdVehiculo";
            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    command.Parameters.AddWithValue("@IdVehiculo", idVehiculo);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            vehiculo = new Vehiculo
                            {
                                Id_vehiculo = reader.GetInt32(0),
                                Placa = reader.GetString(1),
                                Descripcion = reader.GetString(2),
                                Anio = reader.GetString(3)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el vehículo: " + ex.Message, ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return vehiculo;
        }


        public Comanda ObtenerComandaPorId(int idComanda)
        {
            string query = @"SELECT id_comanda, nombre, id_vehiculo, id_proyecto 
                             FROM comanda WHERE id_comanda = @IdComanda";
            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    command.Parameters.AddWithValue("@IdComanda", idComanda);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Comanda
                            {
                                Id_comanda = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Id_vehiculo = reader.GetInt32(2),
                                Id_proyecto = reader.GetInt32(3)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la comanda: " + ex.Message, ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return null;
        }

        public Proyecto GetProyectoPorId(int idProyecto)
        {
            Proyecto proyecto = null;
            string query = @"SELECT id_proyecto, nombre, id_direccion, id_empleado, descripcion, id_categoria_proyecto, id_cliente, precio_proyecto, id_tipo_pago, financiado, pagado, id_estado_proyecto 
                     FROM proyecto WHERE id_proyecto = @IdProyecto";

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    command.Parameters.AddWithValue("@IdProyecto", idProyecto);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            proyecto = new Proyecto
                            {
                                Idproyecto = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Id_direccion = reader.GetInt32(2),
                                Id_empleado = reader.GetInt32(3),
                                Descripcion = reader.GetString(4),
                                Id_categoria_proyecto = reader.GetInt32(5),
                                Id_cliente = reader.GetInt32(6),
                                Precio_proyecto = reader.GetDecimal(7),
                                Id_tipo_pago = reader.GetInt32(8),
                                Financiado = reader.GetBoolean(9),
                                Pagado = reader.GetBoolean(10),
                                Id_estado_proyecto = reader.GetInt32(11)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el proyecto por ID: " + ex.Message, ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return proyecto;
        }

        public List<Comanda> ObtenerTodasLasComandas()
        {
            List<Comanda> comandas = new List<Comanda>();
            string query = @"SELECT c.id_comanda, c.nombre as nombre_comanda, v.placa as vehiculo, 
                     p.nombre as proyecto, v.descripcion as descripcionVehiculo, 
                     v.anio as añoVehiculo 
                     FROM comanda c 
                     INNER JOIN vehiculo v ON c.id_vehiculo = v.id_vehiculo 
                     INNER JOIN proyecto p ON c.id_proyecto = p.id_proyecto";

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Comanda comanda = new Comanda
                        {
                            Id_comanda = reader.GetInt32(reader.GetOrdinal("id_comanda")),
                            Nombre = reader.GetString(reader.GetOrdinal("nombre_comanda")),
                            PlacaVehiculo = reader.GetString(reader.GetOrdinal("vehiculo")),
                            NombreProyecto = reader.GetString(reader.GetOrdinal("proyecto")),
                            DescripcionVehiculo = reader.GetString(reader.GetOrdinal("descripcionVehiculo")),
                            AnioVehiculo = reader.IsDBNull(reader.GetOrdinal("añoVehiculo")) ? "N/A" : reader.GetString(reader.GetOrdinal("añoVehiculo")) // Manejo de nulos
                        };
                        comandas.Add(comanda);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las comandas: " + ex.Message, ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return comandas;
        }



        public List<Proyecto> GetProyectos()
        {
            List<Proyecto> proyectos = new List<Proyecto>();
            string query = @"SELECT id_proyecto, nombre, id_direccion, id_empleado, descripcion, 
                             id_categoria_proyecto, id_cliente, precio_proyecto, id_tipo_pago, 
                             financiado, pagado, id_estado_proyecto FROM proyecto";
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
                            Idproyecto = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Id_direccion = reader.GetInt32(2),
                            Id_empleado = reader.GetInt32(3),
                            Descripcion = reader.GetString(4),
                            Id_categoria_proyecto = reader.GetInt32(5),
                            Id_cliente = reader.GetInt32(6),
                            Precio_proyecto = reader.GetDecimal(7),
                            Id_tipo_pago = reader.GetInt32(8),
                            Financiado = reader.GetBoolean(9),
                            Pagado = reader.GetBoolean(10),
                            Id_estado_proyecto = reader.GetInt32(11)
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


        public List<Vehiculo> GetVehiculosConTipo()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            string query = @"SELECT v.id_vehiculo, v.id_categoria_vehiculo, v.placa, v.descripcion, 
                             v.anio, v.id_sucursal, cv.tipo 
                             FROM vehiculo v
                             JOIN categoria_vehiculo cv ON v.id_categoria_vehiculo = cv.id_categoria_vehiculo";
            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Vehiculo vehiculo = new Vehiculo
                        {
                            Id_vehiculo = reader.GetInt32(0),
                            Id_categoria_vehiculo = reader.GetInt32(1),
                            Placa = reader.GetString(2),
                            Descripcion = reader.GetString(3),
                            Anio = reader.GetString(4),
                            Id_sucursal = reader.GetInt32(5),
                            TipoVehiculo = reader.GetString(6)
                        };
                        vehiculos.Add(vehiculo);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los vehículos: " + ex.Message, ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return vehiculos;
        }

        public List<Comanda> ObtenerComandasCreadas()
        {
            List<Comanda> comandas = new List<Comanda>();
            string query = @"SELECT c.id_comanda, c.nombre as nombre_comanda, v.placa as vehiculo, 
                             p.nombre as proyecto, v.descripcion as descripcionVehiculo,
                             v.anio as añoVehiculo 
                             FROM comanda c 
                             INNER JOIN vehiculo v ON c.id_vehiculo = v.id_vehiculo
                             INNER JOIN proyecto p ON c.id_proyecto = p.id_proyecto";
            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Comanda comanda = new Comanda
                        {
                            Id_comanda = reader.GetInt32(reader.GetOrdinal("id_comanda")),
                            Nombre = reader.GetString(reader.GetOrdinal("nombre_comanda")),
                            PlacaVehiculo = reader.GetString(reader.GetOrdinal("vehiculo")),
                            NombreProyecto = reader.GetString(reader.GetOrdinal("proyecto")),
                            DescripcionVehiculo = reader.GetString(reader.GetOrdinal("descripcionVehiculo")),
                            AnioVehiculo = reader.GetString(reader.GetOrdinal("añoVehiculo"))
                        };
                        comandas.Add(comanda);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las comandas: " + ex.Message, ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return comandas;
        }

    }
}
