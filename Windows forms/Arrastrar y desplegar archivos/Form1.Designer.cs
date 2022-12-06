namespace Arrastrar_y_desplegar_archivos
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
            this.lblArhivo = new System.Windows.Forms.Label();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblArhivo
            // 
            this.lblArhivo.AutoSize = true;
            this.lblArhivo.Location = new System.Drawing.Point(42, 55);
            this.lblArhivo.Name = "lblArhivo";
            this.lblArhivo.Size = new System.Drawing.Size(35, 13);
            this.lblArhivo.TabIndex = 0;
            this.lblArhivo.Text = "label1";
            // 
            // txtContenido
            // 
            this.txtContenido.AllowDrop = true;
            this.txtContenido.Location = new System.Drawing.Point(45, 96);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContenido.Size = new System.Drawing.Size(351, 239);
            this.txtContenido.TabIndex = 1;
            this.txtContenido.TextChanged += new System.EventHandler(this.txtContenido_TextChanged);
            this.txtContenido.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtContenido_DragDrop);
            this.txtContenido.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtContenido_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 360);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.lblArhivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArhivo;
        private System.Windows.Forms.TextBox txtContenido;
    }
}

