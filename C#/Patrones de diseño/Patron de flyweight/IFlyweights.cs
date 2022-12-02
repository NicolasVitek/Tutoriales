using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_flyweight
{
    interface IFlyweights
    {
        void colocarNombre(string nombre);
        void calcularCosto();
        void mostrar();
        string obtenerNombre();

    }
}
