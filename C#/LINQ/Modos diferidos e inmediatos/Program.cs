using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modos_diferidos_e_inmediatos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5 };
            //QUERY
            var valores = from n in numeros
                                       where n%2==0
                                       select n;
            //MOSTRAMOS LOS RESULTADOS
            foreach (int item in valores)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            informacionResultados(valores);
            Console.WriteLine();

            //EJECUCION DIFERIDA
            //LA EXPRESION DE LA CONSULTA NO SE EVALUA HASTA QUE SE ITERA SOBRE EL ARREGLO
            //SE PUEDE USAR LA MISMA CONSULTA Y SIEMPRE OBTENEMOS EL RESULTADO ACTUALIZADO

            numeros[1] = 12;
            foreach (int item in valores)
            {
                Console.WriteLine(item);
            }

            //EJECUCION INMEDIATA
            //GUARDAMOS LOS RESULTADOS COMO UN ARREGLO
            int[] arrayValores = (from n in numeros where n % 2 == 0 select n).ToArray<int>();
            //GUARDAMOS LOS RESULTADOS COMO UN LIST
           List <int> listValores = (from n in numeros where n % 2 == 0 select n).ToList<int>();

            Console.WriteLine("El arreglo");
            foreach (int item in arrayValores)
            {
                Console.WriteLine(item);
            }
            numeros[0] = 28;
            Console.WriteLine("NO se actualiza despues de la modificacion");
            foreach (int item in arrayValores)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("La lista");
            foreach (int item in listValores)
            {
                Console.WriteLine(item);
            }

        }
        static void informacionResultados(object resultados)
        {
            Console.WriteLine("Tipo {0}", resultados.GetType().Name);
            Console.WriteLine("Locacion {0}", resultados.GetType().Assembly.GetName().Name);
        }
    }

    }

