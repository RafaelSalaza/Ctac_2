using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Inicio.Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            Form1 formPrincipal = new Form1();
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void boton_ingresar_Click(object sender, EventArgs e)
        {
            string codigoUsuario = txtCodigo.Text;
            string clave = txtClave.Text;

            try
            {
                Conexion conexion = new Conexion();

                UsuarioDAO usuarioDAO = new UsuarioDAO(conexion);
                Usuario usuario = usuarioDAO.AutenticarUsuario(codigoUsuario, clave);

                if (usuario != null)
                {
                    MessageBox.Show($"Inicio de sesión exitoso.\nBienvenido {usuario.NombreUsuario}.");
                   
                   
                    Form1 formPrincipal = new Form1();
                    formPrincipal.IdUsuario = usuario.IdUsuario;

                    formPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                    txtClave.Text = "";
             
                }

                conexion.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
