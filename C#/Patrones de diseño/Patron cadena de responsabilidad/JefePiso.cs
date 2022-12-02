using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_cadena_de_responsabilidad
{
    class JefePiso:IHandler
    {
        private IHandler siguiente = null;

        public JefePiso(IHandler siguiente)
        {
            this.siguiente = siguiente;
        }
        public double calcularPrecio(int precio, int cantidad)
        {
            Console.WriteLine("Con el jefe de piso");
            //SI SON MAS DE 100 ARTUCULOS O MAS DE 75000 EN
            //VENTAS PASA AL PROPIETARIO
            double total = cantidad * precio;
            if (cantidad > 100 || total > 75000)
            {
                total = siguiente.calcularPrecio(cantidad, precio);
            }
            else
            {
                //SI SON MAS DE 20, DAMOS UN DESCUENTO
                if (cantidad > 20)
                {
                    total *= 0.95;
                }
            }
            return total;
        }
    }
}
