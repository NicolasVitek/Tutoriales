using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creacion_de_controles
{
    public partial class Form1 : Form
    {
        private int y = 58;
        private int conteo = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //CREAMOS LA INSTANCIA DEL BOTON
            Button temp = new Button();
            //COLOCAMOS LAS PROPIEDADES
            temp.Height = 23;
            temp.Width = 200;
            temp.Location = new Point(50, y);
            y += 25;
            temp.Name = "btnBoton" + conteo.ToString();
            temp.Text = "Boton &" + conteo.ToString();
            conteo++;
            //ADICIONAMOS EL MANEJADOR
            temp.Click += new EventHandler(handlerComun_Click);
            //ADICIONAMOS EL BOTON A LA FORMA
            Controls.Add(temp);    

        }
        private void handlerComun_Click(object sender, EventArgs e)
        {
            Console.Beep(((Button)sender).Location.Y * 10, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void miBoton1_Click(object sender, EventArgs e)
        {
            miBoton1.Activado = !miBoton1.Activado;
        }
    }
}
