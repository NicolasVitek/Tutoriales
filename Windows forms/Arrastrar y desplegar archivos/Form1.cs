using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrastrar_y_desplegar_archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtContenido_TextChanged(object sender, EventArgs e)
        {
            //PROPIEDAD ALLOWDROP EN TRUE Y MULTILINE EN TRUE. SCROLLBARS
            //EN BOTH. 
        }

        private void txtContenido_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void txtContenido_DragDrop(object sender, DragEventArgs e)
        {
            //OBTENEMOS EL ARREGLO CON LOS ARCHIVOS
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string linea = "";
            lblArhivo.Text = archivos[0];
            //LEEMOS EL ARCHIVO
            StreamReader lector = File.OpenText(archivos[0]);
            while ((linea=lector.ReadLine())!=null)
            {
                txtContenido.Text += linea + "\r\n";
            }
            lector.Close();
        }
    }
}
