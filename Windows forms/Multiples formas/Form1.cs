using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiples_formas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Form2 formados = new Form2();
            formados.Show();
            //CON .SHOWDIALOG() NO SE PUEDE VOLVER A LA FORMA UNO
            //MIENTRAS LA DOS ESTE ABIERTA
        }
    }
}
