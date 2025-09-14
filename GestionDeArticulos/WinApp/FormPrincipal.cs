using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnListadoArticulo_Click(object sender, EventArgs e)
        {
            ListadoArticulos ventana = new ListadoArticulos();
            ventana.ShowDialog();
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            BuscarProducto ventanaBuscarProducto = new BuscarProducto();
            ventanaBuscarProducto.ShowDialog();
        }
    }
}
