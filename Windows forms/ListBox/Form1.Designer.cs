namespace ListBox
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
            this.lstbFrutas = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtFrutas = new System.Windows.Forms.TextBox();
            this.lblFruta = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbFrutas
            // 
            this.lstbFrutas.FormattingEnabled = true;
            this.lstbFrutas.Items.AddRange(new object[] {
            "Manzana",
            "Pera",
            "Sandia"});
            this.lstbFrutas.Location = new System.Drawing.Point(12, 94);
            this.lstbFrutas.Name = "lstbFrutas";
            this.lstbFrutas.Size = new System.Drawing.Size(120, 95);
            this.lstbFrutas.TabIndex = 0;
            this.lstbFrutas.SelectedIndexChanged += new System.EventHandler(this.lstbFrutas_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(182, 26);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtFrutas
            // 
            this.txtFrutas.Location = new System.Drawing.Point(13, 26);
            this.txtFrutas.Name = "txtFrutas";
            this.txtFrutas.Size = new System.Drawing.Size(100, 20);
            this.txtFrutas.TabIndex = 2;
            // 
            // lblFruta
            // 
            this.lblFruta.AutoSize = true;
            this.lblFruta.Location = new System.Drawing.Point(13, 62);
            this.lblFruta.Name = "lblFruta";
            this.lblFruta.Size = new System.Drawing.Size(35, 13);
            this.lblFruta.TabIndex = 3;
            this.lblFruta.Text = "label1";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(277, 26);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 332);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblFruta);
            this.Controls.Add(this.txtFrutas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstbFrutas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbFrutas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtFrutas;
        private System.Windows.Forms.Label lblFruta;
        private System.Windows.Forms.Button btnBorrar;
    }
}

