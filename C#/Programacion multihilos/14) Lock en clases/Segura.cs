using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _14__Lock_en_clases
{
    class Segura
    {
        static int a = 4;
        static int b = 2;
        static readonly object control = new object();

        public static void operacion()
        {
            //LOS HILOS QUEDAN EN ESPERA HASTA QUE EL CODIGO HAYA SIDO EJECUTADO POR EL OTRO HILO   
            //SEGUN VAYAN LLEGANDO
            lock (control)
            {
                if (b == 0)
                {
                    Console.WriteLine("Division entre 0");
                }
                else
                {
                    Thread.Sleep(100);
                    Console.WriteLine("El resultado es " + a / b);
                }
                b = 0;
            }
        }
    }
}
