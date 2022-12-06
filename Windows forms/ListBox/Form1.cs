using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstbFrutas.Items.Add("Banana");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lstbFrutas.Items.Add(txtFrutas.Text);
            txtFrutas.Text = "";
        }

        private void lstbFrutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = lstbFrutas.SelectedIndex;
            //CUANDO SE BORRA UN ELEMENTO LA SELECCION QUEDA EN EL ELEMENTO -1
            //QUE NO EXISTE Y SALTA ERROR. PARA EVITAR ESO:
            if (indice != -1)
            {
                lblFruta.Text = lstbFrutas.Items[indice].ToString();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //CUANDO SE BORRA UN ELEMENTO LA SELECCION QUEDA EN EL ELEMENTO -1
            //QUE NO EXISTE Y SALTA ERROR. PARA EVITAR ESO:
            if (lstbFrutas.SelectedIndex != -1)
            {
                lstbFrutas.Items.RemoveAt(lstbFrutas.SelectedIndex);
            }

        }
    }
}
