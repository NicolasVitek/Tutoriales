using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threadpool
{
    class Program
    {
        static private bool ejecutar = true;
        private static int conteo = 0;
        static void Main(string[] args)
        {
            //ALTERNATIVA AL TASK
            ThreadPool.QueueUserWorkItem(incrementar, 100);
            Thread.Sleep(1000);
            Console.WriteLine("El valor final del conteo es " + conteo);
        }
        static void incrementar(object o)
        {
            int limite = (int)o;
            while (ejecutar)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                conteo = conteo + 1;
                Console.Write(Thread.CurrentThread.ManagedThreadId);
                Console.Write(" -->{0}", conteo);
                if (conteo > limite)
                {
                    ejecutar = false;
                }

            }
        }
    }
}
