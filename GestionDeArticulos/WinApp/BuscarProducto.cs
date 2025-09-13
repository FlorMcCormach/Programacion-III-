using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WinApp
{
    public partial class BuscarProducto : Form
    {
        public BuscarProducto()
        {
            InitializeComponent();
        }

        private void BuscarProducto_Load(object sender, EventArgs e)
        {

            txtCategoria.Text = "";
            txtCodigo.Text = "";
            txtMarca.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                Articulo articulo = new Articulo();

                // inicializo el objeto anidado
                articulo.Categoria = new Categoria();
                articulo.Categoria.DescripcionCategoria = txtCategoria.Text;
                articulo.CodigoArticulo = txtCodigo.Text;

                // inicializo el objeto anidado
                articulo.Marca = new Marca();
                articulo.Marca.MarcaDescripcion = txtMarca.Text;
                articulo.NombreArticulo = txtNombre.Text;

                // se realiza la conversion a decimal
                articulo.PrecioArticulo = decimal.Parse(txtPrecio.Text);

                // la logica se encuentra en Articulos negocio, en el metodo "Busacar Articulo"
               //Falta desarrollar la logia por eso la dejo comentada
                // articuloNegocio.buscarArticulo(articulo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw ex;
            }
        }
    }
}
