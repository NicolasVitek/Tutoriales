using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            lista.AddRange(new object[] { "hola", 1, 2, false, "saaludos", 3.5 });

            var enteros = lista.OfType<int>();
            foreach (int item in enteros)
            {
                Console.WriteLine(item);
            }
            ArrayList estudiantes = new ArrayList()
            {
                new Estudiante("ana", "a100", "mercadotecnia", 10.0),
                new Estudiante("luis", "a100", "Poo", 9.0),
                new Estudiante("juan", "a100", "basico", 5.0),
                new Estudiante("susana", "a100", "Poo", 4.3),
                new Estudiante("pablo", "a100", "mercadotecnia", 10.0),

            };
            //LINQ NECESITA QUE SUS COLECCIONES IMPLEMENTEN A IENUMERABLE Y ARRAYLIST NO SIRVE
            var estudiante = estudiantes.OfType<Estudiante>();
            var reprobados = from e in estudiante
                             where e.promedio == 6.00
                             select e;
            foreach (Estudiante item in reprobados)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //PROYECCION CON TIPOS ANONIMOS PARA MOSTRAR MAS DE UN ATRIBUTO

            var nombrePromedio = from e in estudiante
                                 select new { e.nombre, e.promedio };

            foreach (var item in nombrePromedio)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
