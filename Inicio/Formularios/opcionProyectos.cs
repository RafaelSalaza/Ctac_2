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
    public partial class opcionProyectos : Form,IFormularioHijo
    {


        public int IdSucursal { get; set; }
        public int IdUsuario { get; set; }
        public opcionProyectos()
        {
            InitializeComponent();
        }

        private void AgregarCliente_Click(object sender, EventArgs e)
        {
            AgregarCliente form = new AgregarCliente();
            AddOwnedForm(form);
            //form.IdSucursal = this.IdSucursal;
            form.IdUsuario = this.IdUsuario;
            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void CrearProyecto_Click(object sender, EventArgs e)
        {
            CrearProyecto form = new CrearProyecto();
            AddOwnedForm(form);
            //form.IdSucursal = this.IdSucursal;
            form.IdUsuario = this.IdUsuario;
            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerProyectos form = new VerProyectos();
            AddOwnedForm(form);
            //form.IdSucursal = this.IdSucursal;
            form.IdUsuario = this.IdUsuario;
            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrearComanda form = new CrearComanda();
            AddOwnedForm(form);
            //form.IdSucursal = this.IdSucursal;
            //form.IdUsuario = this.IdUsuario;
            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerComanda form = new VerComanda();
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
