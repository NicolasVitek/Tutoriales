using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subquery
{
    class Program
    {
        static void Main(string[] args)
        {
            //UN SUBQUERY ES UNA CONSULTA QUE ESTA DENTRO DE LA EXPRESIONA LAMBDA DE OTRA CONSULTA

            string[] postres = { "helado", "sandia", "pastel de manzana", "ensala de frutas", "manzana de caramelo" };

            //ORDENAMOS ALFABETICAMENTE DE ACUERDO A LA ULTIMA PALABRA DE CADA ELEMENTO. SPLIT DIVIDE
            //EN UNA COLECCION A LA CADENA. P.SPLIT().LAST() ES EL SUBQUERY
            IEnumerable<string> resultados = postres.OrderBy(p => p.Split().Last());
            foreach (string item in resultados)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            int[] numeros = { 1, 2, 3, 4, 5 };
            IEnumerable<int> nums = numeros.Where(n => n < numeros.First());
            foreach (int item in nums)
            {
                Console.WriteLine(item);
            }
            //NUMEROS QUE SEAN MENORES O IGUALES AL PRIMER ENTERO QUE SE ENCUENTRE
            IEnumerable<int> nums2 = numeros.Where(n => n <= (numeros.Where(n2 => n2 % 2 == 0)).First());
            foreach (int item in nums2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
