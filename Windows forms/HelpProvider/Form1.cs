using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //PROPIEDAD HELPBUTTON EN TRUE
            //PROPIEDADES MAXIMUM BOX Y MINIMUM BOX EN FALSE.
        }

        private void btnMostar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = txtMensaje.Text;
        }
    }
}
