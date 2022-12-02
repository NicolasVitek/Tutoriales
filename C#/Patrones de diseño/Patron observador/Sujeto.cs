using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_observador
{
    class Sujeto
    {
        private List<IObservador> observadores = new List<IObservador>();
        private string mensaje;
        private Random rmd = new Random();
        public int N;

        public void Suscribir(IObservador suscrito)
        {
            observadores.Add(suscrito);
        }
        public void Desuscribir(IObservador suscrito)
        {
            observadores.Remove(suscrito);
        }
        private void Notificar()
        {
            //NOTIFICAMOS EL NUEVO ESTADO A LOS OBSERVADORES QUE ESTEN SUSCRITOS
            foreach (IObservador item in observadores)
            {
                //item.Update(mensaje);
                item.UpdatePull();
            }
        }
        //AQUI SIMULAMOS EL TRABAJO DEL OBSERVADOR Y UN CAMBIO DE ESTADO QUE NECESITA
        //SER NOTIFICADO
        public void Trabajo()
        {
            N = rmd.Next(10);
            if (N%2==0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("--Nuevo estado valido--");
                mensaje = string.Format("El nuevo valor es " + N);
                Notificar();
            }
        } 
    }
}
