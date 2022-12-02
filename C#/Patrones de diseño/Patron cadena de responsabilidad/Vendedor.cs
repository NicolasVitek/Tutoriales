using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_cadena_de_responsabilidad
{
    class Vendedor:IHandler
    {
        private IHandler siguiente = null;

        public Vendedor(IHandler siguiente)
        {
            this.siguiente = siguiente;
        }
        public double calcularPrecio(int cantidad, int precio)
        {
            Console.WriteLine("Con el vendedor");
            //SI SON MAS DE 20 ARTICULOS O MAS DE 20000 EN VENTAS
            //PASA AL JEFE DE PISO
            double total = cantidad * precio;
            if (cantidad>20 || total>20000)
            {
                total = siguiente.calcularPrecio(cantidad, precio);
            }
            else
            {
                //SI SON MAS DE 10, DAMOS UN DESCUENTO
                if (cantidad>10)
                {
                    total *= 0.95;
                }
            }
            return total;
        }
    }
}
