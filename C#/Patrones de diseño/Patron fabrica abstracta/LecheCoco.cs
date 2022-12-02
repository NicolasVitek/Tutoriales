using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_fabrica_abstracta
{
    class LecheCoco:IProductoLeche
    {
        public void Producir()
        {
            Console.WriteLine("Buscamos los cocos");
        }
        public string obtenerDatos()
        {
            return "Leche de coco natural, 250ml";
        }
    }
}
