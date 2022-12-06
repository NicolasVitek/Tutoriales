namespace WindowsFormsApp1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.rbnBasico = new System.Windows.Forms.RadioButton();
            this.rbnAterceros = new System.Windows.Forms.RadioButton();
            this.rbnTotal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbEquipamiento = new System.Windows.Forms.GroupBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.chkAire = new System.Windows.Forms.CheckBox();
            this.chkSistema = new System.Windows.Forms.CheckBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.txtCotizacion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gbEquipamiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Location = new System.Drawing.Point(6, 25);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(41, 13);
            this.lblSeguro.TabIndex = 2;
            this.lblSeguro.Text = "Seguro";
            // 
            // rbnBasico
            // 
            this.rbnBasico.AutoSize = true;
            this.rbnBasico.Checked = true;
            this.rbnBasico.Location = new System.Drawing.Point(58, 40);
            this.rbnBasico.Name = "rbnBasico";
            this.rbnBasico.Size = new System.Drawing.Size(57, 17);
            this.rbnBasico.TabIndex = 3;
            this.rbnBasico.TabStop = true;
            this.rbnBasico.Text = "Basico";
            this.rbnBasico.UseVisualStyleBackColor = true;
            // 
            // rbnAterceros
            // 
            this.rbnAterceros.AutoSize = true;
            this.rbnAterceros.Location = new System.Drawing.Point(58, 63);
            this.rbnAterceros.Name = "rbnAterceros";
            this.rbnAterceros.Size = new System.Drawing.Size(73, 17);
            this.rbnAterceros.TabIndex = 4;
            this.rbnAterceros.Text = "A terceros";
            this.rbnAterceros.UseVisualStyleBackColor = true;
            // 
            // rbnTotal
            // 
            this.rbnTotal.AutoSize = true;
            this.rbnTotal.Location = new System.Drawing.Point(58, 86);
            this.rbnTotal.Name = "rbnTotal";
            this.rbnTotal.Size = new System.Drawing.Size(49, 17);
            this.rbnTotal.TabIndex = 5;
            this.rbnTotal.Text = "Total";
            this.rbnTotal.UseVisualStyleBackColor = true;
            this.rbnTotal.CheckedChanged += new System.EventHandler(this.rbnTotal_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnTotal);
            this.groupBox1.Controls.Add(this.rbnAterceros);
            this.groupBox1.Controls.Add(this.rbnBasico);
            this.groupBox1.Controls.Add(this.lblSeguro);
            this.groupBox1.Location = new System.Drawing.Point(4, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 116);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seguro a seleccionar";
            // 
            // gbEquipamiento
            // 
            this.gbEquipamiento.Controls.Add(this.chkSistema);
            this.gbEquipamiento.Controls.Add(this.chkAire);
            this.gbEquipamiento.Controls.Add(this.lblEquipo);
            this.gbEquipamiento.Location = new System.Drawing.Point(181, 50);
            this.gbEquipamiento.Name = "gbEquipamiento";
            this.gbEquipamiento.Size = new System.Drawing.Size(200, 113);
            this.gbEquipamiento.TabIndex = 7;
            this.gbEquipamiento.TabStop = false;
            this.gbEquipamiento.Text = "Equipamiento";
            this.gbEquipamiento.Enter += new System.EventHandler(this.gbEquipamiento_Enter);
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(6, 22);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(40, 13);
            this.lblEquipo.TabIndex = 6;
            this.lblEquipo.Text = "Equipo";
            // 
            // chkAire
            // 
            this.chkAire.AutoSize = true;
            this.chkAire.Location = new System.Drawing.Point(60, 38);
            this.chkAire.Name = "chkAire";
            this.chkAire.Size = new System.Drawing.Size(118, 17);
            this.chkAire.TabIndex = 7;
            this.chkAire.Text = "Aire Acondicionado";
            this.chkAire.UseVisualStyleBackColor = true;
            // 
            // chkSistema
            // 
            this.chkSistema.AutoSize = true;
            this.chkSistema.Location = new System.Drawing.Point(60, 61);
            this.chkSistema.Name = "chkSistema";
            this.chkSistema.Size = new System.Drawing.Size(107, 17);
            this.chkSistema.TabIndex = 8;
            this.chkSistema.Text = "Sistema de audio";
            this.chkSistema.UseVisualStyleBackColor = true;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(10, 179);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(34, 13);
            this.lblCosto.TabIndex = 6;
            this.lblCosto.Text = "Costo";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(62, 176);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 8;
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCotizar
            // 
            this.btnCotizar.Location = new System.Drawing.Point(181, 176);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(75, 23);
            this.btnCotizar.TabIndex = 9;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // txtCotizacion
            // 
            this.txtCotizacion.Location = new System.Drawing.Point(12, 218);
            this.txtCotizacion.Multiline = true;
            this.txtCotizacion.Name = "txtCotizacion";
            this.txtCotizacion.Size = new System.Drawing.Size(369, 125);
            this.txtCotizacion.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 355);
            this.Controls.Add(this.txtCotizacion);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.gbEquipamiento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbEquipamiento.ResumeLayout(false);
            this.gbEquipamiento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.RadioButton rbnBasico;
        private System.Windows.Forms.RadioButton rbnAterceros;
        private System.Windows.Forms.RadioButton rbnTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbEquipamiento;
        private System.Windows.Forms.CheckBox chkSistema;
        private System.Windows.Forms.CheckBox chkAire;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.TextBox txtCotizacion;
    }
}

