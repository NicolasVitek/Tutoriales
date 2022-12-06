using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Cancel
{
    class Program
    {
        static bool ejecuta = true;
        static int conteo = 0;
        static void Main(string[] args)
        {
            Random rmd = new Random();
            //CREAMOS EL CANCELADOR
            CancellationTokenSource cancelador = new CancellationTokenSource();
            //CREAMOS EL HILO Y PASAMOS EL TOKEN DEL CANCELADOR
            Thread hilo = new Thread(() => trabajo(cancelador.Token));
            hilo.Start();

            int m = 0;
            while (m<1000 && ejecuta)
            {
                //HACEMOS LA INTERRUPCION
                if (rmd.Next(100)<2)
                {
                    //AL CUMPLIRSE LA CONDICION PEDIMOS LA CANCELACION
                    cancelador.Cancel();
                }
                Thread.Sleep(50);
                m++;
            }

        }
        static void trabajo(CancellationToken token)
        {
            while (ejecuta)
            {
                try
                {
                    //INVOCAMOS EL METODO PARA SABER SI HUBO UNA CANCELACION
                    token.ThrowIfCancellationRequested();
                    conteo++;
                    Console.WriteLine("En trabajo " + conteo);
                    Thread.Sleep(50);
                    if (conteo>1000)
                    {
                        ejecuta = false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Se cancelo");
                    ejecuta = false;    
                }
            }
        }
    }
}
