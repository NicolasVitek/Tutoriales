using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_prototipo
{
    class Valores: IPrototipo
    {
        public double sumatoria;
        private int m = 1;

        public Valores()
        {

        }
        public Valores(int m)
        {
            this.m = m;
            for (int i = 0; i < 90; i++)
            {
                sumatoria += Math.Sin(i * 0.0172);
            }
        }
        public override string ToString()
        {
            return string.Format("{0}", sumatoria * m);
        }
        public object clonar()
        {
            Valores clon = new Valores();
            clon.m = m;
            clon.sumatoria = sumatoria;
            return clon;
        }
    }
}
