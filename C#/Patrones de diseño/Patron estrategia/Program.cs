using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_estrategia
{
    class Program
    {
        //SE FORMA CON UNA FAMILIA DE ALGORITMOS QUE ESTAN ENNCAPSULADOS
        //LA IDEA ES HACER ESOS ALGORITMOS INTERCAMBIABLES Y USAR EL MEJOR
        //PARA EL CASO DESEADO.
        //SE PUEDE APLICAR PARA: GUARDAR ARCHIVOS EN DIFERENTES FORMATOS, 
        //COMPRESION CON DIFERENTES ALGORITMOS, O FORMAS DE REPRESENTAR
        //INFORMACION. LAS PARTES SON:
        //-CONTEXTO-->UNA CLASE QUE CONTIENE LA INFORMACION DEL CONTEXTO
        //SOBRE EL CUAL TRABAJAND LOS ALGORITMOS
        //-IESTRATEGIA-->UNA INTERFAZ COMUN A TODOS LOS ALGORITMOS
        //ESTRATEGIA n-->ALGORITMOS

        //LAS INTERFACES SON CLASES ABTRACTAS QUE RESUELVEN EL PROBLEMA
        //DE HERENCIA MULTIPLE QUE NO SE PUEDE HACER CON CLASES COMUNES

        static void Main(string[] args)
        {
            string dato = "";
            double x = 0;
            double y = 0;
            double r = 0;
            string opcion = "";

            //VARIABLE QUE REFERENCIA AL ALGORITMO. SE INSTANCIA CON DEFAULT
            //PARA UNA COMPILACION CORRECTA
            IOperacion operacion = new Suma();
            while (opcion !="5")
            {
                Console.WriteLine("1) Suma, 2) Resta, 3) Multiplicacion, 4) Division, 5) Salir");
                opcion = Console.ReadLine();
                if (opcion=="5")
                {
                    break;
                }
                Console.WriteLine("Indique un valor de a: ");
                dato = Console.ReadLine();
                x = Convert.ToDouble(dato);
                Console.WriteLine("Indique un valor de b: ");
                dato = Console.ReadLine();
                y = Convert.ToDouble(dato);

                //SE SELECCIONA EL ALGORITMO DE ACUERDO A LA NECESIDAD
                if (opcion=="1")
                {
                    operacion = new Suma();
                }
                if (opcion=="2")
                {
                    operacion = new Resta();
                }
                if (opcion == "3")
                {
                    operacion = new Multiplicacion();
                }
                if (opcion == "4")
                {
                    operacion = new Division();
                }
                r = operacion.operacion(x, y);
                Console.WriteLine("El resultado es " + r);

            }

        }
    }
}
