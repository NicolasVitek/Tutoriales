using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2__Multiples_hilos
{
    class Program
    {
        private static bool ejecutar = true;
        static void Main(string[] args)
        {
            int m = 0;
            int x = 0;
            Thread hilo = new Thread(Mensaje);
            hilo.Start();
            for (x = 0; x < 8; x++)
            {
                Thread hilo2 = new Thread(Mensaje2);
                hilo2.Start(x);
            }
            while (ejecutar)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Este es el main {0}", m);
                m++;
                if (m==100)
                {
                    ejecutar = false;
                }
            }
            for (x = 0;  x< 8; x++)
            {
                Thread hilo2 = new Thread(Mensaje2);
                hilo2.Start(x);
            }

        }
        static void Mensaje()
        {
            int n = 0;
            while (ejecutar)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Este es el hilo  {0}", n);
                n++;
            }
        }
        static void Mensaje2(object o)
        {
            int n = 0;
            while (ejecutar)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Este es otro hilo {0} - {1}",o, n);
                n++;
            }
        }
    }
}
