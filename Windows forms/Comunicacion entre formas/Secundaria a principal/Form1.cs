using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comunicacion_entre_formas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForma2_Click(object sender, EventArgs e)
        {
            Form2 miforma2 = new Form2();
            DialogResult resultado = miforma2.ShowDialog();
            //miforma2.ShowDialog();
            //SI EL USUARIO CERRO LA FORMA DOS CON EL BOTON OK...
            if (resultado == DialogResult.OK)
            {
                lblMensaje.Text = miforma2.Mensaje;
                lblContenido.Text = miforma2.Contenido;
            }
            if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("No se ejecuto nada");
            }
            //lblMensaje.Text = miforma2.Mensaje;
            //lblContenido.Text = miforma2.Contenido;
        }
    }
}
