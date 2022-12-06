using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableLayoutPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //PROPIEDAD COLUMNSPAWN EN 2
            //Si SE AGREGA UNA NUEVA SEGUNDA COLUMNA EL BOTON LA 
            //VA A ABARCAR TAMBIEN Y SU COLUMNSPAWN SERA DE 3
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //PROPIEDAD ROWSPAWN EN 2
            //Si SE AGREGA UNA NUEVA SEGUNDA FILA EL BOTON LA 
            //VA A ABARCAR TAMBIEN Y SU ROWSPAWN SERA DE 3
        }
    }
}
