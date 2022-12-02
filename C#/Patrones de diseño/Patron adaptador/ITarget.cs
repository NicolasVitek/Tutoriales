using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_adaptador
{
    //LA INTERFAZ QUE CONOCE EL CLIENTE
    interface ITarget
    {
        int sumar(int a, int b);
    }
}
