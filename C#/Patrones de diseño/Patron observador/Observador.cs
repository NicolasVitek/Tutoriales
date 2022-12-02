using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_observador
{
    class Observador:IObservador
    {
        private string nombre;
        private Sujeto sujeto;

        public Observador(string nombre, Sujeto sujeto)
        {
            this.nombre = nombre;
            this.sujeto = sujeto;
            sujeto.Suscribir(this);
        }
        //ESTE METODO ES USADO POR EL SUJETO EN EL PUSH
        public void Update(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Push, {0}--{1}", nombre, mensaje);
        }
        //AQUI PARA EL CASO PULL
        public void UpdatePull()
        {
            int n = sujeto.N;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pull, {0}--{1}", nombre, n);
        }
    }
}
