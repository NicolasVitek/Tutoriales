using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Form2 : Form
    {
        private string comentario;
        private string mensaje;

        //COMUNICACION ENTRE FORMAS
        public string Comentario
        {
            set
            {
                comentario = value;
                lblComentario.Text = comentario;
            }
        }
        //COMUNICACION ENTRE FORMAS 2
        public string Mensaje
        {
            get
            {
                return mensaje;
            }
        }

       //public Form2(string pMensaje)
        //{
          //  InitializeComponent();
            //COMUNICACION ENTRE FORMAS
            //EL CODIGO VA SIEMPRE DESPUES DE LA INCIALIZACION DEL COMPONENTE
            //lblMensaje.Text = pMensaje;

//        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //CIERRA LA FORMA PERO NO DESTRUYE LA INSTANCIA
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            mensaje = txtMensaje.Text;
            this.Close();
        }
    }
}
