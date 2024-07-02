using System;
using System.Data;
using System.Data.SqlClient;

namespace Inicio
{
    public class DistritoDAO
    {
        private Conexion conexion;

        public DistritoDAO(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public DataTable ObtenerDistritosPorDepartamento(int idDepartamento)
        {
            string query = "SELECT id_distrito, nombre FROM distrito WHERE id_departamento = @idDepartamento";
            SqlDataAdapter da = new SqlDataAdapter(query, conexion.Conexion_);
            da.SelectCommand.Parameters.AddWithValue("@idDepartamento", idDepartamento);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

