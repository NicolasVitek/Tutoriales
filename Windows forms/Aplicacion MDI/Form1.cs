using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_MDI
{
    public partial class Form1 : Form
    {
        private Form2 forma;
        public Form1()
        {
            InitializeComponent();
        }

        private void ventana1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (forma ==null)
            {
                //SI NO EXISTE LA INSTANCIA DE LA FORMA SE CREA
                forma = new Form2();
                //ALCARAMOS LA FORMA CONTENEDORA
                forma.MdiParent = this;
                forma.FormClosed += new FormClosedEventHandler(CerrarForma);
                forma.Show();
            }
            else
            {
                forma.Activate();
            }
        }
        void CerrarForma (object sender, FormClosedEventArgs e)
        {
            forma = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //PROPIEDAD ISMDICONTAINER EN TRUE
        }

        private void ventana2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 otraforma = new Form3();
            otraforma.MdiParent = this;
            otraforma.Show();
        }
    }
}
