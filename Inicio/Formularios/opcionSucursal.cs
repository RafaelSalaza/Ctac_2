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
    public partial class opcionSucursal : Form
    {
        public opcionSucursal()
        {
            InitializeComponent();
        }

        private void AgregarSucursal_Click(object sender, EventArgs e)
        {

            AgregarSucursal form = new AgregarSucursal();
            AddOwnedForm(form);
            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crearDireccion form = new crearDireccion();
            AddOwnedForm(form);
            form.TopLevel = false;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();

        }
    }
}
