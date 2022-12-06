using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CountDown_Event
{
    class Program
    {
        //ES UNA CUENTA REGRESIVA, SE DA UN VALOR DE INICIO Y CADA VEZ QUE SE RECIBE LA SEÑAL
        //LA CUENTA BAJA. CUANDO SE LLEGA A CERO SE LIBERA EL BLOQUEO

        static CountdownEvent conteo = new CountdownEvent(5);
        static bool trabajo = true;
        static void Main(string[] args)
        {
            Thread hilo1 = new Thread(trabajar);
            Thread hilo2 = new Thread(trabajar);
            hilo1.Start();
            hilo2.Start();
            //PONEMOS EN ESPERA AL HILO PRINCIPAL
            conteo.Wait();
            Console.WriteLine("Esto lo lees cuando el conteo es 0");
            trabajo = false; 
        }
        static void trabajar()
        {
            Random rmd = new Random();
            while (trabajo)
            {
                int n = rmd.Next(0, 10);
                if (n>3)
                {
                    //DISMINUIMOS EL CONTEO AL MANDAR SIGNAL
                    conteo.Signal();
                }
                Console.WriteLine(n);
                Thread.Sleep(1000);
            }
        }
    }
}
