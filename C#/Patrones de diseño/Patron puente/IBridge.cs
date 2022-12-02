using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_puente
{
    interface IBridge
    {
        void mostrarTotales(Dictionary<string, double> productos);
        void listarProductos(Dictionary<string, double> productos);
    }
}
