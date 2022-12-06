using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton_y_GroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double r = 0.0;
            double a;
            double b;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            if (rbSuma.Checked)
            {
                r = a + b;
            }
            if (rbResta.Checked)
            {
                r = a - b;
            }
            if (rbProducto.Checked)
            {
                r = a * b;
            }
            if (rbDivision.Checked)
            {
                r = a / b;
            }
            lblResultado.Text = r.ToString();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
