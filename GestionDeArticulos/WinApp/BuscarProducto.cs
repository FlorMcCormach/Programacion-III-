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
        private List<Articulo> listaArticulo;
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
                decimal precio;
                if (string.IsNullOrWhiteSpace(txtPrecio.Text))
                {
                    precio = 0;
                    articulo.PrecioArticulo = precio;
                }
                else if (decimal.TryParse(txtPrecio.Text, out precio))
                {
                    articulo.PrecioArticulo = precio;
                }
                
                else
                {
                    MessageBox.Show("Precio no es válido. Ingresá un precio.");
                }

                // se carga el DGV y con el buscarArticulo se realiza la fintracion por distintos criterios
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulo = negocio.buscarArticulo(articulo);
                dgvBuscar.DataSource = listaArticulo;
                // Verificar que hay artículos y que tienen imágenes
                if (listaArticulo.Count > 0 && listaArticulo[0].Imagenes != null && listaArticulo[0].Imagenes.Count > 0)
                {
                    pbxArticulo.Load(listaArticulo[0].Imagenes[0].ImagenUrl);
                }else
                {
                    // Limpiar la imagen cuando no hay imágenes disponibles
                    pbxArticulo.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw ex;
            }
        }
    }
}
