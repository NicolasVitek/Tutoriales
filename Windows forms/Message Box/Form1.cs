using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Message_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void btnMostrar2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola", "Saludos");
        }

        private void btnMostrar3_Click(object sender, EventArgs e)
        {
            DialogResult r= MessageBox.Show("Hola", "Saludos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r==DialogResult.Yes)
            {
                lblMensaje.Text = "Apresto Yes";
            }
            if (r == DialogResult.No)
            {
                lblMensaje.Text = "Apresto No";
            }
        }
    }
}
