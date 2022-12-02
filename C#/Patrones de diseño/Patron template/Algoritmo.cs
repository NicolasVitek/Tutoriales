using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_template
{
    class Algoritmo
    {
        public double metodoTemplate(IPrimitiva tipo, int cantidad)
        {
            double total = 0;
            //CREAR JUGUETE
            total += crearJuguete(cantidad);
            //LO DECORAMOS
            total += tipo.Decorar(cantidad);
            //VERIFICAMOS CALIDAD
            calidad();
            //EMPACAMOS
            total += tipo.Empacar(cantidad);
            return total;
        }
        private double crearJuguete(int cantidad)
        {
            Console.WriteLine("Estamos creando {0} juguetes", cantidad);
            return 16.50 * cantidad;
        }
        private void calidad()
        {
            Console.WriteLine("Paso el control de calidad");
        }
    }
}
