using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_fabrica_abstracta
{
    class SaborVainilla: IProductoSaborizante
    {
        public void Obtener()
        {
            Console.WriteLine("Se extrae de las vainas");
        }
        public string Informacion()
        {
            return "Extracto natural de vainilla";
        }
    }
}
