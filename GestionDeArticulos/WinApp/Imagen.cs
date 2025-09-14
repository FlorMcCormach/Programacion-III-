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
    public partial class Imagen : Form
    {
        public string ImagenIngresada { get; private set; }
        public Imagen()
        {
            InitializeComponent();
        }

        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Load(txtUrlImagen.Text.Trim());
            }
            catch (Exception)
            {

                pictureBox1.ImageLocation = "\\error.jpg";
            }
        }

        private void btxAgregar_Click(object sender, EventArgs e)
        {
            ImagenIngresada = txtUrlImagen.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
