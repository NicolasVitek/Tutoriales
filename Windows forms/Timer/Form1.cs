using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        private int conteo;

        public Form1()
        {
            InitializeComponent();
        }

        private void tmrPrueba_Tick(object sender, EventArgs e)
        {
            conteo++;
            lblValor.Text = conteo.ToString();
            //LA BARRA DE PROGRESEO DEBE SER DETENIDA CUANDO LLEGA AL MAXIMO
            //SINO ARROJA UNA EXCEPCION
            if (pbrTrabajo.Value<100)
            {
                pbrTrabajo.Value++;
            }
            if (pbrTrabajo.Value==100)
            {
                tmrPrueba.Enabled = false;
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            //PARA INCIAR EL TIMER
            tmrPrueba.Enabled = true;
            //TAMBIEN SE PUEDE HACER CON tmrPrueba.Start()

            pbrTrabajo.Value = 0;
        }

        private void btnDet_Click(object sender, EventArgs e)
        {
            //PARA DETERNER EL TIMER
            tmrPrueba.Enabled = false;
            //TAMBIEN SE PUEDE HACER CON tmrPrueba.Stop()

            //PARA QUE LA BARRA VUELVA A LA POSICION INICIAL
            tbrIntervalo.Value = 100;
            //TAMBIEN SE EPUEDE HACER CON tbrIntervalo.Minimun

            lblTvalor.Text = tbrIntervalo.Value.ToString();
            //PARA REINICAR EL INTERVALO DE CONTEO
            tmrPrueba.Interval = tbrIntervalo.Value;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //CUANDO SE CIERRA LA FORMA SE CIERRA EL TIMER
            tmrPrueba.Enabled = false;
        }

        private void tbrIntervalo_Scroll(object sender, EventArgs e)
        {
            lblTvalor.Text = tbrIntervalo.Value.ToString();
            tmrPrueba.Interval = tbrIntervalo.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conteo = 0;
            tmrPrueba.Enabled = false;
            tmrPrueba.Start();
            tbrIntervalo.Value = 100;
            lblTvalor.Text = tbrIntervalo.Value.ToString();
            tmrPrueba.Interval = tbrIntervalo.Value;
            pbrTrabajo.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
