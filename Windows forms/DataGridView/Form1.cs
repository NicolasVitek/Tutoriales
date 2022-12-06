using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        private int n;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //ADICIONAMOS NUEVO RENGLON. Rows.Add AGREGA UNA FILA Y DEVUELVE EL INDICE
            int n = dtgvProductos.Rows.Add();
            //COLOCAMOS LA INFORMACION
            dtgvProductos.Rows[n].Cells[0].Value = txtCodigo.Text;
            dtgvProductos.Rows[n].Cells[1].Value = txtNombre.Text;
            dtgvProductos.Rows[n].Cells[2].Value = txtPrecio.Text;
            //LIMPIAMOS LOS TEXTBOX
            txtCodigo.Text = ""; txtNombre.Text = "";  txtPrecio.Text = "";
        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //RowIndex DEVUELVE EL INDICE DE LA CELDA DONDE SE HIZO EL CLICK
            n = e.RowIndex;
            //EN ENCABEZADO ESTA EN EL INDICE -1 Y HAY QUE DESCARTARLO.
            if (n!=-1)
            {
                lblInformacion.Text = dtgvProductos.Rows[n].Cells[1].Value.ToString();
                //HAY QUE CONVERTIRLO A STRING PORQUE DEVUELVE OBJECT
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (n!=1)
            {
                //.RemoveAt BORRA LA FILA ENTERA DEL INDICE PASADO POR PARAMETRO
                dtgvProductos.Rows.RemoveAt(n);
            }
        }
    }
}
