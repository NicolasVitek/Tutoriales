using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _18__Semaforo
{
    class Program
    {
        //EL SEMAFORO PERMITE QUE UN NUMERO DE HILOS ENTREN A LA SECCION CRITICA, CUANDO SE ALCANZA
        //EL LIMITE, NO ENTRAN MAS. POR CADA HILO DE SALIDA UNO ENTRA. UN SEMAFORO CON LA CAPACIDAD
        //DE UNO ES LO MISMO QUE UN LOCK.

        static Semaphore semaforo = new Semaphore(3, 3);
        static int conteo = 0;
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                new Thread(metodo).Start(i);
            }
        }
        static void metodo(object n)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Estamos en el metodo " + n + " lo invoco");
            Random rnd = new Random();
            //INICIAMOS LA SECCION CRITICA
            semaforo.WaitOne();
            conteo++;
            Console.WriteLine("Hilos en la seccion: " + conteo);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} esta es la seccion critica", n);
            Thread.Sleep(1000 * rnd.Next(1, 5));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0} abandona la seccion critica", n);
            semaforo.Release();
            //EN ESTA PARTE SOLO PUEDEN ESTAR TRABAJANDO 3 HILOS
            //FINALIZAMOS LA SECCION CRITICA
            conteo--;
            Console.WriteLine("Hilos en la seccion: " + conteo);
 
        }
    }
}
