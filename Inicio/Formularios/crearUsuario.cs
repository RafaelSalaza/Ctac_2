using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace Inicio.Formularios
{
    public partial class crearUsuario : Form
    {
        private UsuarioDAO usuarioDAO;
        private bool errorMostrado = false;


        public crearUsuario()
            {
                InitializeComponent();

            var conexion = new Conexion();
            usuarioDAO = new UsuarioDAO(conexion); ;
           

            CargarRoles();

            dgvUsuario.AllowUserToAddRows = false;

        }

        

        private void CargarRoles()
        {
            try
            {
   
                var roles = usuarioDAO.ObtenerRoles();

               
                cmbRol.DataSource = roles;
                cmbRol.DisplayMember = "NombreRol";
                cmbRol.ValueMember = "IdRol";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los roles: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string clave = txtClave.Text;
            string nombreUsuario = txtNombreUsuario.Text;
            string codigoUsuario = txtCodigoUsuario.Text;
            int idRol = (int)cmbRol.SelectedValue;

            try
            {
                usuarioDAO.CrearUsuario(clave, nombreUsuario, codigoUsuario, idRol);

                if (!errorMostrado) 
                {
                    
                    CargarUsuarios();

                }
            }
            catch (Exception ex)
            {
                errorMostrado = true; 
                MessageBox.Show("Error al crear el usuario: " + ex.Message);
            }
        }
        private void CargarUsuarios()
        {
            try
            {
                DataTable usuarios = usuarioDAO.ObtenerUsuarios();
                dgvUsuario.DataSource = usuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message);
            }
        }

        private void crearUsuario_Load(object sender, EventArgs e)
        {
            this.txtIdUsuario.Enabled= false;
            CargarUsuarios();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
        private void GuardarCambiosUsuario()
        {
            int idUsuario = Convert.ToInt32(txtIdUsuario.Text);
            string clave = txtClave.Text;
            string nombreUsuario = txtNombreUsuario.Text;
            string codigoUsuario = txtCodigoUsuario.Text;
            int idRol = Convert.ToInt32(cmbRol.SelectedValue); 

            try
            {
                usuarioDAO.ActualizarUsuario(idUsuario, clave, nombreUsuario, codigoUsuario, idRol);
               
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message);
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdUsuario.Text))
            {
                MessageBox.Show("Debe seleccionar un usuario antes de guardar los cambios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GuardarCambiosUsuario();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuario.Rows[e.RowIndex];
                int idUsuario = Convert.ToInt32(row.Cells["id_usuario"].Value);
                string clave = row.Cells["clave"].Value.ToString();
                string nombreUsuario = row.Cells["nombre_usuario"].Value.ToString();
                string codigoUsuario = row.Cells["codigo_usuario"].Value.ToString();
                int idRol = Convert.ToInt32(row.Cells["id_rol"].Value);

                txtIdUsuario.Text = idUsuario.ToString();
                txtClave.Text = clave;
                txtNombreUsuario.Text = nombreUsuario;
                txtCodigoUsuario.Text = codigoUsuario;
                cmbRol.SelectedValue = idRol;
            }
            else
            {
                
                LimpiarControlesEdicion();
            }

        }
        private void LimpiarControlesEdicion()
        {
            txtIdUsuario.Text = "";
            txtClave.Text = "";
            txtNombreUsuario.Text = "";
            txtCodigoUsuario.Text = "";
            cmbRol.SelectedIndex = -1; 
        }
    }
}
