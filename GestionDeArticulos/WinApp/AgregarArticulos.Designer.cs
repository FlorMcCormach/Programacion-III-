namespace WinApp
{
    partial class AgregarArticulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAgregar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtbCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.CboxMarca = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbDescripcion = new System.Windows.Forms.TextBox();
            this.txtbPrecio = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btAgregar.Location = new System.Drawing.Point(474, 254);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 0;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 34);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(95, 20);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo ";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbCodigo
            // 
            this.txtbCodigo.Location = new System.Drawing.Point(112, 34);
            this.txtbCodigo.Name = "txtbCodigo";
            this.txtbCodigo.Size = new System.Drawing.Size(262, 20);
            this.txtbCodigo.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(11, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(95, 20);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(12, 95);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(95, 20);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripcion";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecio.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(12, 125);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(95, 20);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMarca.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(12, 154);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(95, 20);
            this.lblMarca.TabIndex = 7;
            this.lblMarca.Text = "Marca";
            this.lblMarca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CboxMarca
            // 
            this.CboxMarca.AccessibleDescription = "marcas";
            this.CboxMarca.FormattingEnabled = true;
            this.CboxMarca.Items.AddRange(new object[] {
            "Samsung",
            "Iphone",
            "Tcl",
            "Motorola",
            "Xiami",
            "Alcatel",
            "Google",
            "Otros"});
            this.CboxMarca.Location = new System.Drawing.Point(113, 153);
            this.CboxMarca.Name = "CboxMarca";
            this.CboxMarca.Size = new System.Drawing.Size(261, 21);
            this.CboxMarca.TabIndex = 8;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(12, 184);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(95, 20);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblImagen
            // 
            this.lblImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImagen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(12, 213);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(95, 20);
            this.lblImagen.TabIndex = 10;
            this.lblImagen.Text = "Imagen";
            this.lblImagen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleDescription = "marcas";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Samsung",
            "Iphone",
            "Tcl",
            "Motorola",
            "Xiami",
            "Alcatel",
            "Google",
            "Otros"});
            this.comboBox1.Location = new System.Drawing.Point(112, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(112, 65);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(262, 20);
            this.txtbNombre.TabIndex = 12;
            // 
            // txtbDescripcion
            // 
            this.txtbDescripcion.Location = new System.Drawing.Point(113, 95);
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.Size = new System.Drawing.Size(261, 20);
            this.txtbDescripcion.TabIndex = 13;
            // 
            // txtbPrecio
            // 
            this.txtbPrecio.Location = new System.Drawing.Point(112, 127);
            this.txtbPrecio.Name = "txtbPrecio";
            this.txtbPrecio.Size = new System.Drawing.Size(262, 20);
            this.txtbPrecio.TabIndex = 14;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox.Location = new System.Drawing.Point(414, 34);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(154, 171);
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            // 
            // AgregarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.txtbPrecio);
            this.Controls.Add(this.txtbDescripcion);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.CboxMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtbCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btAgregar);
            this.MinimumSize = new System.Drawing.Size(634, 489);
            this.Name = "AgregarArticulos";
            this.Text = "AgregarArticulos";
            this.Load += new System.EventHandler(this.AgregarArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtbCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox CboxMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbDescripcion;
        private System.Windows.Forms.TextBox txtbPrecio;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}