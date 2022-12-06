using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                //CARGAMOS EL DOCUMENTO RTF
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //GUARDAMOS EL DOCUMENTO RTF
                richTextBox1.SaveFile(openFileDialog1.FileName,RichTextBoxStreamType.RichText);
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
        }

        private void codigoRTFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string codigo = richTextBox1.SelectedRtf;
            MessageBox.Show(codigo);
        }
    }
}
