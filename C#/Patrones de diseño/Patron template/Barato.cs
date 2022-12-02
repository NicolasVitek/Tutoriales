using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_template
{
    class Barato:IPrimitiva
    {
        public double Decorar(int cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Poner etiqueta");
            }
            return 1.5 * cantidad;
        }
        public double Empacar(int cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Meter en la bolsa");
            }
            return 0.25 * cantidad;
        }
    }
}
