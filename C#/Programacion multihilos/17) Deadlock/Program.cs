using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _17__Deadlock
{
    class Program
    {
        static object control1 = new object();
        static object control2=new object();
        static void Main(string[] args)
        {
            //SUCEDE CUANDO DOS HILOS ESPERAN POR EL RECURSO QUE TIENE EL OTRO
            //DE TAL FORMA QUE NINGUNO PUEDE CONTINUAR

            Console.WriteLine("Inicio");
            Thread hilo1 = new Thread(metodo1);
            hilo1.Start();
            Thread hilo2 = new Thread(metodo2);
            hilo2.Start();
        }
        static void metodo1()
        {
            lock (control1)
            {
                Thread.Sleep(500);
                lock (control2)
                {
                    Console.WriteLine("Hilo 1");
                }
            }
        }
        static void metodo2()
        {
            lock (control2)
            {
                Thread.Sleep(500);
                lock (control1)
                {
                    Console.WriteLine("Hilo 2");
                }
            }
        }
    }
}
