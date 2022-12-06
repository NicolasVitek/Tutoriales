using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; //LIBRERIA AGREGADA

namespace Audio
{
    public partial class Form1 : Form
    {
        private string ruta ="";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBip_Click(object sender, EventArgs e)
        {
            Console.Beep();
        }

        private void btnTono_Click(object sender, EventArgs e)
        {
            int freq = Convert.ToInt32(txtFrecuencia.Text);
            int dura = Convert.ToInt32(txtDuracion.Text);
            Console.Beep(freq, dura);
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                lblRuta.Text = ruta; 
            }
        }

        private void btnTocar_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = ruta;
                player.Load();
                player.Play();
            }
            catch (Win32Exception)
            {
                MessageBox.Show("No se puede abrir el audio");
               
            }
        }
    }
}
