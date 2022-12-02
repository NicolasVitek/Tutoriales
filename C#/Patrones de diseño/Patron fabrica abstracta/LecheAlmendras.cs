using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_fabrica_abstracta
{
    class LecheAlmendras:IProductoLeche
    {
        public void Producir()
        {
            Console.WriteLine("Procesar las almendras");
        }
        public string obtenerDatos()
        {
            return "Leche organica de almendras, 250ml";
        }
    }
}
