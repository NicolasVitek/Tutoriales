using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _4__Problema_de_sincronizacion
{
    class Program
    {
        private static bool ejecutar = true;
        private static int conteo = 0;

        //USAMOS UN OBJETO PARA CREAR EL LOCK QUE PROTEGE EL BLOQUE DE CODIGO QUE PUEDE
        //DESINCRONIZAR LOS HILOS
        private static object control = new object();
        private static int id1 = 0;
        private static int id2 = 0;

        static void Main(string[] args)
        {
            Thread hilo = new Thread(Incremento);
            hilo.Start();
            id1 = hilo.ManagedThreadId;

            Thread hilo2 = new Thread(Incremento);
            hilo2.Start();
            id2 = hilo2.ManagedThreadId;

            while (ejecutar)
            {
                if (conteo>100)
                {
                    ejecutar = false;
                }
            }
        }
        static void Incremento()
        {
            while (ejecutar)
            {
                //LOCK ASEGURA QUE ESTE BLOQUE DE CODIGO LO EJECUTE UN HILO A LA VEZ
                lock (control)
                {
                    if (Thread.CurrentThread.ManagedThreadId==id1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (Thread.CurrentThread.ManagedThreadId == id2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
                conteo = conteo + 1;
                Console.WriteLine();
                Console.Write(Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine(" -> {0}", conteo);
                //PONEMOS EL HILO A DORMIR 1000 MILISEGUNDOS
                Thread.Sleep(1000);
            }
        }
    }
}
