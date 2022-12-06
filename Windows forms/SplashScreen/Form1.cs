using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //NUEVA BIBLIOTECA

namespace SplashScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //CREAMOS EL HILO
            Thread t = new Thread(new ThreadStart(SplashStart));
            //ARRANCAMOS EL HILO
            t.Start();
            //PONEMOS A DOMRMIR A LA FORMA PRINCIPAL
            Thread.Sleep(5000);
            InitializeComponent();
            //FINALIZAMOS EL HILO
            t.Abort();
        }
        public void SplashStart()
        {
            //PROCESO DE ARRANQUE DE LA SEGUNDA FORMA
            Application.Run(new Splash());
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
