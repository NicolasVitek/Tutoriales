namespace TreeView
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnAgregarNodo = new System.Windows.Forms.Button();
            this.btnAgregarElemento = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(163, 257);
            this.treeView1.TabIndex = 0;
            // 
            // txtNodo
            // 
            this.txtNodo.Location = new System.Drawing.Point(214, 12);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(100, 20);
            this.txtNodo.TabIndex = 1;
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(214, 47);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(100, 20);
            this.txtElemento.TabIndex = 2;
            // 
            // btnAgregarNodo
            // 
            this.btnAgregarNodo.Location = new System.Drawing.Point(364, 8);
            this.btnAgregarNodo.Name = "btnAgregarNodo";
            this.btnAgregarNodo.Size = new System.Drawing.Size(105, 23);
            this.btnAgregarNodo.TabIndex = 3;
            this.btnAgregarNodo.Text = "Agregar Nodo";
            this.btnAgregarNodo.UseVisualStyleBackColor = true;
            this.btnAgregarNodo.Click += new System.EventHandler(this.btnAgregarNodo_Click);
            // 
            // btnAgregarElemento
            // 
            this.btnAgregarElemento.Location = new System.Drawing.Point(364, 45);
            this.btnAgregarElemento.Name = "btnAgregarElemento";
            this.btnAgregarElemento.Size = new System.Drawing.Size(105, 23);
            this.btnAgregarElemento.TabIndex = 4;
            this.btnAgregarElemento.Text = "Agregar Elemento";
            this.btnAgregarElemento.UseVisualStyleBackColor = true;
            this.btnAgregarElemento.Click += new System.EventHandler(this.btnAgregarElemento_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(364, 83);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar arbol";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(364, 122);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar nodo";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 376);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregarElemento);
            this.Controls.Add(this.btnAgregarNodo);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.txtNodo);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnAgregarNodo;
        private System.Windows.Forms.Button btnAgregarElemento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

