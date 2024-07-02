using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    internal class ClienteDao
    {
        Conexion con;
        public ClienteDao(Conexion con)
        {
            this.con = con;
        }

        public DataTable CargarClientes(int idSucursal)
        {
            DataTable clientes = new DataTable();

            try
            {
                if (con.AbrirConexion())
                {
                    string query = @"
                SELECT id_cliente as ID, nombre AS NOMBRE, apellido AS APELLIDO, telefono as TEL
                FROM cliente
                WHERE id_sucursal = @idSucursal";

                    SqlCommand cmd = new SqlCommand(query, con.Conexion_);
                    cmd.Parameters.AddWithValue("@idSucursal", idSucursal);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(clientes);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar los clientes: {ex.Message}");
            }
            finally
            {
                con.CerrarConexion();
            }

            return clientes;
        }

        public void AgregarCliente(Cliente cliente)
        {

            string query = @"INSERT INTO cliente 
                 (nombre, apellido, dui, id_cuenta, direccion, correo, fecha_registro, id_sucursal,telefono)
                 VALUES (@Nombre, @Apellido, @Dui, @Id_cuenta, @Direccion, @Correo, @Fecha_registro, @Id_sucursal,@Telefono)";

            try
            {
                con.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, con.Conexion_))
                {
                    command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    command.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                    command.Parameters.AddWithValue("@Dui", cliente.Dui);
                    command.Parameters.AddWithValue("@Id_cuenta", cliente.Id_cuenta);
                    command.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                    command.Parameters.AddWithValue("@Correo", cliente.Correo);
                    command.Parameters.AddWithValue("@Fecha_registro", cliente.Fecha_registro);
                    command.Parameters.AddWithValue("@Id_sucursal", cliente.Id_sucursal);
                    command.Parameters.AddWithValue("@Telefono", cliente.Telefono);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el cliente." + ex.Message, ex);
            }
            finally
            {
                con.CerrarConexion();
            }
        }

        public void ModificarCliente(Cliente cliente)
        {
            string query = @"UPDATE proyecto SET 
                 nombre = @Nombre, 
                 apellido = @Apellido, 
                 dui = @Dui, 
                 id_cuenta = @Id_cuenta, 
                 direccion = @Direccion, 
                 correo = @Correo, 
                 fecha_registro = @Fecha_registro, 
                 id_sucursal = @Id_sucursal,
                 telefono = @Telefono,
                 WHERE id_cliente = @Id_cliente";

            try
            {
                con.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, con.Conexion_))
                {
                    command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    command.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                    command.Parameters.AddWithValue("@Dui", cliente.Dui);
                    command.Parameters.AddWithValue("@Id_cuenta", cliente.Id_cuenta);
                    command.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                    command.Parameters.AddWithValue("@Correo", cliente.Correo);
                    command.Parameters.AddWithValue("@Fecha_registro", cliente.Fecha_registro);
                    command.Parameters.AddWithValue("@Id_sucursal", cliente.Id_sucursal);
                    command.Parameters.AddWithValue("@Telefono", cliente.Telefono);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el cliente.", ex);
            }
            finally
            {
                con.CerrarConexion();
            }

        }

        public List<Sucursale> Getsucursales()
        {
            List<Sucursale> sucursales = new List<Sucursale>();
            string query = "SELECT id_sucursal, id_direccion, id_cuenta, nombre_sucursal, hora_cierre, hora_apertura FROM sucursal";

            try
            {
                con.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, con.Conexion_))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Sucursale sucursal = new Sucursale
                        {
                            Id_sucursal = reader.GetInt32(0),
                            Id_direccion = reader.IsDBNull(1) ? (int?)null : reader.GetInt32(1),
                            Id_cuenta = reader.IsDBNull(2) ? (int?)null : reader.GetInt32(2),
                            Nombre_sucursal = reader.IsDBNull(3) ? null : reader.GetString(3),
                            Hora_cierre = reader.IsDBNull(4) ? null : reader.GetString(4),
                            Hora_apertura = reader.IsDBNull(5) ? null : reader.GetString(5)
                        };
                        sucursales.Add(sucursal);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las sucursales.", ex);
            }
            finally
            {
                con.CerrarConexion();
            }

            return sucursales;
        }

        public List<Direccion> GetDireccion()
        {
            List<Direccion> direcciones = new List<Direccion>();
            string query = "SELECT id_direccion,id_distrito, descripcion, referencia FROM direcciones";

            try
            {
                con.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, con.Conexion_))
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
                con.CerrarConexion();
            }

            return direcciones;
        }

        public List<Cuenta> GetCuentas()
        {
            List<Cuenta> cuentas = new List<Cuenta>();
            string query = "SELECT id_cuenta,numero_cuenta, banco, id_categoria_cuenta FROM cuenta";

            try
            {
                con.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, con.Conexion_))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cuenta direccion = new Cuenta
                        {
                            Id_cuenta = reader.GetInt32(0),
                            Numero_cuenta = reader.GetString(1),
                            Banco = reader.GetString(2),
                            Id_categortia_cuenta = reader.GetInt32(3),
                        };
                        cuentas.Add(direccion);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los direcciones.", ex);
            }
            finally
            {
                con.CerrarConexion();
            }

            return cuentas;
        }

        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            string query = @"select cl.id_cliente, cl.nombre as Nombre, cl.apellido as Apellido, cl.dui as Dui, cu.numero_cuenta as cuenta,
			cl.direccion as Direccion, cl.correo as Correo, cl.fecha_registro as Registro,
			su.nombre_sucursal as Sucursal, cl.telefono as Telefono
			from cliente cl
			inner join cuenta cu on cl.id_cuenta = cu.id_cuenta
			inner join sucursal su on cl.id_sucursal = su.id_sucursal";

            try
            {
                con.AbrirConexion();
                using (SqlCommand command = new SqlCommand(query, con.Conexion_))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente
                        {
                            Id_cliente = reader.GetInt32(reader.GetOrdinal("id_cliente")),
                            Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                            Apellido = reader.GetString(reader.GetOrdinal("Apellido")),
                            Dui = reader.GetString(reader.GetOrdinal("Dui")),
                            Id_cuenta = reader.GetInt32(reader.GetOrdinal("cuenta")),
                            Direccion = reader.GetString(reader.GetOrdinal("Direccion")),
                            Correo = reader.GetString(reader.GetOrdinal("Correo")),
                            Fecha_registro = reader.GetDateTime(reader.GetOrdinal("Registro")),
                            Id_sucursal = reader.GetInt32(reader.GetOrdinal("Sucursal")),
                            Telefono = reader.GetString(reader.GetOrdinal("Telefono")),
                        };
                        clientes.Add(cliente);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los proyectos: " + ex.Message, ex);
            }
            finally
            {
                con.CerrarConexion();
            }

            return clientes;
        }
    











}
}
