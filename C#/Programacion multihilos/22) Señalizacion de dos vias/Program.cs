using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _22__Señalizacion_de_dos_vias
{
    class Program
    {
        //SE UTILIZA CUANDO HACER SETS CONCECUTIVOS Y COMO ES MUY RAPIDO HAY RIESGO
        //DE PERDER LAS SEÑALES, EL PRIMERO DEEBE ESPERAR AL SEGUNDO PARA CONTINUAR

        static EventWaitHandle principal = new AutoResetEvent(false);
        static EventWaitHandle secundario = new AutoResetEvent(false);
        static readonly object control = new object();
        static string mensaje;
        static bool trabajo = true;
        static void Main(string[] args)
        {
            Thread hilo = new Thread(contador);
            hilo.Start();
            //MAIN QUEDA EN ESPERA HASTA QUE LE PERMITA EL HILO CONTINUAR
            principal.WaitOne();
            lock (control) mensaje = "hola"; 
            secundario.Set();
            principal.WaitOne();
            lock (control) mensaje = "a todos";
            secundario.Set();
            principal.WaitOne();
            lock (control) mensaje = "mis amigos";
            secundario.Set();
            principal.WaitOne();
            //INDICAMOS LA FINALIZACION
            lock (control) mensaje = null;
            secundario.Set();

        }
        static void contador()
        {
            while (trabajo)
            {
                //LE DAMOS PERMISO A MAIN DE CONTINUAR
                principal.Set();
                //ESPERAMOS A QUE MAIN NOS PERMITA CONTINUAR
                secundario.WaitOne();
                //SECCION CRITICA
                lock (control)
                {
                    //VERIFICAMOS SI HAY QUE SALIR DE WHILE
                    if (mensaje==null)
                    {
                        trabajo = false;
                    }
                    Console.WriteLine(mensaje);
                    Thread.Sleep(1000);
                }

            }
        }
    }
}
