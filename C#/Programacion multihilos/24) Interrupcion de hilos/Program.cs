using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _24__Interrupcion_de_hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rmd = new Random();
            Thread hilo = new Thread(trabajo);
            hilo.Start();
            //ESTO ES PARA SIMULAR SI HAY UNA INTERRUPCION
            int m = 0;
            while (m<1000)
            {
                //HACEMOS LA INTERRUPCION
                if (rmd.Next(100)<2)
                {
                    hilo.Interrupt();
                }
                Thread.Sleep(50);
                m++;
            }
        }
        static void trabajo()
        {
            int n = 0;
            int suma = 0;
            try
            {
                while (n<100)
                {
                    Thread.Sleep(100);
                    Console.WriteLine(n);
                    n++;
                }
            }
            catch (ThreadInterruptedException)
            {
                Console.WriteLine("Se ha interrumpido el trabajo");
                throw;
            }
            //CODIGO DE FINALIZACION PARA DEJAR TODO ESTABLE
            finally
            {
                Console.WriteLine("Finalizamos");
            }
        }
    }
}
