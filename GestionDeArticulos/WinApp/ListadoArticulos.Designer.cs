namespace WinApp
{
    partial class ListadoArticulos
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
            this.dgvListadoArticulo = new System.Windows.Forms.DataGridView();
            this.lblListadoArticulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoArticulo
            // 
            this.dgvListadoArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoArticulo.Location = new System.Drawing.Point(24, 90);
            this.dgvListadoArticulo.Name = "dgvListadoArticulo";
            this.dgvListadoArticulo.Size = new System.Drawing.Size(747, 330);
            this.dgvListadoArticulo.TabIndex = 0;
            // 
            // lblListadoArticulo
            // 
            this.lblListadoArticulo.AutoSize = true;
            this.lblListadoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoArticulo.Location = new System.Drawing.Point(268, 26);
            this.lblListadoArticulo.Name = "lblListadoArticulo";
            this.lblListadoArticulo.Size = new System.Drawing.Size(256, 31);
            this.lblListadoArticulo.TabIndex = 1;
            this.lblListadoArticulo.Text = "Listado de Articulo";
            // 
            // ListadoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblListadoArticulo);
            this.Controls.Add(this.dgvListadoArticulo);
            this.Name = "ListadoArticulos";
            this.Text = "ListadoArticulos";
            this.Load += new System.EventHandler(this.ListadoArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoArticulo;
        private System.Windows.Forms.Label lblListadoArticulo;
    }
}