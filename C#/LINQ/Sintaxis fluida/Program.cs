using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxis_fluida
{
    class Program
    {
        static void Main(string[] args)
        {
            //SEQUENCE ES UN OBJETO QUE IMPLEMENTA A IENUMERABLE<T>. ELEMENT ES UN ITEM
            //DE LA SECUENCIA. QUERY OPERATOR ES UN METODO QUE TRANSFORMA ESA SECUENCIA

            int[] numeros = { 1, 2, 3, 6, 9, 8, 20, 7, 89 };
            //USAMOS EXPRESIONES LAMBDA COMO ARGUMENTO DONDE n ES EL ARGUMENTO DE ENTRADA
            IEnumerable<int> pares = numeros.Where(n => n % 2 == 0);
            foreach (int item in pares)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            string[] postres = { "helado", "sandia", "pastel de manzana", "ensala de frutas", "manzana de caramelo" };
            IEnumerable<string> encontrado = postres.Where(pp => pp.Contains("manzana"));
            foreach (string item in encontrado)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //ENCADENANDO OPERADORES
            IEnumerable<string> manzanas = postres
                .Where(p => p.Contains("manzana"))
                .OrderBy(p => p.Length)
                .Select(p => p.ToUpper());
            foreach (string item in manzanas)
            {
                Console.WriteLine(item);
            }
        }
    }
}
