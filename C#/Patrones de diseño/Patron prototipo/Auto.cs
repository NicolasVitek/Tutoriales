using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_prototipo
{
    class Auto: IPrototipo
    {
        public string modelo;
        public int costo;

        public Auto(string modelo, int costo)
        {
            this.modelo = modelo;
            this.costo = costo;
        }
        public override string ToString()
        {
            return string.Format("Auto--> {0}, {1}", modelo, costo);
        }
        public object clonar()
        {
            Auto clon = new Auto(modelo, costo);
            return clon;
        }
    }
}
