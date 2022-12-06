using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbnTotal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbEquipamiento_Enter(object sender, EventArgs e)
        {

        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCosto.Text == "")
                {
                    MessageBox.Show("El cambio de costo no puede quedar vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double costo = 0.0;
                    string cotizacion = "";
                    cotizacion = "Cotizacion de auto para " + txtNombre.Text + "\r\n";
                    //OBTENIENDO EL COSTO INCICIAL
                    costo = Convert.ToDouble(txtCosto.Text);
                    //VERIFICAC SEGURO
                    if (rbnBasico.Checked == true)
                    {
                        costo = costo + 500.0;
                        cotizacion += "Lleva seguro basico de $500 \r\n";
                    }
                    if (rbnAterceros.Checked == true)
                    {
                        costo = costo + 700.0;
                        cotizacion += "Lleva seguro a terceros de $700 \r\n";
                    }
                    if (rbnTotal.Checked == true)
                    {
                        costo = costo + 1000.0;
                        cotizacion += "Lleva seguro total de $1000 \r\n";
                    }
                    //VERIFICAR EQUIPO  
                    if (chkAire.Checked == true)
                    {
                        costo = costo + 500.0;
                        cotizacion += "Con aire acondicionado de $500 \r\n";
                    }
                    if (chkSistema.Checked == true)
                    {
                        costo = costo + 700.0;
                        cotizacion += "Con sistema de audio de $700 \r\n";
                    }

                    //MOSTRAMOS TOTAL
                    cotizacion += "El total a pagar es de $" + costo.ToString();

                    txtCotizacion.Text = cotizacion;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Solo puede ingresar numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
        }
    }
}
