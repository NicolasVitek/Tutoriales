using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_y_MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (chkMonitor.Checked==true)
            {
                total = total + 250;
            }
            if (chkMouse.Checked == true)
            {
                total = total + 20;
            }
            if (chkTeclado.Checked == true)
            {
                total = total + 15;
            }
            MessageBox.Show("El total es " + total.ToString());
        }

        private void chkMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMonitor.Checked == true)
            {
                lblMensaje.Text = "Monitor";
            }
            else
            {
                lblMensaje.Text = "";
            }
        }
    }
}
