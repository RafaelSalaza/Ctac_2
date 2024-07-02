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
    public partial class opcionVentas : Form, IFormularioHijo
    {

        public int IdSucursal { get; set; }
        public int IdUsuario { get; set; }


        public opcionVentas()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            VentasForm form = new VentasForm();
            AddOwnedForm(form);
            form.IdSucursal = this.IdSucursal;
            form.IdUsuario = this.IdUsuario;
            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void historialVentas_Click(object sender, EventArgs e)
        {
            HistorialVentas form = new HistorialVentas();
            AddOwnedForm(form);
            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void Envios_Click(object sender, EventArgs e)
        {
            EnvioForm form = new EnvioForm();
            AddOwnedForm(form);
            form.IdSucursal = this.IdSucursal;
            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void Agregarclientes_Click(object sender, EventArgs e)
        {
            AgregarCliente form = new AgregarCliente();
            AddOwnedForm(form);
            //form.IdSucursal = this.IdSucursal;
            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();
        }
    }
}
