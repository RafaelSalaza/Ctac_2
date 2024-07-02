using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    public class Conexion
    {
        private SqlConnection conexion;
        private static readonly string servidor = "LAPTOP-OECTJNHV";
        private static readonly string baseDatos = "ctac1";
        private static readonly string cadenaConexion = $"Data Source={servidor};Initial Catalog={baseDatos};Integrated Security=True";

        public Conexion()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public SqlConnection Conexion_ => conexion;

        public bool AbrirConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                    Console.WriteLine("Conexión establecida correctamente.");
                }
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al abrir la conexión: {ex.Message}");
                foreach (SqlError error in ex.Errors)
                {
                    Console.WriteLine($"Error: {error.Message}");
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error general: {ex.Message}");
                return false;
            }
        }


        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
                Console.WriteLine("Conexión cerrada correctamente.");
            }
        }


    }
}
