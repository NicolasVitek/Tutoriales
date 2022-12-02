using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_flyweight
{
    class Receta: IFlyweights
    {
        private string nombre;
        private double costo, venta;

        public void colocarNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void calcularCosto()
        {
            foreach (char item in nombre)
            {
                costo += (int)item;
            }
            venta = costo * 1.30;
        }
        public void mostrar()
        {
            Console.WriteLine("{0} cuesta {1}", nombre, venta);
        }
        public string obtenerNombre()
        {
            return nombre;
        }
    }
}
