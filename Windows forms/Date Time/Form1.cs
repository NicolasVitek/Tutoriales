using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date_Time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Today;
            string formato = "MMM ddd d HH mm yyyy";
            lblFecha.Text = fecha.ToString(formato);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            lblDate.Text = fecha.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double dia = Convert.ToDouble(txtDias.Text);
            dateTimePicker1.Value = DateTime.Today.AddDays(dia);
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
