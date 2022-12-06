using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomainUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dopFrutas.Items.Add("Melon");
            dopFrutas.Items.Add("Manzana");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dopFrutas.Items.Add(txtFruta.Text);
            txtFruta.Text = "";

        }

        private void dopFrutas_SelectedItemChanged(object sender, EventArgs e)
        {
            string fruta = dopFrutas.SelectedItem.ToString();
            lblMensaje.Text = "Tu fruta favorita es " + fruta;


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int indice = dopFrutas.SelectedIndex;
            dopFrutas.Items.RemoveAt(indice);
            //DESPUES DEL BORRADO REGRESA LA LISTA AL INICIO
            dopFrutas.SelectedIndex = 0;
        }
    }
}
