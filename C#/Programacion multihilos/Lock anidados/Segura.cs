using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _15__Lock_anidados
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
                    double d = a / b;
                    muestra(d);
                }
                b = 0;
            }
        }
        private static void muestra(double valor)
        {
            lock (control)
            {
                Console.WriteLine("El resultado es " + valor);
            }
        }
    }
}
