namespace HelpProvider
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
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnMostar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // txtMensaje
            // 
            this.helpProvider1.SetHelpString(this.txtMensaje, "Coloca ahi el mensaje a mostrar");
            this.txtMensaje.Location = new System.Drawing.Point(29, 54);
            this.txtMensaje.Name = "txtMensaje";
            this.helpProvider1.SetShowHelp(this.txtMensaje, true);
            this.txtMensaje.Size = new System.Drawing.Size(100, 20);
            this.txtMensaje.TabIndex = 0;
            // 
            // btnMostar
            // 
            this.helpProvider1.SetHelpString(this.btnMostar, "Permite mostrar el mensaje");
            this.btnMostar.Location = new System.Drawing.Point(180, 50);
            this.btnMostar.Name = "btnMostar";
            this.helpProvider1.SetShowHelp(this.btnMostar, true);
            this.btnMostar.Size = new System.Drawing.Size(75, 23);
            this.btnMostar.TabIndex = 1;
            this.btnMostar.Text = "Mostrar";
            this.btnMostar.UseVisualStyleBackColor = true;
            this.btnMostar.Click += new System.EventHandler(this.btnMostar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(29, 106);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(35, 13);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 377);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnMostar);
            this.Controls.Add(this.txtMensaje);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnMostar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

