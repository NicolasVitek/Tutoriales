using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_estado
{
    class Program
    {
        //CUANDO EL ESTADO DEL OBJETO CAMBIA, CAMBIA SU COMPORTAMIENTO. SE
        //PUEDE IMPLEMENTAR: O TODOS LOS ESTADOS SE INSTANCIAN AL PRINCIPIO
        //O SEGUN SEA NECESARIO. SUS PARTES SON
        //-CONTEXTO-->UNA CLASE QUE TIENE UNA INSTANCIA DE ESTADO Y LA INTERFAZ
        //QUE ESPERA AL CLIENTE
        //-IESTADO-->DEFINE LA INTERFAZ PARA UN ESTADO EN PARTICULAR QUE PUEDE
        //TENER EL CONTEXTO.
        //-ESTADO n-->CLASES QUE IMPLEMENTAN LOS ESTADOS CONCRETOS.
        static void Main(string[] args)
        {
            Caldera caldera = new Caldera();

            string opcion;
            do
            {
                Console.WriteLine("1) Cortar fuego, 2) Poner combustible 3) Forzar fuego 4) Salir");
                opcion = Console.ReadLine();
                caldera.Trabajar();
                if (opcion=="1")
                {
                    caldera.CortarFuego();
                }
                if (opcion == "2")
                {
                    caldera.PonerCombustible();
                }
                if (opcion == "3")
                {
                    caldera.ForzarFuego();
                }
                Console.WriteLine(caldera);
            } while (opcion !="4");
        }
    }
}
