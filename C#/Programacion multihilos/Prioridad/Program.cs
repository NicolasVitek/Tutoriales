using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Prioridad
{
    class Program
    {
        static private bool ejecutar1 = true;
        private static int conteo1 = 0;

        static private bool ejecutar2 = true;
        private static int conteo2 = 0;
        static void Main(string[] args)
        {
            //LA PRIORIDAD DETERMINA CUANDO TIEMPO DE EJECUCION VA A RECIBIR CON RELACION 
            //A OTROS HILOS. CAMBIAR LA PRIORIDAD NO MEJORA EL DESEMPEÑO
            Thread hilo1 = new Thread(incrementar1);
            hilo1.Priority = ThreadPriority.Lowest;
            hilo1.Start();
            Thread hilo2 = new Thread(incrementar2);
            hilo2.Priority = ThreadPriority.Highest;
            hilo2.Start();


        }
        static void incrementar1()
        {
            while (ejecutar1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                conteo1 = conteo1 + 1;
                Console.Write(Thread.CurrentThread.ManagedThreadId);
                Console.Write(" -->{0}", conteo1);
                if (conteo1>100)
                {
                    ejecutar1 = false;
                    ejecutar2 = false;
                }
          
            }
        }
        static void incrementar2()
        {
            while (ejecutar2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                conteo2 = conteo2 + 1;
                Console.Write(Thread.CurrentThread.ManagedThreadId);
                Console.Write(" -->{0}", conteo2);
                if (conteo1 > 100)
                {
                    ejecutar1 = false;
                    ejecutar2 = false;
                }

            }
        }
    }
}
