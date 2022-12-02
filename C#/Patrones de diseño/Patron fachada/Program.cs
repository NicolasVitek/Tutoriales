using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//PARA USAR SUBSISTEMAS
using Subsistema;

namespace Patron_fachada
{
    class Program
    {
        //SIMPLIFICA EL CONTROL DE SUSBSISTEMAS Y LA INTERFAZ HACIA LOS MISMOS.
        //Y TAMBIEN ESCONDE EL DETALLE DE LOS SUBSISTEMAS. TIENE TRES VARIACIOES:
        //OPACO, TRANSPARENTE, ESTATICA. SUS PARTES SON:
        //-SUBSISTEMA n-->CLASES O CLASES QUE PROVEEN DETERMINADA FUNCIONALIDAD
        //-FACHADA-->LA CLASE QUE PROVEE LAS OPERACIONES DE ALTO NIVEL.
        //-CLIENTE-->USA LA FACHADA PARA LLAMAR A LAS OPERACIONES DE ALTO NIVEL.

        static void Main(string[] args)
        {
            Fachada fachada = new Fachada();
            //USAMOS DE LA FACHADA PARA USAR EL SUBSISTEMAS
            fachada.Compra();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
        }
    }
}
