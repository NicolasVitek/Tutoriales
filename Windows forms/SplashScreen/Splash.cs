using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreen
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            //PROPIEDAD FORMBORDERSTYLE EN NONE Y BACKGROUNDIMAGELAYOUT
            //EN STRECH. PROPIEDAD STARTPOSITION EN CENTERSCREEN.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value==100)
            {
                timer1.Stop();
            }
        }
    }
}
