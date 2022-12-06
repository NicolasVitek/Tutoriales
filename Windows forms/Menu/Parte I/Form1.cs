using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PROPIEDAD AUTOTOOLTIP EN TRUE y TOOLTIPETEXT MODIFICADA PARA ETIQUETA CUANDO EL PUNTERO
            //ESTA APOYADO SOBRE LA OPCION.
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ejemplo para menu");
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PROPIEDAD SHORTCUTKEYS SON ATAJOS EN EL TECLADO 
            //ESTE MANEJADOR ES COMPARTIDO POR LAS OPCIONES DEL MENU OPERACION Y
            //LOS TOOLSTRIP DE LA BARRA DE HERRAMIENTAS
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double r = a + b;
            lblResultado.Text = r.ToString();

            //STATUSSTRIP O BARRA DE ESTADO
            slblValores.Text = "A=" + a.ToString() + " B=" + b.ToString();
            slblOperacion.Text = "Suma";
            slblResultado.Text = "R=" + r.ToString();
        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ESTE MANEJADOR ES COMPARTIDO POR LAS OPCIONES DEL MENU OPERACION Y
            //LOS TOOLSTRIP DE LA BARRA DE HERRAMIENTAS
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double r = a - b;
            lblResultado.Text = r.ToString();

            //STATUSSTRIP O BARRA DE ESTADO
            slblValores.Text = "A=" + a.ToString() + " B=" + b.ToString();
            slblOperacion.Text = "Resta";
            slblResultado.Text = "R=" + r.ToString();
        }

        private void multiplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ESTE MANEJADOR ES COMPARTIDO POR LAS OPCIONES DEL MENU OPERACION Y
            //LOS TOOLSTRIP DE LA BARRA DE HERRAMIENTAS
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double r = a * b;
            lblResultado.Text = r.ToString();

            //STATUSSTRIP O BARRA DE ESTADO
            slblValores.Text = "A=" + a.ToString() + " B=" + b.ToString();
            slblOperacion.Text = "Multiplicacion";
            slblResultado.Text = "R=" + r.ToString();
        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ESTE MANEJADOR ES COMPARTIDO POR LAS OPCIONES DEL MENU OPERACION Y
            //LOS TOOLSTRIP DE LA BARRA DE HERRAMIENTAS
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double r = a / b;
            lblResultado.Text = r.ToString();

            //STATUSSTRIP O BARRA DE ESTADO
            slblValores.Text = "A=" + a.ToString() + " B=" + b.ToString();
            slblOperacion.Text = "Division";
            slblResultado.Text = "R=" + r.ToString();
        }

        private void habilitarToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            //LA PROPIEDAD CHECKONCLICK HABILITA PARA MARCAR UN TILDE EN EL MENU
            //PROPIEDAD CHECKED EN TRUE. EL EVENTO PARA OPERAR EN ESTE MENU CAMBIA DE CLICK
            // A CHECKEDCHANGED. LA PROPIEDAD ENABLED DE LOS TEXTBOX PERMITEN QUE ESTEN
            //HABILITADOS PARA SU USO.
            txtA.Enabled = habilitarToolStripMenuItem.Checked;
            txtB.Enabled = habilitarToolStripMenuItem.Checked;
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            //PROPIEDAD CONTEXTMENUSTRIP SETEADA EN cmemnuTextA
            //EL MENU CONTEXTUAL SE PUEDE CREAR PARA CUALQUIER CONTROL CON LA PROPIEDAD
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtA.Text = "0";
        }

        private void aleatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //RMD DEVUELVE UN NUMERO ALEATORIO. EL METODO NEXT DEVUELVE UN NUMERO ENTRE UN RANGO.
              Random rmd = new Random();
            int valor = rmd.Next(0, 100);
            txtA.Text = valor.ToString();
        }

    }
}
