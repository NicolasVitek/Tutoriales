using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Proyecto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            //Permite cambiar el mensaje de la etiqueta haciendo click en el boton.
            lblMensaje.Text = "Hola a todos";
        }

        private void btnDespedida_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "Adios a todos";
            //El this refencia al texto de form1. Le cambia el titulo a la ventana
            this.Text = "Adios";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cuando se carga la ventana la etiqueta se limpia.
            lblMensaje.Text = "";
            lblMen.Text = "";
            lblMensaje2.Text = "";
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }

        private void btnSalu_Click(object sender, EventArgs e)
        {
            //textNombre.Text es el contenido de la caja
            lblMen.Text = textNombre.Text + " es el nombre";
            lblResultado.Text = "";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textA.Text);
            double b = Convert.ToDouble(textB.Text);
            lblResultado.Text = "El resultado es " + (a + b).ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textA.Text);
            double b = Convert.ToDouble(textB.Text);
            lblResultado.Text = "El resultado es " + (a - b).ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textA.Text);
            double b = Convert.ToDouble(textB.Text);
            lblResultado.Text = "El resultado es " + (a * b).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textA.Text);
            double b = Convert.ToDouble(textB.Text);
            lblResultado.Text = "El resultado es " + (a/b).ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int total = 0;
            //.Checked corrobora si esta tildado la casilla
            if (chkMonitor.Checked == true) 
                total = total + 250;
            if (chkMouse.Checked == true)
                total = total + 15;
            if (chkMouse.Checked == true)
                total = total + 20;
            //MessageBox.Show muestra un mensaje en una ventana emergente.
            MessageBox.Show("El total es " + total.ToString());
        }

        private void chkMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMonitor.Checked == true)
            {
                lblMensaje2.Text = "Monitor";
                if (chkMouse.Checked == true)
                {
                    lblMensaje2.Text = "Mouse y monitor";
                    if (chkTeclado.Checked == true)
                    {
                        lblMensaje2.Text = "Los tres items";
                    }
                }
                if (chkTeclado.Checked == true)
                {
                    lblMensaje2.Text = "Teclado y monitor";
                    if (chkMouse.Checked == true)
                    {
                        lblMensaje2.Text = "Los tres items";
                    }
                }
            }
            else
                lblMensaje2.Text = "";
        }

        private void chkTeclado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTeclado.Checked == true)
            {
                lblMensaje2.Text = "Teclado";
                if (chkMouse.Checked == true)
                {
                    lblMensaje2.Text = "Mouse y teclado";
                    if (chkMonitor.Checked == true)
                    {
                        lblMensaje2.Text = "Los tres items";
                    }
                }
                if (chkMonitor.Checked == true)
                {
                    lblMensaje2.Text = "Monitor y teclado";
                    if (chkMouse.Checked == true)
                    {
                        lblMensaje2.Text = "Los tres items";
                    }
                }
            }
            else
                lblMensaje2.Text = "";
        }

        private void chkMouse_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMouse.Checked == true)
            {
                lblMensaje2.Text = "Mouse";
                if (chkTeclado.Checked == true)
                {
                    lblMensaje2.Text = "Teclado y Mouse";
                    if (chkMonitor.Checked==true)
                    {
                        lblMensaje2.Text = "Los tres items";
                    }
                }
                if (chkMonitor.Checked == true)
                {
                    lblMensaje2.Text = "Monitor y Mouse";
                    if (chkTeclado.Checked == true)
                    {
                        lblMensaje2.Text = "Los tres items";
                    }
                }
            }
            else
                lblMensaje2.Text = "";
        }

        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            double r = 0.0;
            double a = Convert.ToDouble(textA.Text);
            double b = Convert.ToDouble(textB.Text);
            if (rbSuma.Checked==true)
            {
                r = a + b;
            }
            if (rbResta.Checked == true)
            {
                r = a - b;
            }
            if (rbMulti.Checked == true)
            {
                r = a * b;
            }
            if (rbDiv.Checked == true)
            {
                r = a / b;
            }
            lblResultado.Text = r.ToString();

        }

    }
}
