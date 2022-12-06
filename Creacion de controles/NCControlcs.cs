using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//BIBLIOTECAS AGREGADAS
using System.Windows.Forms;
using System.ComponentModel;


namespace Creacion_de_controles
{
    class NCControlcs: Button
    {
        private bool gigante = true;
        [Description("Dice si el boton se pone gigante")]
        [Category("Cosas Gigantes")]
        [DefaultValue(true)]
        public bool Gigante
        {
            set { gigante = value; }
            get { return gigante; }
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            if (gigante)
            {
                this.Size=new System.Drawing.Size(150,150);
            }
            base.OnMouseEnter(e);
        }
        //UNA VEZ HECHA LA CLASE, BOTON DERECHO EN EL PROYECTO Y COMPILAR
    }
}
