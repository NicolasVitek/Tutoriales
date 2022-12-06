using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace _7__Funciones_lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread uno = new Thread(()=>tabla(1,1000));
            uno.Start();
            Thread dos = new Thread(() => tabla(2, 1100));
           dos.Start();
            Thread tres = new Thread(() => tabla(3, 1200));
            tres.Start();
        }
        static void tabla(int numero, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("{0}*{1}={2}", numero,i , cantidad*i);
            }
        }
    }
}
