namespace UserSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkImportado = new System.Windows.Forms.CheckBox();
            this.chkOrganico = new System.Windows.Forms.CheckBox();
            this.rbCiruela = new System.Windows.Forms.RadioButton();
            this.rbManzana = new System.Windows.Forms.RadioButton();
            this.rbPera = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(48, 47);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(100, 20);
            this.txtMensaje.TabIndex = 0;
            this.txtMensaje.TextChanged += new System.EventHandler(this.txtMensaje_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.rbPera);
            this.groupBox1.Controls.Add(this.rbManzana);
            this.groupBox1.Controls.Add(this.rbCiruela);
            this.groupBox1.Controls.Add(this.chkOrganico);
            this.groupBox1.Controls.Add(this.chkImportado);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(48, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chkImportado
            // 
            this.chkImportado.AutoSize = true;
            this.chkImportado.Location = new System.Drawing.Point(127, 21);
            this.chkImportado.Name = "chkImportado";
            this.chkImportado.Size = new System.Drawing.Size(73, 17);
            this.chkImportado.TabIndex = 0;
            this.chkImportado.Text = "Importado";
            this.chkImportado.UseVisualStyleBackColor = true;
            this.chkImportado.CheckStateChanged += new System.EventHandler(this.chkImportado_CheckStateChanged);
            // 
            // chkOrganico
            // 
            this.chkOrganico.AutoSize = true;
            this.chkOrganico.Location = new System.Drawing.Point(127, 44);
            this.chkOrganico.Name = "chkOrganico";
            this.chkOrganico.Size = new System.Drawing.Size(69, 17);
            this.chkOrganico.TabIndex = 1;
            this.chkOrganico.Text = "Organico";
            this.chkOrganico.UseVisualStyleBackColor = true;
            this.chkOrganico.CheckStateChanged += new System.EventHandler(this.chkOrganico_CheckStateChanged);
            // 
            // rbCiruela
            // 
            this.rbCiruela.AutoSize = true;
            this.rbCiruela.Location = new System.Drawing.Point(7, 21);
            this.rbCiruela.Name = "rbCiruela";
            this.rbCiruela.Size = new System.Drawing.Size(57, 17);
            this.rbCiruela.TabIndex = 2;
            this.rbCiruela.TabStop = true;
            this.rbCiruela.Text = "Ciruela";
            this.rbCiruela.UseVisualStyleBackColor = true;
            this.rbCiruela.CheckedChanged += new System.EventHandler(this.rbCiruela_CheckedChanged);
            // 
            // rbManzana
            // 
            this.rbManzana.AutoSize = true;
            this.rbManzana.Location = new System.Drawing.Point(7, 66);
            this.rbManzana.Name = "rbManzana";
            this.rbManzana.Size = new System.Drawing.Size(69, 17);
            this.rbManzana.TabIndex = 3;
            this.rbManzana.TabStop = true;
            this.rbManzana.Text = "Manzana";
            this.rbManzana.UseVisualStyleBackColor = true;
            this.rbManzana.CheckedChanged += new System.EventHandler(this.rbManzana_CheckedChanged);
            // 
            // rbPera
            // 
            this.rbPera.AutoSize = true;
            this.rbPera.Location = new System.Drawing.Point(7, 43);
            this.rbPera.Name = "rbPera";
            this.rbPera.Size = new System.Drawing.Size(47, 17);
            this.rbPera.TabIndex = 4;
            this.rbPera.TabStop = true;
            this.rbPera.Text = "Pera";
            this.rbPera.UseVisualStyleBackColor = true;
            this.rbPera.CheckedChanged += new System.EventHandler(this.rbPera_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 351);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPera;
        private System.Windows.Forms.RadioButton rbManzana;
        private System.Windows.Forms.RadioButton rbCiruela;
        private System.Windows.Forms.CheckBox chkOrganico;
        private System.Windows.Forms.CheckBox chkImportado;
    }
}

