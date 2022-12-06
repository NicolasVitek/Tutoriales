using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btn1Home_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;

        }
    }
}
