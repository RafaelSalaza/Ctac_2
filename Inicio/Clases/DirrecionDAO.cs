using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace Inicio
{
    public class DireccionDAO
    {
        private Conexion conexion;

        public DireccionDAO(Conexion conexion)
        {
            this.conexion = conexion;
        }
        public DataTable ObtenerDireccionesConDepartamento()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "select d.id_direccion,d.id_distrito,d.descripcion,d.referencia,di.id_departamento from direcciones d inner join distrito di on d.id_distrito = di.id_distrito inner join departamento dep on dep.Id_departamento = di.id_departamento";
                SqlDataAdapter da = new SqlDataAdapter(query, conexion.Conexion_);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las direcciones con departamento: " + ex.Message);
            }
            return dt;
        }


        public int ObtenerIdDepartamentoPorDireccion(int idDireccion)
        {
            int idDepartamento = -1;
            try
            {
                string query = "SELECT id_distrito FROM direcciones WHERE id_direccion = @idDireccion";
                SqlCommand cmd = new SqlCommand(query, conexion.Conexion_);
                cmd.Parameters.AddWithValue("@idDireccion", idDireccion);

                conexion.AbrirConexion();
                idDepartamento = (int)cmd.ExecuteScalar();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el ID de departamento por dirección: " + ex.Message);
            }
            return idDepartamento;
        }

        public DataTable ObtenerDireccionesConDistritos()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT d.id_direccion, dt.nombre AS nombre_distrito, d.descripcion, d.referencia " +
                               "FROM direcciones d " +
                               "JOIN distrito dt ON d.id_distrito = dt.id_distrito";
                SqlDataAdapter da = new SqlDataAdapter(query, conexion.Conexion_);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las direcciones con distritos: " + ex.Message);
            }
            return dt;
        }


        public DataTable ObtenerDirecciones()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT id_direccion, id_distrito, descripcion, referencia FROM direcciones";
                SqlDataAdapter da = new SqlDataAdapter(query, conexion.Conexion_);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las direcciones: " + ex.Message);
            }
            return dt;
        }

        public void CrearDireccion(int idDistrito, string descripcion, string referencia)
        {
            try
            {
                string query = "INSERT INTO direcciones (id_distrito, descripcion, referencia) VALUES (@idDistrito, @descripcion, @referencia)";
                SqlCommand cmd = new SqlCommand(query, conexion.Conexion_);
                cmd.Parameters.AddWithValue("@idDistrito", idDistrito);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@referencia", referencia);

                conexion.AbrirConexion();
                cmd.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la dirección: " + ex.Message);
            }
        }

        public int ObtenerUltimoIdDireccion()
        {
            int idDireccion = -1;
            try
            {
                string query = "SELECT MAX(id_direccion) FROM direcciones";
                SqlCommand cmd = new SqlCommand(query, conexion.Conexion_);

                conexion.AbrirConexion();
                idDireccion = (int)cmd.ExecuteScalar();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el último ID de dirección: " + ex.Message);
            }
            return idDireccion;
        }

        public void ActualizarDireccion(int idDireccion, int idDistrito, string descripcion, string referencia)
        {
            try
            {
                string query = "UPDATE direcciones SET id_distrito = @idDistrito, descripcion = @descripcion, referencia = @referencia WHERE id_direccion = @idDireccion";
                SqlCommand cmd = new SqlCommand(query, conexion.Conexion_);
                cmd.Parameters.AddWithValue("@idDireccion", idDireccion);
                cmd.Parameters.AddWithValue("@idDistrito", idDistrito);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@referencia", referencia);

                conexion.AbrirConexion();
                cmd.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la dirección: " + ex.Message);
            }
        }
    }
}
