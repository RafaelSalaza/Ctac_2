using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Inicio.Formularios;

namespace Inicio
{
    public partial class Form1 : Form
    {

        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Apellido { get; set; }
        public int IdSucursal { get; set; }
        public string nombreSucursal { get; set; }


        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            UsuarioDAO usuarioDAO = new UsuarioDAO(con);

            // Llamar al método ObtenerInformacionUsuario para obtener los datos del usuario
            (string nombreEmpleado, string apellidoEmpleado, int idSucursal, string nombreSucursal) = usuarioDAO.ObtenerInformacionUsuario(IdUsuario);

            // Asignar los valores obtenidos a las propiedades del formulario
            NombreUsuario = nombreEmpleado;
            Apellido = apellidoEmpleado;
            IdSucursal = idSucursal;
            nombreSucursal = nombreSucursal;


            labelidusuario.Text = IdUsuario.ToString();
            labelnombre.Text = NombreUsuario;
            labelapellido.Text = Apellido;
            labelidsucursal.Text = IdSucursal.ToString();
            NombreSucursal.Text = nombreSucursal;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImportAttribute("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam  );




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (menuvertical.Width == 250)
            {
                menuvertical.Width = 47;
                labelidsucursal.Visible = false;
                labelidusuario.Visible = false;
                labelapellido.Visible = false;
                NombreSucursal.Visible = false;
                labelnombre.Visible = false;
            }
            else
            {
                menuvertical.Width = 250;
                labelidsucursal.Visible = true;
                labelidusuario.Visible = true;
                labelapellido.Visible = true;
                NombreSucursal.Visible = true;
                labelnombre.Visible = true;
            }


        }

        private void iconocerrar_Click(object sender, EventArgs e)
        {

            Application.Exit();
           
        }

        private void iconomaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconomaximizar.Visible = false;
            iconorestaurar.Visible = true;
        }

        private void iconorestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Normal;
            iconorestaurar.Visible = false;
            iconomaximizar.Visible=true;
        }

        private void iconominimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112, 0xf012,0);


        }


        private void AbrirFormenPanel(object hijo)
        {
            if (this.contenedor.Controls.Count > 0)
                this.contenedor.Controls.RemoveAt(0);

            if (hijo is IFormularioHijo formHijo)
            {
                formHijo.IdSucursal = this.IdSucursal;
                formHijo.IdUsuario = this.IdUsuario;
            }

            Form fh = hijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.contenedor.Controls.Add(fh);
            this.contenedor.Tag = fh;
            fh.Show();
        }

        /*private List<Form> formulariosAbiertos = new List<Form>();

        // Método para abrir formularios en el panel
        public void AbrirFormEnPanel(Form formHijo)
        {
            // Ocultar los formularios abiertos antes de agregar uno nuevo
            foreach (Form form in formulariosAbiertos)
            {
                form.Hide();
            }

            // Agregar el nuevo formulario a la lista y mostrarlo en el panel
            formulariosAbiertos.Add(formHijo);
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            this.contenedor.Controls.Add(formHijo);
            this.contenedor.Tag = formHijo;
            formHijo.Show();




        -------------------------------------------------------------------------------


         if (this.contenedor.Controls.Count >0) 
                this.contenedor.Controls.RemoveAt(0);
            Form fh = hijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.contenedor.Controls.Add(fh);
            this.contenedor.Tag = fh;
            fh.Show();









        }*/




        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormenPanel(new opcionRecursos());
        }

        private void botonProductos_Click(object sender, EventArgs e)
        {

            AbrirFormenPanel( new opcionesProductos());

        }

        private void botonempleados_Click(object sender, EventArgs e)
        {
            AbrirFormenPanel(new opcionesEmpleado());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormenPanel(new opcionVentas());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormenPanel(new opcionProyectos());
        }

        private void opcionFinan_Click(object sender, EventArgs e)
        {
            AbrirFormenPanel(new opcionFinanciacion());
        }

        private void botonSucursal_Click(object sender, EventArgs e)
        {
            AbrirFormenPanel(new opcionSucursal());

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void barra_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
