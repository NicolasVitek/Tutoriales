namespace Timer
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
            this.components = new System.ComponentModel.Container();
            this.tmrPrueba = new System.Windows.Forms.Timer(this.components);
            this.lblValor = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnDet = new System.Windows.Forms.Button();
            this.tbrIntervalo = new System.Windows.Forms.TrackBar();
            this.lblTvalor = new System.Windows.Forms.Label();
            this.btnReinicio = new System.Windows.Forms.Button();
            this.pbrTrabajo = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbrIntervalo)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrPrueba
            // 
            this.tmrPrueba.Tick += new System.EventHandler(this.tmrPrueba_Tick);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(59, 60);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(35, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "label1";
            // 
            // btnInicio
            // 
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInicio.Location = new System.Drawing.Point(157, 31);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnDet
            // 
            this.btnDet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDet.Location = new System.Drawing.Point(157, 60);
            this.btnDet.Name = "btnDet";
            this.btnDet.Size = new System.Drawing.Size(75, 23);
            this.btnDet.TabIndex = 2;
            this.btnDet.Text = "Detener";
            this.btnDet.UseVisualStyleBackColor = true;
            this.btnDet.Click += new System.EventHandler(this.btnDet_Click);
            // 
            // tbrIntervalo
            // 
            this.tbrIntervalo.Location = new System.Drawing.Point(62, 139);
            this.tbrIntervalo.Maximum = 1000;
            this.tbrIntervalo.Minimum = 100;
            this.tbrIntervalo.Name = "tbrIntervalo";
            this.tbrIntervalo.Size = new System.Drawing.Size(170, 45);
            this.tbrIntervalo.TabIndex = 3;
            this.tbrIntervalo.TickFrequency = 100;
            this.tbrIntervalo.Value = 100;
            this.tbrIntervalo.Scroll += new System.EventHandler(this.tbrIntervalo_Scroll);
            // 
            // lblTvalor
            // 
            this.lblTvalor.AutoSize = true;
            this.lblTvalor.Location = new System.Drawing.Point(130, 171);
            this.lblTvalor.Name = "lblTvalor";
            this.lblTvalor.Size = new System.Drawing.Size(35, 13);
            this.lblTvalor.TabIndex = 4;
            this.lblTvalor.Text = "label1";
            // 
            // btnReinicio
            // 
            this.btnReinicio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReinicio.Location = new System.Drawing.Point(157, 89);
            this.btnReinicio.Name = "btnReinicio";
            this.btnReinicio.Size = new System.Drawing.Size(75, 23);
            this.btnReinicio.TabIndex = 5;
            this.btnReinicio.Text = "Reiniciar";
            this.btnReinicio.UseVisualStyleBackColor = true;
            this.btnReinicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbrTrabajo
            // 
            this.pbrTrabajo.Location = new System.Drawing.Point(62, 207);
            this.pbrTrabajo.Name = "pbrTrabajo";
            this.pbrTrabajo.Size = new System.Drawing.Size(170, 23);
            this.pbrTrabajo.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 305);
            this.Controls.Add(this.pbrTrabajo);
            this.Controls.Add(this.btnReinicio);
            this.Controls.Add(this.lblTvalor);
            this.Controls.Add(this.tbrIntervalo);
            this.Controls.Add(this.btnDet);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.lblValor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbrIntervalo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrPrueba;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnDet;
        private System.Windows.Forms.TrackBar tbrIntervalo;
        private System.Windows.Forms.Label lblTvalor;
        private System.Windows.Forms.Button btnReinicio;
        private System.Windows.Forms.ProgressBar pbrTrabajo;
    }
}

