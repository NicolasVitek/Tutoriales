namespace Creacion_de_controles
{
    partial class Form1
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.ncControlcs1 = new Creacion_de_controles.NCControlcs();
            this.miBoton1 = new Creacion_de_controles.MiBoton();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(31, 36);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // ncControlcs1
            // 
            this.ncControlcs1.Location = new System.Drawing.Point(184, 36);
            this.ncControlcs1.Name = "ncControlcs1";
            this.ncControlcs1.Size = new System.Drawing.Size(75, 23);
            this.ncControlcs1.TabIndex = 2;
            this.ncControlcs1.Text = "ncControlcs1";
            this.ncControlcs1.UseVisualStyleBackColor = true;
            // 
            // miBoton1
            // 
            this.miBoton1.Activado = false;
            this.miBoton1.Location = new System.Drawing.Point(187, 206);
            this.miBoton1.Name = "miBoton1";
            this.miBoton1.Size = new System.Drawing.Size(75, 23);
            this.miBoton1.TabIndex = 3;
            this.miBoton1.Text = "hola";
            this.miBoton1.Click += new System.EventHandler(this.miBoton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 369);
            this.Controls.Add(this.miBoton1);
            this.Controls.Add(this.ncControlcs1);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "Form1";
            this.Text = " hol ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private NCControlcs ncControlcs1;
        private MiBoton miBoton1;
    }
}

