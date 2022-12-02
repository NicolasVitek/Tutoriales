    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_modo_fabrica
{
    class Bicicleta:IVehiculo
    {
        public void Encender()
        {
            Console.Write("Las bicicletas no encienden");
        }
        public void Acelerar()
        {
            Console.WriteLine("Pedalea mas fuerte para acelerar");
        }
        public void Frenar()
        {
            Console.WriteLine("Presiona el freno trasero primero");
        }
        public void Girar()
        {
            Console.WriteLine("Usa el manubrio");
        }
    }
}
