using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_fabrica_abstracta
{
    class SaborChocolate:IProductoSaborizante
    {
        public void Obtener()
        {
            Console.WriteLine("Se produce C7H58N402");
        }
        public string Informacion()
        {
            return "Sabor a chocolate";
        }
    }
}
