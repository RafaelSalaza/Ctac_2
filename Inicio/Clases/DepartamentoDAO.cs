using System;
using System.Data;
using System.Data.SqlClient;

namespace Inicio
{
    public class DepartamentoDAO
    {
        private Conexion conexion;

        public DepartamentoDAO(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public DataTable ObtenerDepartamentos()
        {
            string query = "SELECT Id_departamento, nombre_departamento FROM departamento";
            SqlDataAdapter da = new SqlDataAdapter(query, conexion.Conexion_);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

