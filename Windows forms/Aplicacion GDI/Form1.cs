using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_GDI
{
    public partial class Form1 : Form
    {
        private int x = 0;
        private int y = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OBTENEMOS EL OBJETO GRAPHICS CON EL HANDLER DE LA FORMA
            Graphics g = Graphics.FromHwnd(this.Handle);
            //SE CREA UNA FUENTE
            Font fuente = new Font("Arial", 35);
            //SE DIBUJA UN TEXTO
            g.DrawString("En metodo", fuente, Brushes.Green, 50, 75);
            //HAY QUE LIBERAR LOS RECURSOS NO ADMINISTRADOS, SI LO CREA
            //MOS DIRECTAMENTE USAMOS DISPOSE, SI ES UNA REFERENCIA A UN
            //OBJETO GRAPIHCS YA EXISTENTE NO HACE FALTA.
            g.Dispose();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //OBTENEMOS EL OBJETO GRAPHICS
            Graphics g = e.Graphics;
            //CREAMOS UNA FUENTE
            Font fuente = new Font("Arial", 35);
            //DIBUJAMOS UN TEXTO
            g.DrawString("En metodo", fuente, Brushes.Red, x, y);
        }

        private void btnInvalidate_Click(object sender, EventArgs e)
        {
            x += 5;
            y += 17;
            //SE FUERZA A REDIBUJAR TODO EL LIENZO
            Invalidate();
        }
    }
}
