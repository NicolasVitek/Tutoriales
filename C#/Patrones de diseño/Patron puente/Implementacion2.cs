using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_puente
{
    class Implementacion2:IBridge
    {
        public void mostrarTotales(Dictionary<string, double> productos)
        {
            double total = 0;
            double totalm = 0;
            double totalc = 0;
            double totald = 0;
            int cantidad = 0;

            foreach (KeyValuePair<string, double> item in productos)
            {
                total += item.Value;
                if (item.Key[0] == 'C')
                {
                    totalc += item.Value;
                }
                if (item.Key[0] == 'M')
                {
                    totalm += item.Value;
                }
                if (item.Key[0] == 'D')
                {
                    totald += item.Value;
                }
                cantidad++;
            }
            Console.WriteLine("El total de comida es " + totalc);
            Console.WriteLine("El total de medicamentos es " + totalm);
            Console.WriteLine("El total de deportes es " + totald);

            Console.WriteLine("El total de {0} productos es &{1}", cantidad, total);
        }
        public void listarProductos(Dictionary<string, double> productos)
        {
            foreach (KeyValuePair<string, double> item in productos)
            {
                if (item.Key[0] == 'C')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (item.Key[0] == 'M')
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                }
                if (item.Key[0] == 'D')
                {
                    Console.ForegroundColor = ConsoleColor.Gray;

                }
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }
            }
    }
}
