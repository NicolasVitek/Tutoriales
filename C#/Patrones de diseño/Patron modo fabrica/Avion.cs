using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_modo_fabrica
{
    class Avion:IVehiculo
    {
        public void Encender()
        {
            Console.Write("Sigue todo el procedimiento");
        }
        public void Acelerar()
        {
            Console.WriteLine("Empuja el acelerador");
        }
        public void Frenar()
        {
            Console.WriteLine("Jala el freno");
        }
        public void Girar()
        {
            Console.WriteLine("Mueve el timon de cola");
        }
    }
}
