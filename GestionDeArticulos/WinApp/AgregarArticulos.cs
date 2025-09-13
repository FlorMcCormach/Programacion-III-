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
            this.articulo = articulo;
            Text = "Modificar Artículo";
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
           
            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.CodigoArticulo = txtbCodigo.Text;
                articulo.NombreArticulo = txtbNombre.Text;
                articulo.DescripcionArticulo = txtbDescripcion.Text;
                articulo.PrecioArticulo = decimal.Parse(txtbPrecio.Text);
                articulo.Marca = (Marca)cboxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboxCategoria.SelectedItem;

                //consulta para saber si es una modificacion, caso contrario es un alta
                if (articulo.IdArticulo > 0)
                {
                    articuloNegocio.modificar(articulo);                 

                }
                else
                {
                    //si es 0 es un alta
                }

                Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

