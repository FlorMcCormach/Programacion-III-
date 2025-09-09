namespace WinApp
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListadoArticulo = new System.Windows.Forms.Button();
            this.lblGesDeArticulos = new System.Windows.Forms.Label();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListadoArticulo
            // 
            this.btnListadoArticulo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnListadoArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnListadoArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListadoArticulo.Location = new System.Drawing.Point(226, 127);
            this.btnListadoArticulo.Name = "btnListadoArticulo";
            this.btnListadoArticulo.Size = new System.Drawing.Size(117, 37);
            this.btnListadoArticulo.TabIndex = 0;
            this.btnListadoArticulo.Text = "Listado de Articulos";
            this.btnListadoArticulo.UseVisualStyleBackColor = true;
            this.btnListadoArticulo.Click += new System.EventHandler(this.btnListadoArticulo_Click);
            // 
            // lblGesDeArticulos
            // 
            this.lblGesDeArticulos.AutoSize = true;
            this.lblGesDeArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGesDeArticulos.Location = new System.Drawing.Point(148, 56);
            this.lblGesDeArticulos.Name = "lblGesDeArticulos";
            this.lblGesDeArticulos.Size = new System.Drawing.Size(285, 31);
            this.lblGesDeArticulos.TabIndex = 1;
            this.lblGesDeArticulos.Text = "Gestion de Articulos ";
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBuscarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnBuscarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarArticulo.Location = new System.Drawing.Point(226, 181);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(117, 32);
            this.btnBuscarArticulo.TabIndex = 2;
            this.btnBuscarArticulo.Text = "Buscar Articulo";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 574);
            this.Controls.Add(this.btnBuscarArticulo);
            this.Controls.Add(this.lblGesDeArticulos);
            this.Controls.Add(this.btnListadoArticulo);
            this.MinimumSize = new System.Drawing.Size(634, 489);
            this.Name = "FormPrincipal";
            this.Text = "Gestion de Articulos ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListadoArticulo;
        private System.Windows.Forms.Label lblGesDeArticulos;
        private System.Windows.Forms.Button btnBuscarArticulo;
    }
}

