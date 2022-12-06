using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//LIBRERIA ADICIONAL

namespace ListView
{
    public partial class Form1 : Form
    {
        private ListViewGroup frutas = new ListViewGroup("Frutas", HorizontalAlignment.Center);
        private ListViewGroup carnes = new ListViewGroup("Carnes", HorizontalAlignment.Center);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CREAMDO UN IMAGELIST
            ImageList imagenes = new ImageList();
            imagenes.ImageSize = new Size(256, 256);
            //OBTENIENDO EL LISTADO DE IMAGENES
            string[] archivos = Directory.GetFiles("Frutas");
            //C:\Users\Nicolas\source\repos\Proyecto1\ListView\bin\Debug\Frutas
            //CARGANDO LOS ARCHIVOS
            try
            {
                foreach (string item in archivos)
                {
                    imagenes.Images.Add(Image.FromFile(item));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar", "Advertencia");  
            }
            lstvAlimentos.SmallImageList = imagenes;
            //EL INDICE CORRESPONDE CON EL ORDEN DE LAS IMAGENES EN LA CARPETA
            lstvAlimentos.Items.Add(new ListViewItem("Manzana",0, frutas));
            lstvAlimentos.Items.Add(new ListViewItem("Pera",1, frutas));
            lstvAlimentos.Items.Add(new ListViewItem("Sandia",2, frutas));
            lstvAlimentos.Items.Add(new ListViewItem("Banana",3, frutas));

            lstvAlimentos.Items.Add(new ListViewItem("Pollo", carnes));
            lstvAlimentos.Items.Add(new ListViewItem("Res", carnes));

            lstvAlimentos.Groups.Add(frutas);
            lstvAlimentos.Groups.Add(carnes);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (rbtFrutas.Checked==true)
            {
                lstvAlimentos.Items.Add(new ListViewItem(txtElemento.Text, frutas));
                txtElemento.Text = "";
            }
            if (rbtCarnes.Checked == true)
            {
                lstvAlimentos.Items.Add(new ListViewItem(txtElemento.Text, carnes));
                txtElemento.Text = "";
            }
        }

        private void lstvAlimentos_MouseClick(object sender, MouseEventArgs e)
        {
            lblSeleccionar.Text = lstvAlimentos.SelectedItems[0].SubItems[0].Text;
            //SelectedItems CONTIENE UN ARREGLO DE TODOS LOS ELEMENTOS CLICKEADOS
            //COMO SOLO SE CLICKEA UN ELEMENTO, ESTE ESTARA EN LA POSICION CERO
            //SubItems[0] REPRESENTA LAS COLUMNAS DE LOS DATOS DE LOS ELEMENTOS
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstvAlimentos.Items.Clear();
            lblSeleccionar.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lstvAlimentos.SelectedItems[0].SubItems[0].Text = txtElemento.Text;
            lstvAlimentos.SelectedItems[0].ImageIndex =Convert.ToInt32( txtImagen.Text);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lstvAlimentos.Items.RemoveAt(lstvAlimentos.SelectedIndices[0]);
            //EM SelectedIndices SE ENCUENTRA EL INDICE DE LA IMAGEN QUE ESTA SELECCIONADA
        }
    }
}
