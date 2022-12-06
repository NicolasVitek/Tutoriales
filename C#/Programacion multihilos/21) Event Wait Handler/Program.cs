using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _21__Event_Wait_Handler
{
    class Program
    {
        //ES USADO PARA LA SEÑALIZACION. AUTORESETEVENT PERMITE SACAR EL LOCK CUANDO RECIBE
        //LA SEÑAL DE OTRO. EL HILO BLOQUEA O ESPERA AL INVOCAR WAITONE, SI VARIOS HILOS HACEN
        //LA INVOCACION SE CREA UNA COLA

        static EventWaitHandle manejador = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            Thread hilo = new Thread(contador);
            hilo.Start();
            //PONEMOS EL HILO A DORMIR ANTES DE HACER EL SET Y QUE HILO PUEDA COTINUAR
            Console.WriteLine("A dormir...");
            Thread.Sleep(3000);
            manejador.Set();
            Console.WriteLine("Fin desde main");
        }
        static void contador()
        {
            Console.WriteLine("Estamos en el contador");
            //QUEDA EN ESPERA, NADIE PUEDE AVANZAR MAS
            manejador.WaitOne();
            Console.WriteLine("Alguien ya me deja trabajar");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
