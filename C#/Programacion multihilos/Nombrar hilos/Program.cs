using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Nombrar_hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            //EL NOMBRE NO SE PUEDE CAMBIAR
            Thread.CurrentThread.Name = "Principal";
            Thread hilo = new Thread(Imprime);
            hilo.Name = "Secundario";
            hilo.Start();
            hilo.Join();
            Imprime();
        }
        static void Imprime()
        {
            if (Thread.CurrentThread.Name == "Principal")
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;

            }
            Console.WriteLine("Simulamos un metodo que hace un proceso en el hilo");
            Console.WriteLine("El hilo es: {0}", Thread.CurrentThread.Name);
        }
    }
}
