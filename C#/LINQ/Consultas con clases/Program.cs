using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas_con_clases
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
            var reprobados = from e in estudiantes
                             where e.promedio <= 6.0
                             select e;
            foreach (Estudiante item in reprobados)
            {
                Console.WriteLine(item);
            }
            //IMPRIMIMOS EL ATRIBUTO QUE QUERAMOS
            foreach (Estudiante item in reprobados)
            {
                Console.WriteLine(item.nombre);
            }
            var mercadotecnia = from e in estudiantes
                                where e.curso == "mercadotecnia"
                                select e.nombre;

            foreach (string item in mercadotecnia)
            {
                Console.WriteLine(item);
            }
        }
    }
}
