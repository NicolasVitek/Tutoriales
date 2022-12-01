using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = {1, 2, 3, 4, 5};
            //QUERY
            IEnumerable<int> valores = from n in numeros
                                       where n > 3 && n < 8
                                       select n;
            //MOSTRAMOS LOS RESULTADOS
            foreach (int item in valores)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            string[] postres = { "helado", "sandia", "pastel de manzana", "ensala de frutas", "manzana de caramelo"};

            IEnumerable<string> encontrados = from p in postres
                                              where p.Contains("manzana")
                                              orderby p
                                              select p;
            foreach (string item in encontrados)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //HACEMOS UNA REFLEXION
            informacionResultados(valores);
            Console.WriteLine();
            informacionResultados(encontrados);
        }
        static void informacionResultados(object resultados)
        {
            Console.WriteLine("Tipo {0}", resultados.GetType().Name);
            Console.WriteLine("Locacion {0}", resultados.GetType().Assembly.GetName().Name);
        }
    }
}
