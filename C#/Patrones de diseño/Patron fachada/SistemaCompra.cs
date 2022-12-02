using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsistema
{
    //REPRESENTA UNO DE LOS SUBSISTEMAS
    class SistemaCompra
    {
        public bool comprar()
        {
            string dato = "";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Introducir numero de la tarjeta: ");
            dato = Console.ReadLine();
            if (dato=="12345")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pago aceptado");
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pago rechazado");
                return false;
            }
        }
    }
    class SubsistemaAlmacen
    {
        private int cantidad;
        public SubsistemaAlmacen()
        {
            cantidad = 3;
        }
        public bool sacarAlmacen()
        {
            if (cantidad>0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Producto listo para enviarse");
                cantidad--;
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Producto no disponible");
                return false;
            }
        }
    }
    class SubsistemaEnvio
    {
        public void enviarPedido()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("El envio va en camino");
        }
    }
}
