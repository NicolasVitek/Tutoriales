using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_puente
{
    class Implementacion3: IBridge
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
            Console.WriteLine("El total de comida es ${0}, {1}% del total", totalc, totalc/total*100 );
            Console.WriteLine("El total de medicamentos es ${0}, {1}% del total", totalm, totalm / total * 100);
            Console.WriteLine("El total de deportes es ${0}, {1}% del total", totald, totald / total * 100);

            Console.WriteLine("El total de {0} productos es &{1}", cantidad, total);
        }
        public void listarProductos(Dictionary<string, double> productos)
        {
            foreach (KeyValuePair<string, double> item in productos)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (item.Key[0] == 'C')
                {
                    Console.WriteLine("{0} - {1}", item.Key, item.Value);
                }
            }
            foreach (KeyValuePair<string, double> item in productos)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (item.Key[0] == 'M')
                {
                    Console.WriteLine("{0} - {1}", item.Key, item.Value);
                }
            }
            foreach (KeyValuePair<string, double> item in productos)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                if (item.Key[0] == 'D')
                {
                    Console.WriteLine("{0} - {1}", item.Key, item.Value);
                }
            }
        }
    }
}
