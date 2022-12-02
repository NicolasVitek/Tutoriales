using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_visitante
{
    class Visitante:IVisitante
    {
        public int Conteo;
        public int Calificaciones;
        public double Total;

        public void ContarElementos(Elemento elemento)
        {
            //NOS MANDAMOS COMO VISITANTE AL ELEMENTO
            elemento.Aceptar(this);
            if (elemento.hijo!=null)
            {
                ContarElementos(elemento.hijo);
            }
            if (elemento.siguiente!=null)
            {
                ContarElementos(elemento.siguiente);
            }
        }
        public void Visitar (Elemento elemento)
        {
            Conteo++;
            Total += elemento.Costo;
        }
        public void Visitar(ElementoL elemento)
        {
            Calificaciones++;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("No conteo");
        }
    }
}
