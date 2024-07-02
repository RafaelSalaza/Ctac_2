using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Inicio
{
    internal class FinanciacionDao
    {
        private Conexion conexion;

        public FinanciacionDao(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void CalcularFinanciacion(int idProyecto, int anios, decimal interes)
        {
            if (conexion.AbrirConexion())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("CalcularFinanciacion", conexion.Conexion_))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id_proyecto", idProyecto);
                        cmd.Parameters.AddWithValue("@anios", anios);
                        cmd.Parameters.AddWithValue("@interes", interes);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Manejar excepciones
                    throw new Exception("Error al ejecutar el procedimiento almacenado: " + ex.Message, ex);
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }
            else
            {
                throw new Exception("No se pudo abrir la conexión a la base de datos.");
            }
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
        public List<Financiacion> ObtenerFinanciaciones(int idProyecto)
        {
            List<Financiacion> financiaciones = new List<Financiacion>();
            string query = @"SELECT id_financiacion, id_proyecto, fecha_inicio, fecha_fin, numero_cuotas, valor_cuota, 
                             tasa_interes_anual, monto_financiado, saldo_pendiente, id_estado_financiacion
                             FROM financiacion WHERE id_proyecto = @IdProyecto";

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    command.Parameters.AddWithValue("@IdProyecto", idProyecto);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Financiacion financiacion = new Financiacion
                            {
                                Id_financiacion = reader.GetInt32(0),
                                Id_proyecto = reader.GetInt32(1),
                                Fecha_inicio = reader.GetDateTime(2),
                                Fecha_fin = reader.GetDateTime(3),
                                Numero_cuotas = reader.GetInt32(4),
                                Valor_cuotas = reader.GetDecimal(5),
                                Tasa_interes_anual = reader.GetDecimal(6),
                                Monto_financiado = reader.GetDecimal(7),
                                Saldo_pendiente = reader.GetDecimal(8),
                                Id_estado_financiacion = reader.GetInt32(9)
                            };
                            financiaciones.Add(financiacion);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las financiaciones: " + ex.Message, ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return financiaciones;
        }


        public List<Financiacion> GetFinanciaciones()
        {
            List<Financiacion> finanzas = new List<Financiacion>();
            string query = "SELECT id_financiacion, id_proyecto, fecha_inicio, fecha_fin, numero_cuotas, valor_cuota, tasa_interes_anual, " +
                "monto_financiado,saldo_pendiente,id_estado_financiacion FROM financiacion";

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Financiacion financiacion = new Financiacion
                        {
                            Id_financiacion = reader.GetInt32(0),
                            Id_proyecto = reader.GetInt32(1),
                            Fecha_inicio = reader.GetDateTime(2),
                            Fecha_fin = reader.GetDateTime(3),
                            Numero_cuotas = reader.GetInt32(4),
                            Valor_cuotas = reader.GetDecimal(5),
                            Tasa_interes_anual = reader.GetDecimal(6),
                            Monto_financiado = reader.GetDecimal(7),
                            Saldo_pendiente = reader.GetDecimal(8),
                            Id_estado_financiacion = reader.GetInt32(9)
                        };
                        finanzas.Add(financiacion);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener financiaciones.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return finanzas;
        }

        public decimal ObtenerPrecioProyecto(int idProyecto)
        {
            decimal precioProyecto = 0m;

            string query = "SELECT precio_proyecto FROM proyecto WHERE id_proyecto = @idProyecto";

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    command.Parameters.AddWithValue("@idProyecto", idProyecto);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        precioProyecto = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el precio del proyecto: " + ex.Message, ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return precioProyecto;
        }

        public decimal ObtenerInteresAnual(decimal idFinanciacion)
        {
            decimal interesAnual = 0m;

            string query = "SELECT tasa_interes_anual FROM financiacion WHERE id_financiacion = @IdFinanciacion";

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    command.Parameters.AddWithValue("@IdFinanciacion", idFinanciacion);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        interesAnual = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la tasa de interés anual: " + ex.Message, ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return interesAnual;
        }

        public int ObtenerAniosFinanciacion()
        {
            int aniosFinanciacion = 0;

            string query = "SELECT valor FROM configuracion WHERE clave = 'AniosFinanciacion'";

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        aniosFinanciacion = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los años de financiación: " + ex.Message, ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return aniosFinanciacion;
        }
        public void ActualizarSaldoPendiente(int idFinanciacion, decimal totalAPagar)
        {
            string query = "UPDATE financiacion SET saldo_pendiente = saldo_pendiente - @TotalAPagar WHERE id_financiacion = @IdFinanciacion";

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    command.Parameters.AddWithValue("@TotalAPagar", totalAPagar);
                    command.Parameters.AddWithValue("@IdFinanciacion", idFinanciacion);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el saldo pendiente en la tabla financiacion.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        public List<Financiacion> ObtenerFinanciacionesCreadas()
        {
            List<Financiacion> financiaciones = new List<Financiacion>();
            string query = @"select f.id_financiacion, p.nombre as nombre_proyecto, f.fecha_inicio,f.fecha_fin,f.numero_cuotas,
                            f.valor_cuota,f.tasa_interes_anual,f.monto_financiado,f.saldo_pendiente,ef.nombre as estado_financiacion
                            from financiacion f
                            inner join proyecto p on f.id_proyecto = p.id_proyecto
                            inner join estado_financiacion ef on f.id_estado_financiacion = ef.id_estado_financiacion";

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Financiacion financiacion = new Financiacion
                        {
                            Id_financiacion = reader.GetInt32(reader.GetOrdinal("id_financiacion")),
                            NombreProyecto = reader.GetString(reader.GetOrdinal("nombre_proyecto")),
                            Fecha_inicio = reader.GetDateTime(reader.GetOrdinal("fecha_inicio")),
                            Fecha_fin = reader.GetDateTime(reader.GetOrdinal("fecha_fin")),
                            Numero_cuotas = reader.GetInt32(reader.GetOrdinal("numero_cuotas")),
                            Valor_cuotas = reader.GetDecimal(reader.GetOrdinal("valor_cuota")),
                            Tasa_interes_anual = reader.GetDecimal(reader.GetOrdinal("tasa_interes_anual")),
                            Monto_financiado = reader.GetDecimal(reader.GetOrdinal("monto_financiado")),
                            Saldo_pendiente = reader.GetDecimal(reader.GetOrdinal("saldo_pendiente")),
                            NombreEstadoFinanciacion = reader.GetString(reader.GetOrdinal("estado_financiacion")),

                        };
                        financiaciones.Add(financiacion);
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

            return financiaciones;
        }
    }
}
