using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _14__Lock_en_clases
{
    class Problema
    {
        static int a=4;
        static int b = 2;

        public static void operacion()
        {
            if (b==0)
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
