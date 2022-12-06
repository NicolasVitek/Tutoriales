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

namespace DrawEllipse_y_TranslateTransform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //DIBUJANDO UNA ELIPSE. PENS CONTIENE PLUMAS PRE-CARGADAS
            //RECTANGLE REPRESENTA UN RECTANGULO. LOS PRIMEROS DOS PARAMETROS 
            //SON LAS COORDENADAS SUPERIOR IZQUIERDA. LOS OTROS DOS SON LAS
            //DIMENSIONES DEL RECTANGULO.
            g.DrawEllipse(Pens.Indigo, new Rectangle(50, 50, 100, 50));
            //DIBUJANDO EN COORDENADAS DE MUNDO Y PIXELES
            g.DrawEllipse(Pens.Red, new Rectangle(0, 0, 20, 20));
            //SE ESTABLECE UN NUEVO ORIGEN
            g.TranslateTransform(100, 100);
            g.DrawEllipse(Pens.Blue, new Rectangle(0, 0, 20, 20));
            g.DrawEllipse(Pens.CadetBlue, new Rectangle(20, 0, 20, 20));

            g.DrawArc(Pens.Coral, new Rectangle(50, 50, 100, 100), 45, 100);
            g.DrawLine(Pens.Blue, 125, 25, 150, 200);
            g.DrawRectangle(Pens.Orange, new Rectangle(75, 75, 200, 25));
            Point[] puntos = { new Point(30, 45), new Point(110, 75), new Point(175, 200) };
            g.DrawLines(Pens.Green, puntos);

            g.DrawBezier(Pens.Blue, 100, 100, 130, 175, 147, 20,200,230);
            Point[] puntoss = { new Point(30, 45), new Point(110, 75), new Point(175, 200) };
            g.DrawClosedCurve(Pens.Red, puntoss);

            //CREAMOS UNA PLUMA PROPIA DE COLOR ROJO Y 5 DE ANCHO
            Pen pluma1 = new Pen(Color.Red, 5);
            g.DrawLine(pluma1, 50, 50, 200, 50);
            //PLUMA DE ESTILO DE GUION PREDETERMINADO
            Pen pluma2 = new Pen(Color.Green, 7);
            pluma2.DashStyle = DashStyle.Dash;
            g.DrawLine(pluma2, 50, 70, 200, 70);
            //ESTILO DE GUION PROPIO.
            Pen pluma3 = new Pen(Color.Orange, 7);
            float[] guiones = { 1.0f, 1.0f, 2.0f, 1.0f, 3.0f, 1.0f };
            pluma3.DashPattern = guiones;
            g.DrawLine(pluma3, 50, 90, 200, 90);
            //PONEMOS TERMINAL.
            Pen pluma4 = new Pen(Color.OliveDrab, 15);
            pluma4.StartCap = LineCap.ArrowAnchor;
            pluma4.EndCap = LineCap.DiamondAnchor;
            g.DrawLine(pluma4, 50, 120, 200, 120);

            //CURVA CERRADA Y RELLENA CON BROCHA
            Point[] puntossS = { new Point(30, 100), new Point(110, 85), new Point(175, 300) };
            g.FillClosedCurve(Brushes.Black, puntossS);
            //ELIPSE RELLENA
            g.FillEllipse(Brushes.BlueViolet, new Rectangle(75, 30, 100, 25));





        }
    }
}
