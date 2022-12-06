using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _16__Mutex
{
    class Program
    {
        static void Main(string[] args)
        {
            //ES OTRO MECANISMO DE SINCRONIZACION, CON FALSE SE INDICA QUE EL HILO QUE LO INVOCA
            //NO POSEE AL MUTEX. EL TEXTO ES TU NOMBRE. PARA EJECUTAR DOS INSTANCIAS: SE COMPILA DESDE 
            //EL EXPLORADOR DE SOLUCIONES Y LUEGO CNTRL+F5 DOS VECES.
            using (Mutex mutex = new Mutex(false, "mutex"))
            {
                //DETECTAMOS SI EXISTE OTRA INSTANCIA Y LE DAMOS UN SEGUNDO POR SI ESTA FINLAIZANDO
                if (!mutex.WaitOne(TimeSpan.FromMilliseconds(1000), false))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Otra instancia existe");
                    Thread.Sleep(1000);
                    //SALIMOS DE LA EJECUCION
                    return;
                }
                ejecutar();
            }
        }
        static void ejecutar()
        {
            int n = 0;
            while (n<10000)
            {
                Console.WriteLine(n);
                n++;
            }
        }
    }
}
