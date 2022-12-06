namespace ImageList
{
    partial class form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.imglFotos = new System.Windows.Forms.ImageList(this.components);
            this.lblImagen = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // imglFotos
            // 
            this.imglFotos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglFotos.ImageStream")));
            this.imglFotos.TransparentColor = System.Drawing.Color.Transparent;
            this.imglFotos.Images.SetKeyName(0, "Circulo.png");
            this.imglFotos.Images.SetKeyName(1, "Cuadrado.png");
            this.imglFotos.Images.SetKeyName(2, "Triangulo.png");
            this.imglFotos.Images.SetKeyName(3, "Bitmap1.bmp");
            // 
            // lblImagen
            // 
            this.lblImagen.ImageIndex = 0;
            this.lblImagen.ImageList = this.imglFotos;
            this.lblImagen.Location = new System.Drawing.Point(40, 34);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(100, 100);
            this.lblImagen.TabIndex = 0;
            this.lblImagen.Click += new System.EventHandler(this.lblImagen_Click);
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(43, 167);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 23);
            this.btnCambiar.TabIndex = 1;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // pcbImagen
            // 
            this.pcbImagen.Location = new System.Drawing.Point(161, 34);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(100, 100);
            this.pcbImagen.TabIndex = 2;
            this.pcbImagen.TabStop = false;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 292);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.lblImagen);
            this.Name = "form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imglFotos;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.PictureBox pcbImagen;
    }
}

