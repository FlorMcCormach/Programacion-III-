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
        private object txtMarca;

        public BuscarProducto()
        {
            InitializeComponent();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cboxCategoria.DataSource = categoriaNegocio.listar();
                cboxCategoria.ValueMember = "IdCategoria";
                cboxCategoria.DisplayMember = "DescripcionCategoria";

                cboxMarca.DataSource = marcaNegocio.listar();
                cboxMarca.ValueMember = "IdMarca";
                cboxMarca.DisplayMember = "MarcaDescripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void BuscarProducto_Load(object sender, EventArgs e)
        {

            cboxCategoria.Text = "";
            txtCodigo.Text = "";
            cboxMarca.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarImagenArticulo(Articulo articulo)
        {
            if (articulo.Imagenes != null && articulo.Imagenes.Count > 1) // valido que tenga al menos 2 imágenes
            {
                try
                {
                    pbxArticulo.Load(articulo.Imagenes[1].ImagenUrl); // Segunda imagen
                }
                catch (Exception)
                {
                    pbxArticulo.Load("https://dummyimage.com/400x400/cccccc/666666.png?text=Sin+Imagen");
                }
            }
            else if (articulo.Imagenes != null && articulo.Imagenes.Count > 0) // si solo tiene una imagen
            {
                try
                {
                    pbxArticulo.Load(articulo.Imagenes[0].ImagenUrl); // Primera imagen
                }
                catch (Exception)
                {
                    pbxArticulo.Load("https://dummyimage.com/400x400/cccccc/666666.png?text=Sin+Imagen");
                }
            }
            else
            {
                pbxArticulo.Load("https://dummyimage.com/400x400/cccccc/666666.png?text=Sin+Imagen");
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                Articulo articulo = new Articulo();

                // inicializo el objeto anidado
                articulo.Categoria = new Categoria();
                articulo.Categoria.DescripcionCategoria = cboxCategoria.Text;
                articulo.CodigoArticulo = txtCodigo.Text;

                // inicializo el objeto anidado
                articulo.Marca = new Marca();
                articulo.Marca.MarcaDescripcion = cboxMarca.Text;
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
                if (listaArticulo.Count > 0)
                {
                    CargarImagenArticulo(listaArticulo[0]);
                }
                else
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

        private void dgvBuscar_SelectionChanged(object sender, EventArgs e)
        {
            Articulo selecionado = (Articulo)dgvBuscar.CurrentRow.DataBoundItem;
            CargarImagenArticulo(selecionado);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || ((int)Keys.Back == e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }
    }
}
