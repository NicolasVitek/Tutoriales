using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _14__Lock_en_clases
{
    class Program
    {
        static void Main(string[] args)
        {
            //CLASE INSEGURA PARA LAS HILOS
            //Thread hilo = new Thread(Problema.operacion);
            //Thread hilo2 = new Thread(Problema.operacion);
            //Thread hilo3 = new Thread(Problema.operacion);
            //hilo.Start();
            //Thread.Sleep(100);
            //hilo2.Start();
            //hilo3.Start();

            //CLASE SEGURA PARA LOS HILOS   
            Thread hilo = new Thread(Segura.operacion);
            Thread hilo2 = new Thread(Segura.operacion);
            Thread hilo3 = new Thread(Segura.operacion);
            hilo.Start();
            Thread.Sleep(100);
            hilo2.Start();
            hilo3.Start();
            int n = 0;
            while (n<500)
            {
                n++;
                Console.WriteLine("{0}--->{1}", hilo.ManagedThreadId, hilo.ThreadState);
                Console.WriteLine("{0}--->{1}", hilo2.ManagedThreadId, hilo.ThreadState);
                Console.WriteLine("{0}--->{1}", hilo3.ManagedThreadId, hilo.ThreadState);
            }
        }
    }
}
