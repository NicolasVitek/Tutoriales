using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _23__Producer_Consumer_cola
{
    class Cola: IDisposable
    {
        //EL TIPO ES NULLEABLE PARA INDICAR LA FINALIZACION DEL HILO TRABAJADOR
        private Queue<int?> datos = new Queue<int?>();
        private readonly object control = new object();
        private Thread trabajador;
        private bool ejecuta = true;
        private EventWaitHandle manejador = new AutoResetEvent(false);

        public Cola()
        {
            trabajador = new Thread(calculo);
            trabajador.Start();
        }
        public void agregar(int? dato)
        {
            lock (control) datos.Enqueue(dato);
            //INDICAMOS QUE YA PUEDE TRABAJAR
            manejador.Set();
        }
        public void Dispose()
        {
            //AGREGAMOS UN NULL PARA INDICAR QUE FINALIZA
            agregar(null);
            //ESPERAMOS QUE EL HILO TERMINE SU TRABAJO
            trabajador.Join();
            //LIBERAMOS LOS RECURSOS QUE TENGA EL MANEJADOR
            manejador.Close();
        }
        void calculo()
        {
            while (ejecuta)
            {
                int? dato = null;
                lock (control)
                {
                    //SI AUN HAY DATOS TOMAMOS OTRO
                    if (datos.Count>0)
                    {
                        //DESENCOLAMOS EL SIGUIENTE DATO
                        dato = datos.Dequeue();
                        if (dato==null)
                        {
                            ejecuta = false;
                            return;
                        }
                    }
                }
                if (dato!=null)
                {
                    //ACA VA EL TRABAJO QUE VA A REALIZAR EL HILO
                    Console.WriteLine("El cuadrado de " + dato + " es " + dato * dato);
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("En espera, el hilo trabaja pero no tiene datos");
                    //ESPRAMOS A RECIBIR LA SEÑAL
                    manejador.WaitOne();
                }
            }
        }
    }
}
