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
    public partial class opcionesEmpleado : Form
    {
        public opcionesEmpleado()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void CrearUsuario_Click(object sender, EventArgs e)
        {
            crearUsuario form = new crearUsuario();
            AddOwnedForm(form);

            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void crearemepleado_Click(object sender, EventArgs e)
        {
            crearEmpleado form = new crearEmpleado();
            AddOwnedForm(form);

            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void crearcuenta_Click(object sender, EventArgs e)
        {
            crearCuenta form = new crearCuenta();
            AddOwnedForm(form);

            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CrearSueldo form = new CrearSueldo();
            AddOwnedForm(form);

            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();
        }
    }
}
