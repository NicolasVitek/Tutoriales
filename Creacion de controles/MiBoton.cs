using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creacion_de_controles
{
    public partial class MiBoton : Control
    {
        private bool presionado = false;
        private bool activado = false;

        public bool Activado
        {
            set { activado = value;
                Invalidate();
                //CUANDO SE CAMBIA EL ESTADO DE ACTIVADO
                // SE REDIBUJA.
            }
            get { return activado; }
        }

        public new string Text
        {
            set
            {
                base.Text = value;
                Invalidate();
            }
            get { return base.Text; }
        }

        public MiBoton()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            //base.OnPaint(pe);
            Graphics g = pe.Graphics;
            //OBTENEMOS EL RECTANGULO QUE REPRESENTA EL AREA DE CONTROL
            Rectangle r = ClientRectangle;
            r.Width++;
            r.Height++;
            //COLOCAMOS EL COLOR DE FONDO, EL MISMO QUE EL PADRE
            g.FillRectangle(new SolidBrush(Parent.BackColor), ClientRectangle);
            //COLOCAMOS EL COLOR QUE SE VA A USAR
            Color micolor;
            if (presionado == true)
            {
                micolor = Color.Blue;
            }
            else
            {
                micolor = Color.Orange;    
            }
            g.FillEllipse(new SolidBrush(micolor), r);
            //COLOCO EL TEXT A DESPLEGAR
            Font fuente = new Font("Arial", (float)r.Height * 0.5f, FontStyle.Regular);
            //DAMOS FORMATO A LA FUENTE
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            g.DrawString(Text, fuente, Brushes.Black, new Rectangle(r.Left, r.Top, r.Width, r.Height), formato);
            //DIBUJAMOS INFO DE LA OTRA PROPIEDAD
            if (activado==true)
            {
                g.FillEllipse(Brushes.Red, new Rectangle(r.Left, r.Top, 10, 10));
            }
            else
            {
                g.FillEllipse(Brushes.Gray, new Rectangle(r.Left, r.Top, 10, 10));
            }

        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                presionado = true;
            }
            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                presionado = false;
            }
            Invalidate();
        }

    }
}
