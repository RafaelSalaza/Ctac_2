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
    public partial class opcionesProductos : Form,IFormularioHijo
    {

      public  int IdSucursal { get; set; }
       public int IdUsuario { get; set; }
        public opcionesProductos()
        {
            InitializeComponent();
        }

      



        private void button8_Click(object sender, EventArgs e)
        {
            ProveedorForm form = new ProveedorForm();
            AddOwnedForm(form);

            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Marcaformcs form = new Marcaformcs();
            AddOwnedForm(form);
            
            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();

        }

        private void opcionesProductos_Load(object sender, EventArgs e)
        {

        }

        private void Agregarpruducto_Click(object sender, EventArgs e)
        {

            AgregarProducto form = new AgregarProducto();
            AddOwnedForm(form);
            form.IdSucursal = this.IdSucursal;
            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductosForm form = new ProductosForm();
            AddOwnedForm(form);
            //form.IdSucursal = this.IdSucursal;
            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"IdSucursal: {IdSucursal}, IdUsuario: {IdUsuario}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Compras form = new Compras();
            AddOwnedForm(form);
            form.IdSucursal = this.IdSucursal;
            form.IdUsuario = this.IdUsuario;
            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HistorialCompras form = new HistorialCompras();
            AddOwnedForm(form);
            //form.IdSucursal = this.IdSucursal;
            //form.IdUsuario = this.IdUsuario;
            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();
        }
    }
}
