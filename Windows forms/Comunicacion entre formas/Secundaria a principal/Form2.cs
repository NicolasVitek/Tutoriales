using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comunicacion_entre_formas
{
    public partial class Form2 : Form
    {
        private string mensaje;
        private string contenido;

        public string Mensaje
        {
            get { return mensaje; }
        }
        public string Contenido
        {
            get { return contenido; }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            mensaje = txtMensaje.Text;
            contenido = txtContenido.Text;
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            //SU PROPIEDAD DIALOGRESULT ESTA SETEADA EN "OK"
            mensaje = txtMensaje.Text;
            contenido = txtContenido.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //SU PROPIEDAD DIALOGRESULT ESTA SETEADA EN "CANCEL"
            this.Close();
        }
    }
}
