using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _12__Signal
{
    class Program
    {
        //CON SIGNAL UN HILO QUEDA EN ESPERA HASTA QUE OTRO HILO LE DE LA SEÑAL QUE ES DE TIPO
        //MANUALRESETEVENT
        static private bool ejecutar = true;
        private static int conteo = 0;
        private static ManualResetEvent señal = new ManualResetEvent(false);
        static void Main(string[] args)
        {
            Thread hilo = new Thread(incremento);
            hilo.Start();
            int n = 0;
            while (n<150)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Desde main");
                n++;
            }
            //SE INDICA QUE EL HILO PUEDE CONTINUAR
            señal.Set();
        }
        static void incremento()
        {
            while (ejecutar)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                conteo = conteo + 1;
                Console.Write(Thread.CurrentThread.ManagedThreadId);
                Console.Write(" -->{0}", conteo);
                if (conteo==50)
                {
                    //SE BLOQUEA EL HILO HASTA QUE SE MANDE UNA SEÑAL
                    señal.WaitOne();
                }
                if (conteo > 1000)
                {
                    ejecutar = false;
                    //COMO YA NO NECESITAMOS LA SEÑAL....
                    señal.Dispose();
                }

            }
        }
    }
}
