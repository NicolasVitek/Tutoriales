using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageList
{
    public partial class form1 : Form
    {
        private int indice;
        public form1()
        {
            InitializeComponent();
            indice = 0;

        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            indice++;
            //PARA QUE RECORRA LAS IMAGENES Y NO SE SALTE EL RANGO
            //DE LOS INDICES:
            if (indice>4)
            {
                indice = 0;
            }
            lblImagen.ImageIndex = indice;

            pcbImagen.Image = imglFotos.Images[indice];
        }

        private void lblImagen_Click(object sender, EventArgs e)
        {
            //PROPIEDAD AUTOSIZE SETEDA EN FALSE. PROPIEDAD SIZE SETEADA
            //CON LAS DIMENSIONES DE LAS IMAGENES. PROPIEDAD IMAGELIST CON
            //EL NOMBRE DEL IMAGELIST CREADO
        }

        private void form1_Load(object sender, EventArgs e)
        {
            pcbImagen.Image = imglFotos.Images[0];
        }
    }
} 
