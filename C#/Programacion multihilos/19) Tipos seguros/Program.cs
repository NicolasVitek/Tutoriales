using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _19__Tipos_seguros
{
    class Program
    {
        static List<int> lista = new List<int>();
        static void Main(string[] args)
        {
            Thread hilo1 = new Thread(adicionar);
            Thread hilo2 = new Thread(adicionar);
            hilo1.Start();
            hilo2.Start();
            Thread.Sleep(1000);
            lock (lista)
            {
                foreach (int item in lista)
                {
                    Console.WriteLine(item);
                }
            }
        }
        static void adicionar()
        {
            Random rmd = new Random();
            //SE HACE EL LOCK CON EL MISMO OBJETO COMO CONTROL, ASI ES MAS SEGURO  
            lock (lista)
            {
                lista.Add(rmd.Next(1, 100));
            }
        }
    }
}
