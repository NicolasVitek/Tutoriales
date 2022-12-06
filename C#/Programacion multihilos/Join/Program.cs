using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Join
{
    class Program
    {
        //ES USADO PARA ESPERAR LA FINALIZACION DE UN HILO ANTES DE QUE CONTINUE
        //UN HILO TERMINA CUANDO FINALIZA LA EJECUCION DEL COGIDO DEL METODO
        //QUE LE PASAMOS COMO DELEGADO
        static void Main(string[] args)
        {
            int i = 0;
            Thread uno = new Thread(Imprime);
            uno.Start();
            //MAIN TIENE QUE ESPERAR A QUE TERMINE UNO ANTES DE PODER CONTINUAR CON SU PROPIO HILO
            uno.Join();
            Console.ForegroundColor = ConsoleColor.Red;
            for (i = 0; i < 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Main--->{0}", i);
            }
        }
        static void Imprime()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0}-->{1}", Thread.CurrentThread.ManagedThreadId, i);
            }
        }
    }
}
