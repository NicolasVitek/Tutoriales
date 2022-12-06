using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            //EL EVENTO CLICK DE LOS TRES BOTONES ESTA ASOCIADO
            //A ESTE MANEJADOR
            Console.Beep();
            if (((Button)sender).Name=="btnUno")
            {
                lblMensaje.Text = "Es el boton 1";
            }
            if (((Button)sender).Name == "btnDos")
            {
                lblMensaje.Text = "Es el boton 2";
            }
            if (((Button)sender).Name == "btnTres")
            {
                lblMensaje.Text = "Es el boton 3";
            }
        }
    }
}
