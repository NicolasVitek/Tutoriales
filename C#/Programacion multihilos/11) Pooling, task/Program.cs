using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _11__Pooling__task
{
    class Program
    {
        static private bool ejecutar = true;
        private static int conteo = 0;
        static void Main(string[] args)
        {
            //CUANDO SE CREA UN HILO SE HACEN ALGUNAS OPERACIONES. EL POOLING AYUDA A REDUCIR ESO
            //RECICLANDO HILOS. TENEMOS CONTROL DEL NUMERO DE HILOS QUE ESTAN TRABAJADO
            //LA CLASE GENEICA TASK<RESULT> REEMPLAZA A LOS DELEGADOS 
            Task task = Task.Factory.StartNew(incrementar);
            //EL WAIT PERMITE QUE EL TASK FINALICE SU EJECUCION POR UN INTERVALO DE TIEMPO
            task.Wait(TimeSpan.FromMilliseconds(1000));
            Console.WriteLine("El valor final del conteo es " + conteo);
        }
        static void incrementar()
        {
            while (ejecutar)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                conteo = conteo + 1;
                Console.Write(Thread.CurrentThread.ManagedThreadId);
                Console.Write(" -->{0}", conteo);
                if (conteo > 100)
                {
                    ejecutar = false;
                }

            }
        }
    }
}
