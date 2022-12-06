using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
//BIBLIOTECA AGREGADA
using System.ComponentModel;

namespace Background_Worker
{
    class Program
    {
        //SE USA PARA ADMINISTRAR UN HILO QUE LLEVA A CABO UN TRABAJO EN PARTICULAR. NO SE DEBE
        //USAR ABORT CON HILOS QUE USEN ESTA CLASE.

        static BackgroundWorker trabajador;
        static void Main(string[] args)
        {
            trabajador = new BackgroundWorker
            {
                //INDICAMOS QUE VA A INCIAR EL PROGRESO DE TRABAJO
                WorkerReportsProgress = true,
                //INDICAMOS QUE PODEMOS CANCELAR EL TRABAJO
                WorkerSupportsCancellation = true
            };
            //COLOCAMOS LOS DELEGADOS PARA LOS EVENTOS

            //INDICAMOS EL METODO QUE HACE EL TRABAJO
            trabajador.DoWork += trabajo;
            //INDICAMOS EL METODO QUE HACE EL PROGRESO
            trabajador.ProgressChanged += progreso;
            //INDICAMOS EL METODO PARA INDICAR QUE HA FINALIZADO
            trabajador.RunWorkerCompleted += finalizado;
            //INICIAMOS EL PROCESO
            trabajador.RunWorkerAsync("Inicia el trabajo");
            Console.WriteLine("Oprime una tecla para continuar");
            //SI SE OPRIME UNA TECLA Y YA ESTA TRRABAJANDO SE CANECLA
            Console.ReadLine();
            if (trabajador.IsBusy)
            {
                trabajador.CancelAsync();
                Console.ReadLine();
            }
        }
        static void trabajo(object sender, DoWorkEventArgs e)
        {
            //OBTENEMOS EL ARGUMENTO ENVIADO
            Console.WriteLine(e.Argument);
            //LLEVAMOS A CABO EL TRABAJO
            int sumatoria = 0;
            //EJEMPLIFICAMOS EL TRABAJO
            for (int i = 0; i < 100; i++)
            {
                //VERIFICAMOS SI HAY CANCELACION
                if (trabajador.CancellationPending)
                {
                    //INDICAMOS LA CANCELACION E INDICAMOS EL METODO DE TRABAJO
                    e.Cancel = true;
                    return;
                }
                //HACEMOS EL TRABAJO
                sumatoria += i;
                Thread.Sleep(100);
                //INDICAMOS EL PROGRESO
                trabajador.ReportProgress(i);
            }
            //UNA VEZ FINALIZADO EL TRABAJO, INDICAMOS EL RESULTADO EL CUAL SERA
            //PASADO A RUNWORKERCOMPLETED
            e.Result = sumatoria;
        }
        static void progreso(Object sender, ProgressChangedEventArgs e)
        {
            //PARA EL EJEMPLO, SE MUESTRA CADA 5%
            if (e.ProgressPercentage%5==0)
            {
                Console.WriteLine("{0}% completado", e.ProgressPercentage);
            }
        }
        //ESE METODO SE INVOCA CUANDO EL TRABAJO TERMINO
        static void finalizado(Object sender, RunWorkerCompletedEventArgs e)
        {
            //VERIFICAMOS SI HUBO CANCELACION
            if (e.Cancelled)
            {
                Console.WriteLine("Se cancelo el trabajo");
            }
            //VERIFICAMOS SI HUBO UNA EXCEPCION
            else if (e.Error!=null)
            {
                Console.WriteLine("Hubo un problema + "+ e.Error.ToString());
            }
            //MOSTRAMOS EL RESULTADO
            else
            {
                Console.WriteLine("Trabajo terminado");
                Console.WriteLine(e.Result);
                Console.WriteLine("Oprime cualquier tecla para continuar");
            }
        }
    }
}
