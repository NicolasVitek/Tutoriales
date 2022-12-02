using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_estrategia
{
    class Suma:IOperacion
    {
        public double operacion(double a, double b)
        {
            return a + b;
        }
    }
}
