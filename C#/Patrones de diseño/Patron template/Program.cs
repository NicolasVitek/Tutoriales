using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_template
{
    class Program
    {
        //PERMITE QUE LOS PASOS DE ALGUN ALGORITMO SEAN EJECUTADO POR CLASES
        //SE USAN EN FRAMWRORKS. SUS PARTES SON:
        //-ALGORITMO-->LA CLASE QUE INCLUYE EL MEOTOD TEMPLATE
        //-METODOTEMPLATE-->EL METODO QUE DEFINE ALGUNAS PARTES DE LA OPERACION
        //Y DELEGA OTRAS A LAS CLASES
        //-IPRIMITIVA-->LA INTERFAZ QUE DEFINE LA OPERACION QUE HA SIDO DELEGADA
        //-CLASE n-->CUALQUIER CLASE QUE IMPLEMENTA A LA INTERFAZ IPRIMITIVA
        //-OPERACION-->METODO QUE SE NECESITA PARA COMPLETAR LA OPERACION.
        static void Main(string[] args)
        {
            int cantidad = 0;
            string tipo = "";
            IPrimitiva calidad = null;
            double total = 0;
            Console.WriteLine("1) Barato, 2) Normal");
            tipo = Console.ReadLine();
            if (tipo=="1")
            {
                calidad = new Barato();
            }
            if (tipo=="2")
            {
                calidad = new Normal();
            }
            Console.WriteLine("¿Cuantos producira?");
            cantidad = int.Parse(Console.ReadLine());

            Algoritmo produccion = new Algoritmo();
            total = produccion.metodoTemplate(calidad, cantidad);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("El total es " + total);

        }
    }
}
