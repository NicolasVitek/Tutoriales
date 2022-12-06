using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process_y_NotifyIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void process1_Exited(object sender, EventArgs e)
        {
            //EN LA PROPIEDAD STARTINFO, SECCION FILENAME VA EL NOMBRE
            //DEL EJECUTABLE DEL PROGRAMA Y EN WORKINGDIRECTORY LA RUTA
            //DEL EJECUTABLE
            lblEstado.Text = "Cerrado";
            notifyIcon1.ShowBalloonTip(100, "Alerta", "Notepad cerrado", ToolTipIcon.Info);

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //PERMITIR RECIBIR EVENTOS DEL NOTEPAD. NECESITO SABER
            //CUANDO SE PRODUCE EL EVENTO DE CIERRE DE LA APLICACION    
            prcNotePad.EnableRaisingEvents = true;
            //ARRACANDO EL PROCESO
            prcNotePad.Start();
            lblEstado.Text = "Arrancando..";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            prcNotePad.Kill();

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void esconderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
