using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _3_Foreground_y_background
{
    class Program
    {
        private static bool ejecutar = true;

        static void Main(string[] args)
        {
            int m = 0;
            int x = 0;
            //HILO DE TIPO FOREGROUND, SIGUEN EXISTIENDO AUN SI LA APLICACION TERMINA DE EJECUTAR
            //MAIN. PUEDEN EVITAR QUE LA APLICACION TERMINE
            //Thread hilo = new Thread(Mensaje);
            //hilo.Start();
            //HILO DE TIPO BACKGROUND QUE FINALIZAN SI LA APLIACION TERMINA DE EJECUTAR MAIN
            Thread hilo = new Thread(Mensaje);
            hilo.IsBackground = true;
            hilo.Start();

            while (ejecutar)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Este es el main {0}", m);
                m++;
                if (m == 50)
                {
                    ejecutar = false;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("SAlimos de main");
        }
        static void Mensaje()
        {
            int n = 0;
            bool ejecutarMensaje = true;
            while (ejecutarMensaje)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Este es el hilo  {0}", n);
                n++;
                if (n>100)
                {
                    ejecutarMensaje = false;
                }
            }
        }
    }
}
