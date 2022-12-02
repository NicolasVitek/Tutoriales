using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_modo_fabrica
{
    class Auto:IVehiculo
    {
        public void Encender()
        {
            Console.Write("Introduce la llave y girala");
        }
        public void Acelerar()
        {
            Console.WriteLine("Oprime el acelerador");
        }
        public void Frenar()
        {
            Console.WriteLine("Oprime el freno");
        }
        public void Girar()
        {
            Console.WriteLine("Usa el volante");
        }
    }
}
