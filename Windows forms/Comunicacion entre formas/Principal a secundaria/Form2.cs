using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal_a_secundaria
{
    public partial class Form2 : Form
    {
        private string comentario;

        public string Comentario
        {
            set { comentario = value;
                lblComentario.Text = comentario;
            }
        }


        public Form2(string pmensaje)
        {
            InitializeComponent();
            lblMensaje.Text = pmensaje;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
