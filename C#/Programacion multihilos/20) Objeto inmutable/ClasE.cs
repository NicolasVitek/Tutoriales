using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _20__Objeto_inmutable
{
    class Clase
    {
        public readonly int valor;
        public readonly string producto;

        public Clase(int valor, string producto)
        {
            this.valor = valor;
            this.producto = producto;
        }
        public override string ToString()
        {
            return string.Format("Producto " + producto + " de valor " + valor);
        }
    }
}
