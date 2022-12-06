using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20__Objeto_inmutable
{
    class Program
    {
        //UN OBJETO INMUTABLE ES AQUEL DONDE SUS CAMPOS SON DECLARADOS COMO SOLO LECTURA
        //SU ESTADO NO SE PUEDE CAMBIAR. SI SE NECESITA CAMBIAR, SE CREA UNO NUEVO CON EL
        //ESTADO QUE NECESITAMOS
        static readonly object control = new object();
        static Clase productoPrincipal;
        static void Main(string[] args)
        {
            Clase producto = new Clase(25, "manzana");
            //REFERENCIA AL PRODUCTO DE FORMA SEGURA
            lock (control)
            {
                productoPrincipal = producto;
            }
            Console.WriteLine(productoPrincipal);
            int valor = productoPrincipal.valor;
            string nombre = productoPrincipal.producto;
            Console.WriteLine("Producto " + nombre + " de valor " + valor);

        }
    }
}
