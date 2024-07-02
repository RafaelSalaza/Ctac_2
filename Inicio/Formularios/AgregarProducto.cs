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
    public partial class AgregarProducto : Form

    

    {

        private ProductoDao productoDao;
        //private int sucursalId = formprincipal.Idusuario;
        Conexion con = new Conexion();
        public int IdSucursal { get; set; }


        public AgregarProducto()
        {
            InitializeComponent();

            productoDao = new ProductoDao(con);
            productoDao.CargarProductos(tablaProductos);

            CargarCategorias();
            CargarMarcas();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {

        }




        private void CargarCategorias()
        {
            DataTable categorias = productoDao.CargarCategorias();
            comboCategoria.DataSource = categorias;
            comboCategoria.DisplayMember = "nombre_categoria";
            comboCategoria.ValueMember = "id_categoria_producto";
        }

        private void CargarMarcas()
        {
            DataTable marcas = productoDao.CargarMarcas();
            comboMarca.DataSource = marcas;
            comboMarca.DisplayMember = "nombre";
            comboMarca.ValueMember = "id_marca";
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {


            string nombreProducto = txtNombre.Text;
            string descripcion = txtdescrip.Text;
            int idCategoriaProducto = (int)comboCategoria.SelectedValue;
            int idMarca = (int)comboMarca.SelectedValue;

            // Use the IdSucursal property instead of getting it from a TextBox
            int idSucursal = this.IdSucursal;

            // Create an instance of Producto with the provided data
            Producto producto = new Producto(nombreProducto, descripcion, idSucursal, idCategoriaProducto, idMarca);

            // Add the product using the DAO
            if (productoDao.Agregar(producto))
            {
                MessageBox.Show("Producto agregado exitosamente.");
                productoDao.CargarProductos(tablaProductos);
                txtNombre.Text = "";
                txtdescrip.Text = "";
            }
            else
            {
                MessageBox.Show("Error al agregar el producto.");
            }
        }














    }



    }








    

