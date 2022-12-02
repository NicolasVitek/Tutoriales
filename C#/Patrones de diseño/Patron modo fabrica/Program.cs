using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_modo_fabrica
{
    class Program
    {
        //PERMITE CREAR OBJETOS PERO DEJA DEJA A LAS SUBCLASES DECIDIR QUE 
        //CLASE INSTANCIAR. ESTO SE DECIDE SEGUN LA INFORMACION QUE PROVEA
        //EL CLIENTE. AYUDA A CREAR INDEPENDENCIA ENTRE SUS CLASES AL PROGR
        //AMAR HACIA UNA INTERFAZ SUS PARTES SON:
        //-IPRODUCTO-->LA INTERFAZ PARA LOS PRODUCTOS
        //-PRODUCTO n-->CLASE QUE IMPLEMENTA A IPRODUCTO
        //-CREADOR-->PROVEE EL METODO FABRICA
        //-METODOFABRICA-->DECIDE QUE CLASE INSTANCIAR
        static void Main(string[] args)
        {
            int dinero;
            IVehiculo vehiculo;

            Console.WriteLine("¿Cuanto dinero tienes para tu vehiculo? ");
            dinero = int.Parse(Console.ReadLine());
            vehiculo = Creador.metodoFabrica(dinero);
            vehiculo.Acelerar();
            vehiculo.Encender();
            vehiculo.Frenar();
            vehiculo.Girar();
        }
    }
}
