using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_con_conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> conjunto1 = new List<int> { 2, 4, 6, 8, 9 };
            List<int> conjunto2 = new List<int> { 2, 5, 6, 7, 9 };

            //EXCEPT NOS DA LA DIFERENCIA ENTRE LOS DOS CONJUNTOS
            //DEPENDE DEL ORDEN DE LOS CONJUNTOS
            var except = (from n1 in conjunto1 select n1).Except(from n2 in conjunto2 select n2);
            foreach (var item in except)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //INTERCEPT NOS DA LO COMUN ENTRE LOS CONJUNTOS
            var inter = (from n1 in conjunto1 select n1).Intersect(from n2 in conjunto2 select n2);
            foreach (var item in inter)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //UNION NOS DA LA UNION DE LOS CONJUNTOS SIN REPETICIONES
            var union = (from n1 in conjunto1 select n1).Union(from n2 in conjunto2 select n2);
            foreach (var item in union)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //CONCAT CONCATENA DIRECTAMENTE LOS CONJUNTOS
            var concat = (from n1 in conjunto1 select n1).Concat(from n2 in conjunto2 select n2);
            foreach (var item in concat)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //DISTINCT REMUEVE LOS DUPLICADOS
            foreach (var item in concat.Distinct())
            {
                Console.WriteLine(item);
            }

        }
    }
}
