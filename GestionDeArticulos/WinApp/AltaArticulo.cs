using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace WinApp
{
    public partial class AltaArticulo : Form
    {
        public AltaArticulo()
        {
            InitializeComponent();
        }

        private void AltaArticulo_Load(object sender, EventArgs e)
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
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
