using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_cadena_de_responsabilidad
{
    class Program
    {
        //SE TIENE UNA SERIE DE OBJETOS QUE FUNCIONAN COMO MANEJADORES.
        //SE GENERA UNA PETICION Y SE MANDA AL PRIMER OBJETO, SI NO PUEDE
        //CUMPLIRLA SE MANDA AL SIGUIENTE Y ASI SUCESIVAMENTE. SI NINGUNO
        //PUEDE LLEVARLA A CABO SE GENERA UNA EXCEPCION O DEFAULT. SUS PARTES;
        //-INTERFAZ QUE SE IMPLEMENTA POR LOS MANEJADORES 
        //-CLIENTE-->LA CLASE QUE INICIA LA PETICION
        //-IHANDLER-->LA INTERFAZ COMUN A TODOS LOS MANDEJADORES
        //-HANDLER n-->LA CLASE QUE IMPLEMENTA AL MANEJADOR
        //-SUCESOR-->REFERENCIA AL SIGUIENTE MANEJADOR.
        static void Main(string[] args)
        {
            Propietario propietario = new Propietario();
            JefePiso jefe = new JefePiso(propietario);
            Vendedor vendedor = new Vendedor(jefe);

            int cantidad = 50;
            int precio = 1000;
            double total = 0;
            total = vendedor.calcularPrecio(precio, cantidad);
            Console.WriteLine("Total {0}, con descuento {1}", cantidad * precio, total);
        }
    }
}
