using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_comando
{
    class Program
    {
        //CREA UNA SEPARACION ENTRE QUIEN HACE UNA PETICION Y QUIEN LA LLEVA A CABO
        //SE PUEDE IMPLEMENTAR DE FORMA NORMAL O CON DELEGAGOS. SUS PARTES SON:
        //-COMANDO-->CLASE QUE COMUNICA AL CLIENTE CON LOS RECEPTORES
        //-INVOKER-->CREA LA DISTANCIA ENTRE EL CLIENTE Y EL RECEPTOR Y LE PIDE AL 
        //COMANDO QUE LLEVE A CABO LA ACCION
        //-CLIENTE-->INOVA A EJECUTAR EN INVOKER Y LA PETICION LLEGA A COMANDO, DE
        //AHI A LA ACCION EN EL RECEPTOR.
        //-ICOMANDO-->INTERFAZ QUE ESPECIFICA LA OPERACION EJECUTAR.
        //-RECEPTOR-->LA CLASE QUE LLEVA A CABO LA ACCION.
        //-EJECUTAR-->LA OPERACION QUE NECESITA SER LLEVADA A CABO.
        static void Main(string[] args)
        {
            Automovil auto = new Automovil();
            ControlRemoto control = new ControlRemoto(auto);
            int opcion;
            do
            {
                Console.WriteLine("1)Encender 2) Apagar 3) Prender Alarma 4) Apagar alarma 5) Salir");
                opcion = int.Parse(Console.ReadLine());
                if (opcion==1)
                {
                    control.Boton(0);
                }
                if (opcion == 2)
                {
                    control.Boton(1);
                }
                if (opcion == 3)
                {
                    control.Boton(2);
                }
                if (opcion == 4)
                {
                    control.Boton(3);
                }
            } while (opcion !=5);
        }
    }
}
