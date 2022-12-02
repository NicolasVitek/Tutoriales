using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_basicas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> estudiantes = new List<Estudiante>
            {
                new Estudiante("ana", "a100", "mercadotecnia", 10.0),
                new Estudiante("luis", "a100", "Poo", 9.0),
                new Estudiante("juan", "a100", "basico", 5.0),
                new Estudiante("susana", "a100", "Poo", 4.3),
                new Estudiante("pablo", "a100", "mercadotecnia", 10.0),
            };
            //CONTAR
            int cantidad = (from e in estudiantes
                            where e.promedio > 5
                            select e).Count();
            Console.WriteLine("La cantidad de aprobados es " + cantidad);
            Console.WriteLine();
            //REVERSA
            var aprobados = from e in estudiantes
                            where e.promedio > 5
                            select e;
            foreach (var item in aprobados)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Orden inverso");
            foreach (var item in aprobados.Reverse())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //ORDENAMIENTO
            var ordenados= from e in estudiantes
                           orderby e.promedio descending
                           select e;
            foreach (var item in ordenados)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            int[] numeros = { 1, 5, 6, 8, 9, 10, 36, 2 };
            //MAXIMO
            int maximo = (from n in numeros select n).Max();
            Console.WriteLine(maximo);
            //MINIMO
            int minimo = (from n in numeros select n).Min();
            Console.WriteLine(minimo);
            //PROMEDIO
            double promedio = (from n in numeros select n).Average();
            Console.WriteLine(promedio);
            //SUMATORIA
            int sumatoria = (from n in numeros select n).Sum();
            Console.WriteLine(sumatoria);

        }
    }
}
