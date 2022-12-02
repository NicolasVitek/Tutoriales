using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_visitante
{
    class Elemento:IElemento
    {
        public Elemento siguiente;
        public Elemento hijo;
        public double Costo;
        public string Nombre;
        public Elemento()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elemento creado");
        }

        public Elemento(double costo, string nombre, Elemento siguiente)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Elemento creado con siguiente {0}--->${1}", nombre, costo);
            this.Costo = costo;
            this.Nombre = nombre;
            this.siguiente = siguiente;
        }
        //ACEPTAMOS AL VISITANTE. ES VIRTUAL PARA NO HACER OVERRIDE
        public virtual void Aceptar(IVisitante visitante)
        {
            //NOS MANDAMOS COMO PARAMETRO PARA QUE EL VISITANTE PROCESE LO NECESARIO
            visitante.Visitar(this);
        }
    }
}
