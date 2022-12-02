using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 6, 9, 8, 20, 7, 89 };
            //TAKE
            IEnumerable<int> inicio = numeros.Take(5);
            foreach (int item in inicio)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //SKIP
            IEnumerable<int> salto = numeros.Skip(5);
            foreach (int item in salto)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //FIRST
            Console.WriteLine(numeros.First());
            Console.WriteLine();
            //LAST
            Console.WriteLine(numeros.Last());
            Console.WriteLine();
            //VEMOS SI HAY MULTIPLOS DE 5
            Console.WriteLine(numeros.Any(n => n % 5 == 0));
            Console.WriteLine();
            //WHERE TAMBIEN PERMITE UN SEGUNDO ARGUMENTO DE TIPO INT QUE SIMBOLIZA EL INDICE DEL ELEMENTO
            //ESTO SE LLAMA FILTRADO POR INDICE
            string[] postres = { "helado", "sandia", "pastel de manzana", "ensala de frutas", "manzana de caramelo" };
            IEnumerable<string> r1 = postres.Where((n, i) => i % 2 == 0);
            //n ES EL ELEMENTO,i ES SU INDICE
            foreach (string item in r1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //STARTWITH
            IEnumerable<string> r2 = from p in postres
                                     where p.StartsWith("pastel")
                                     select p;
            foreach (string item in r2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //ENDSWITH
            IEnumerable<string> r3 = from p in postres
                                     where p.EndsWith("manzana")
                                     select p;
            foreach (string item in r3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //TAKEWHILE ENUMERA LA SECUENCIA DE ENTRADA Y EMITE CADA ELEMENTO HASTA QUE EL PREDICADO ES FALSO
            //E IGNORA EL RESTO
            int[] numeros2 = { 1, 2, 3, 4, 5,6,7,8,9 };
            var r4 = numeros2.TakeWhile(n => n <= 8);
            foreach (int  item in r4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //SKiPWHILE ENUMERA LA SECUENCIA DE ENTRADA, IGNORA LOS ELEMENTOS HASTA QUE EL PREDICADO SEA FALSO
            //Y EMITE EL RESTO
            var r5 = numeros2.SkipWhile(n => n <= 8);
            foreach (int item in r5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //PROYECCION INDEXADA MUESTRA LOS INDICES DE LOS ELELEMTOS
            IEnumerable<string> r6 = postres.Select((p, i) => "Indice " + i + " para el postre " + p);
            foreach (string item in r6)
            {
                Console.WriteLine(item); 
            }
            Console.WriteLine();
            //SELECTMANY PRODUCE N ELEMENTOS DE SALIDA. TOMA TODOS LOS ELEMENTOS COMO UNO SOLO
            IEnumerable<string> r7 = postres.SelectMany(p => p.Split());
            foreach (string item in r7)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //SELECT MULTIPLE
            IEnumerable<string> r8 = from p in postres
                                     from p1 in p.Split()
                                     select p1 + " ==> " + p;
            foreach (string item in r8)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            IEnumerable<string> r9 = from p in postres
                                     from p1 in postres
                                     select "yo quiero: " + p1 + " y tu quieres " + p;
            foreach (string item in r9)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //JOIN
            List<Estudiante> estudiantes = new List<Estudiante>
            {
                new Estudiante("ana", 100),
                new Estudiante("luis", 90),
                new Estudiante("juan", 50),
                new Estudiante("susana", 43),
                new Estudiante("pablo", 101),
            };
            List<Curso> cursos = new List<Curso>
            {
                new Curso("Programacion",100),
                new Curso("POO", 90),
                new Curso("UML",100),
                new Curso("POO", 101),
            };
            var listado = from e in estudiantes
                          join c in cursos on e.id equals c.id
                          select e.nombre + " esta en el curso " + c.curso;
            foreach (string item in listado)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //GROUPJOIN
            var listado2 = from e in estudiantes
                           join c in cursos on e.id equals c.id
                           into tempListado
                           select new { estudiante = e.nombre, tempListado };
            foreach (var item in listado2)
            {
                Console.WriteLine(item.estudiante);
                foreach (var item2 in item.tempListado)
                {
                    Console.WriteLine(item2);
                }
            }
            Console.WriteLine();
            //ZIP
            string[] helados = { "chocolate", "vainilla", "frutilla" };
            IEnumerable<string> r11 = postres.Zip(helados, (p, h) => p + " con helado de " + h);
            foreach (string item in r11)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //ORDENAMIENTO
            IEnumerable<int> numOrder = numeros.OrderBy(n => n);
            IEnumerable<int> numDes = numeros.OrderByDescending(n => n);
            foreach (int item in numOrder)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (int item in numDes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //ORDENAMIENTO POR LONGITUD Y ALFABETICAMENTE
            IEnumerable<string> postresOrd = postres.OrderBy(p => p.Length).ThenBy(p => p);
            foreach (string item in postresOrd)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //AGUPAMIENTO
            string[] archivos = System.IO.Directory.GetFiles("C:\\Users\\pc\\OneDrive\\Facultad\\Proyectos\\Linq\\Operadores");
            foreach (string item in archivos)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var agrupados = archivos.GroupBy(a => System.IO.Path.GetExtension(a));
            foreach (IGrouping<string, string> item in agrupados)
            {
                Console.WriteLine("Archivos de extension {0}", item.Key);
                foreach (string a in item)
                {
                    Console.WriteLine("\t {0}", a);
                }
            }
            Console.WriteLine();
            //AGGREGATE HACE UNA AGREGACION USANDO UNA EXPRESION EN PARTICULAR. EL VALOR INICIAL ES 0
            int agregado = numeros.Aggregate(0, (t, n) => t + (n * 2));
            Console.WriteLine(agregado);


        }
    }
}
