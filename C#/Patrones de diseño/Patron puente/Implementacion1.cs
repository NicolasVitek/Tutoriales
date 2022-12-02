using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_puente
{
    class Implementacion1:IBridge
    {
        public void mostrarTotales(Dictionary<string, double> productos)
        {
            double total = 0;
            int cantidad = 0;
            foreach (KeyValuePair<string,double> item in productos)
            {
                total += item.Value;
                cantidad++;
            }
            Console.WriteLine("El total de {0} productos es &{1}", cantidad, total);
        }
        public void listarProductos(Dictionary<string, double> productos)
        {
            foreach (KeyValuePair<string, double> item in productos)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
