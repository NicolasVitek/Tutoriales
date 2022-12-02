using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_adaptador
{
    class Program
    {
        //AYUDA A QUE DOS CLASES QUE NO FUERON DISEÑADAS PARA ESO PUEDAN TRABAJAR JUNTAS.
        //SI LAS INTERFACES DIFIEREN, EL ADAPTADOR PERMITE QUE SE PUEDAN COMUNICAR. ES UTIL
        //PARA TRABAJAR CON CODIGO VIEJO. SUS PARTES SON:
        //-ITARGET-->LA INTERFAZ QUE EL CLIENTE CONOCE.
        //-ADAPTADO-->LA IMPLEMENTACION QUE NECESITA SER ADAPTADA.
        //-ADAPTADOR-->LA CLASE QUE IMPLEMENTA ITARGET PARA PODER TRABAJAR CON EL ADAPTADO
        //-PETICION-->LA OPERACION QUE EL CLIENTE DESEA
        //-PETICION ESPECIFICA-->LA IMPLEMENTACION DE LA PETICION EN EL ADAPTADO.
        static void Main(string[] args)
        {
            //ESTE ES EL CLIENTE
            int resultado = 0;
            ITarget calcu = new Calcu();
            resultado = calcu.sumar(4, 3);
            Console.WriteLine("El resultado es " + resultado);
            Console.WriteLine();
            //USAMOS EL ADAPTADOR
            calcu = new Adaptador();
            resultado = calcu.sumar(4, 3);
            Console.WriteLine("El resultado es " + resultado);

        }
    }
}
