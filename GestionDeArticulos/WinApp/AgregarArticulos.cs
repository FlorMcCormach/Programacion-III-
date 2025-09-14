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
    public partial class AgregarArticulos : Form
    {
        private Articulo articulo = null;
        public AgregarArticulos()
        {
            InitializeComponent();


        }

        public AgregarArticulos(Articulo articulo)
        {
            InitializeComponent();
            if (articulo == null)
            {
                this.Text = "Agregar Artículo";
                txtbCodigo.Text = " ";
                txtbDescripcion.Text = " ";
                txtbNombre.Text = " ";
                txtbPrecio.Text = "";
                txtUrlImagen.Text = " ";
            }
            else
            {
                this.articulo = articulo;
                Text = "Modificar Artículo";
                btxAgregar.Text = " Modificar";
            }
        }

        private void AgregarArticulos_Load(object sender, EventArgs e)
        {
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

                //si es modificacion, cargo los datos del articulo 
                if (articulo != null)
                {
                    txtbCodigo.Text = articulo.CodigoArticulo;
                    txtbNombre.Text = articulo.NombreArticulo;
                    txtbDescripcion.Text = articulo.DescripcionArticulo;
                    txtbPrecio.Text = articulo.PrecioArticulo.ToString();

                    cboxCategoria.SelectedValue = articulo.Categoria.IdCategoria;
                    cboxMarca.SelectedValue = articulo.Marca.IdMarca;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void Agregar_Click(object sender, EventArgs e)
        {

            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            try
            {

                //articulo = new Articulo();

                if (string.IsNullOrWhiteSpace(txtbCodigo.Text) || string.IsNullOrWhiteSpace(txtbNombre.Text))
                {
                    throw new ArgumentException("Código y nombre son requeridos");
                }
                if (!decimal.TryParse(txtbPrecio.Text, out decimal precio))
                {
                    throw new ArgumentException("El precio debe ser un número válido");
                }

                Articulo nuevoArticulo = new Articulo();
                nuevoArticulo.CodigoArticulo = txtbCodigo.Text;
                nuevoArticulo.NombreArticulo = txtbNombre.Text;
                nuevoArticulo.DescripcionArticulo = txtbDescripcion.Text;
                nuevoArticulo.PrecioArticulo = precio;
                nuevoArticulo.Marca = (Marca)cboxMarca.SelectedItem;
                nuevoArticulo.Categoria = (Categoria)cboxCategoria.SelectedItem;
                //consulta para saber si es una modificacion, caso contrario es un alta
                if (this.articulo != null && this.articulo.IdArticulo != 0)
                {
                    nuevoArticulo.IdArticulo = this.articulo.IdArticulo;
                    articuloNegocio.modificar(nuevoArticulo);
                    MessageBox.Show("Modificado exitosamente");

                }
                else
                {
                    //si es 0 es un alta
                    articuloNegocio.agregarConImagen(nuevoArticulo, txtUrlImagen.Text);
                    MessageBox.Show("Agregado exitosamente");
                }


                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
    }
}

