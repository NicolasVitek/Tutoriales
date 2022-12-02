using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_cadena_de_responsabilidad
{
    interface IHandler
    {
        double calcularPrecio(int cantidad, int precio);
    }
}
