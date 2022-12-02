using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_fabrica_abstracta
{
    class LecheVaca:IProductoLeche
    {
        public void Producir()
        {
            Console.WriteLine("Ordeñar vaca");
        }
        public string obtenerDatos()
        {
            return "Leche de vaca, 250ml";
        }
    }
}
