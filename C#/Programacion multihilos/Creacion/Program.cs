using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace Creacion
{
    class Program
    {
        //MAIN REPRESENTA EL HILO PRINCIPAL QUE SE EJECUTA EN ALGUN NUCLEO
        static void Main(string[] args)
        {
            //CREACION
            Thread hilo = new Thread(Saludo);
            //INCIALIZACION
            hilo.Start();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Este es el main");
            Console.WriteLine();
            //ENVIAR DATOS AL HILO 
            Thread hilo2 = new Thread(Mensaje);
            //AL INICIAR EL 
            hilo2.Start(5);


        }
        static void Saludo()
        {
            //ES COMPATILE CON EL DELEGADO QUE NECESITA THREAD
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Este es el hilo");
        }
        static void Mensaje(object o)
        {
            int m = Convert.ToInt32(o);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Este es el mensaje {0},{1}", m, m * 2);
        }
    }
}
