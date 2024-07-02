
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    internal class CuotaDao
    {
        private Conexion conexion;

        public CuotaDao(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Cuota> ObtenerCuotasPorFinanciacion(int idFinanciacion)
        {
            List<Cuota> cuotas = new List<Cuota>();
            string query = @"
            SELECT c.id_cuota, c.id_financiacion, c.fecha_vencimiento, c.valor_cuota, c.interes_mora, c.cuota_numero, p.nombre AS nombre_proyecto, c.total_a_pagar
            FROM cuota c
            JOIN financiacion f ON c.id_financiacion = f.id_financiacion
            JOIN proyecto p ON f.id_proyecto = p.id_proyecto
            WHERE c.id_financiacion = @IdFinanciacion";

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    command.Parameters.AddWithValue("@IdFinanciacion", idFinanciacion);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cuota cuota = new Cuota
                            {
                                Id_cuota = reader.GetInt32(0),
                                Id_financiacion = reader.GetInt32(1),
                                Fecha_vencimiento = reader.GetDateTime(2),
                                Valor_cuota = reader.GetDecimal(3),
                                Interes_mora = reader.GetDecimal(4),
                                Cuota_numero = reader.GetInt32(5),
                                Nombre_proyecto = reader.GetString(6),
                                Total_a_pagar = reader.GetDecimal(7),
                            };
                            cuotas.Add(cuota);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las cuotas.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return cuotas;
        }



        public void RegistrarPagoCuota(int idCuota, DateTime fechaPago)
        {
            string procedureName = "PagarCuotas";

            try
            {
                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(procedureName, conexion.Conexion_))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdCuota", idCuota);
                    command.Parameters.AddWithValue("@FechaPago", fechaPago);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el pago de la cuota utilizando el procedimiento almacenado.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }






        public void ActualizarCuota(Cuota cuota)
        {
            try
            {
                string query = @"UPDATE cuota
                         SET interes_mora = @InteresMora,
                             total_a_pagar = @TotalAPagar
                         WHERE id_cuota = @IdCuota";

                conexion.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, conexion.Conexion_))
                {
                    command.Parameters.AddWithValue("@InteresMora", cuota.Interes_mora);
                    command.Parameters.AddWithValue("@TotalAPagar", cuota.Total_a_pagar);
                    command.Parameters.AddWithValue("@IdCuota", cuota.Id_cuota);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la cuota.", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

    }
}
