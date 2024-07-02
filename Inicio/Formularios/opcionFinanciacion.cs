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
    public partial class opcionFinanciacion : Form
    {
        public opcionFinanciacion()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CrearFinanciacion form = new CrearFinanciacion();
            AddOwnedForm(form);
            //form.IdSucursal = this.IdSucursal;
            //form.IdUsuario = this.IdUsuario;
            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void Calcularfinan_Click(object sender, EventArgs e)
        {
            CalcularFinanciacion form = new CalcularFinanciacion();
            AddOwnedForm(form);
            //form.IdSucursal = this.IdSucursal;
            //form.IdUsuario = this.IdUsuario;
            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void Verfinan_Click(object sender, EventArgs e)
        {
            VerFinanciaciones form = new VerFinanciaciones();
            AddOwnedForm(form);
            //form.IdSucursal = this.IdSucursal;
            //form.IdUsuario = this.IdUsuario;
            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void Pagocuotas_Click(object sender, EventArgs e)
        {
            PagarCuota form = new PagarCuota();
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
