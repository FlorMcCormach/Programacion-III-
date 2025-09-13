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
    public partial class ListadoArticulos : Form
    {
        public ListadoArticulos()
        {
            InitializeComponent();
        }

        private void ListadoArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvListadoArticulo.DataSource = negocio.listar();
            dgvListadoArticulo.Columns["IdArticulo"].Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvListadoArticulo.CurrentRow.DataBoundItem;
            AgregarArticulos modificarArticulos = new AgregarArticulos(seleccionado);  
            modificarArticulos.ShowDialog();    
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
