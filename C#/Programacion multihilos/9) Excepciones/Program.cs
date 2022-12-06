using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _9__Excepciones
{
    class Program
    {
        static private bool ejecutar = true;
        private static int conteo = 0;
        static void Main(string[] args)
        {
            Thread hilo = new Thread(incrementar);
            hilo.Start();
        }
        static void incrementar()
        {
            try
            {
                while (ejecutar)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    conteo = conteo + 1;
                    Console.Write(Thread.CurrentThread.ManagedThreadId);
                    Console.Write(" -->{0}", conteo);
                    if (conteo > 100)
                    {
                        ejecutar = false;
                        throw null;
                    }

                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Hubo una excepcion");
            }           
        }
    }
}
