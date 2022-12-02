using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_cadena_de_responsabilidad
{
    class Propietario: IHandler
    {
        public double calcularPrecio(int precio, int cantidad)
        {
            Console.WriteLine("Con el propietario");
            double total = 0;
            //DAMOS UN DESCUENTO
            total = precio * cantidad * 0.85;
            return total;
        }
    }
}
