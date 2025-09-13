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
            
            try
            {
                //si es modificacion, cargo los datos del articulo (falta cargar combo box´s) 
                if (articulo != null)
                {
                    txtbCodigo.Text = articulo.CodigoArticulo;
                    txtbNombre.Text = articulo.NombreArticulo;
                    txtbDescripcion.Text = articulo.DescripcionArticulo;
                    txtbPrecio.Text = articulo.PrecioArticulo.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {

            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                if(articulo == null)
                    articulo = new Articulo();


                //consulta para saber si es una modificacion, caso contrario es un alta
                if (articulo.IdArticulo > 0)
                {
                    int idArticulo;
                    articuloNegocio.modificar(articulo);
                    idArticulo = articulo.IdArticulo;

                }
                else 
                { 
                   //si es 0 es un alta
                }
            }
            catch (Exception)
            {

                throw;
            }

            
            Close();
        }

     
    }
}
