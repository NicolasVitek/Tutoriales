using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_adaptador
{
    class Calcu:ITarget
    {
        public int sumar(int a, int b)
        {
            return a + b;
        }
    }
}
