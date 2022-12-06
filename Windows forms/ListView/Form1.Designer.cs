namespace ListView
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
            this.lstvAlimentos = new System.Windows.Forms.ListView();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.grbGrupos = new System.Windows.Forms.GroupBox();
            this.rbtCarnes = new System.Windows.Forms.RadioButton();
            this.rbtFrutas = new System.Windows.Forms.RadioButton();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.grbGrupos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvAlimentos
            // 
            this.lstvAlimentos.HideSelection = false;
            this.lstvAlimentos.Location = new System.Drawing.Point(12, 12);
            this.lstvAlimentos.Name = "lstvAlimentos";
            this.lstvAlimentos.Size = new System.Drawing.Size(419, 205);
            this.lstvAlimentos.TabIndex = 0;
            this.lstvAlimentos.UseCompatibleStateImageBehavior = false;
            this.lstvAlimentos.View = System.Windows.Forms.View.SmallIcon;
            this.lstvAlimentos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstvAlimentos_MouseClick);
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(12, 270);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(100, 20);
            this.txtElemento.TabIndex = 1;
            // 
            // grbGrupos
            // 
            this.grbGrupos.Controls.Add(this.btnAgregar);
            this.grbGrupos.Controls.Add(this.rbtCarnes);
            this.grbGrupos.Controls.Add(this.rbtFrutas);
            this.grbGrupos.Location = new System.Drawing.Point(121, 251);
            this.grbGrupos.Name = "grbGrupos";
            this.grbGrupos.Size = new System.Drawing.Size(200, 100);
            this.grbGrupos.TabIndex = 2;
            this.grbGrupos.TabStop = false;
            this.grbGrupos.Text = "Grupos";
            // 
            // rbtCarnes
            // 
            this.rbtCarnes.AutoSize = true;
            this.rbtCarnes.Location = new System.Drawing.Point(7, 43);
            this.rbtCarnes.Name = "rbtCarnes";
            this.rbtCarnes.Size = new System.Drawing.Size(58, 17);
            this.rbtCarnes.TabIndex = 1;
            this.rbtCarnes.Text = "Carnes";
            this.rbtCarnes.UseVisualStyleBackColor = true;
            // 
            // rbtFrutas
            // 
            this.rbtFrutas.AutoSize = true;
            this.rbtFrutas.Checked = true;
            this.rbtFrutas.Location = new System.Drawing.Point(7, 20);
            this.rbtFrutas.Name = "rbtFrutas";
            this.rbtFrutas.Size = new System.Drawing.Size(54, 17);
            this.rbtFrutas.TabIndex = 0;
            this.rbtFrutas.TabStop = true;
            this.rbtFrutas.Text = "Frutas";
            this.rbtFrutas.UseVisualStyleBackColor = true;
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Location = new System.Drawing.Point(459, 72);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(35, 13);
            this.lblSeleccionar.TabIndex = 3;
            this.lblSeleccionar.Text = "label1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(119, 17);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(462, 31);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(350, 268);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(100, 20);
            this.txtImagen.TabIndex = 5;
            this.txtImagen.Text = "0";
            this.txtImagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(350, 305);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(462, 107);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 391);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblSeleccionar);
            this.Controls.Add(this.grbGrupos);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.lstvAlimentos);
            this.Name = "Form1";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbGrupos.ResumeLayout(false);
            this.grbGrupos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvAlimentos;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.GroupBox grbGrupos;
        private System.Windows.Forms.RadioButton rbtCarnes;
        private System.Windows.Forms.RadioButton rbtFrutas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
    }
}

