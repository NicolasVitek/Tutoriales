using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            lblResultado.Text = (a + b).ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            lblResultado.Text = (a - b).ToString();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);

            lblResultado.Text = (a * b).ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            if (b==0)
            {
                lblResultado.Text = "No se puede dividir por cero";
            }
            else
            {
                lblResultado.Text = (a / b).ToString();
            }
            
        }
    }
}
