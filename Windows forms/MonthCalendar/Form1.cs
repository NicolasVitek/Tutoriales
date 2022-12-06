using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.BoldedDates = new DateTime[]
            {
                //LA PROPIEDAD MOTHLYBOLDEDDATES PERMITES SELECCIONAR
                //UN DIA Y QUE SE ENMARQUEN TODOS ESOS DIAS DE LOS MESES
                //DEL ALMANAQUE.
                new DateTime(2020,8,23),
                new DateTime(2020,8,20),

            };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime inicio = monthCalendar1.SelectionStart;
            DateTime final = monthCalendar1.SelectionEnd;
            lblInicio.Text = inicio.ToString();
            lblFinal.Text = final.ToString();

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblMensaje.Text = monthCalendar1.SelectionRange.ToString();
        }
    }
}
