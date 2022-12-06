using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_a_secundaria
{
    public partial class Form1 : Form
    {
        Form2 miforma2 = new Form2("Saludos");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnvio1_Click(object sender, EventArgs e)
        {
            //CREAMOS LA INSTANCIA DE LA FORMA 2
            // Form2 miforma2 = new Form2(txtMensaje.Text);
            // miforma2.Comentario = "adios";
            miforma2.Comentario = txtMensaje.Text;
            //MOSTRAMOS LA FORMA
            miforma2.Show();
        }

        private void btnEnvio2_Click(object sender, EventArgs e)
        {
            //PARA QUE LA FORMA SEA USADA DESDE ESTE BOTON, QUE HAY CAMBIAR EL LUGAR DE LA CREACION DE LA FORMA 
            miforma2.Comentario = txtMensaje.Text;

        }
    }
}
