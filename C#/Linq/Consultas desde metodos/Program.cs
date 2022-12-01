using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas_desde_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> resultados = Explicita.obtenerPares();
            foreach (int item in resultados)
            {
                Console.WriteLine(item);
            }
            IEnumerable<string> postres = Explicita.obtenerPostres();
            foreach (string item in postres)
            {
                Console.WriteLine(item);
            }
            int[] impares = Explicita.obtenerImpares();
            foreach (int item in impares)
            {
                Console.WriteLine(item);
            }
        }
    }
}
