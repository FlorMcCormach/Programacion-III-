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
    

        private void btAgregar_Click(object sender, EventArgs e)
        {


            //consulta para saber si es una modificacion, caso contrario es un alta
            if (articulo.IdArticulo > 0)
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                int idArticulo;
                articuloNegocio.modificar(articulo);
                idArticulo = articulo.IdArticulo;

            }
            Close();
        }
    }
}
