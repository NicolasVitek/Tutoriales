using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_compuesto
{
    class Program
    {
        //NOS PERMITE CREAR JERARQUIAS ESTRUCTURADAS CON COMPONENTES SENCILLOS O GRUPO
        //DE COMPONENTES. EL COMPONENT PUEDE SER UN OBJETO O UNA COLECCON DE OTROS 
        //COMPONENTES. SE USA DONDE NECESITAMOS TENER ORGANIZADOS A LOS ELEMENTOS. LOS
        //TIPOS DE ELEMENTOS SON COMPONENTE Y COMPUESTO. AMBOS TIPOS TIENEN UNA INTERFAZ
        //EN COMUN. ESTA FORMADO POR:
        //-ICOMPONENTE-->INTERFAZ QUE REPRESENTA A LOS COMPONENTES
        //-OPERACION-->METODO QUE LLEVA A CABO LA OPERACION QUE ESPERAMOS EN UN ELEMENTO
        //DE LA COMPOSICION
        //-COMPONENTE-->REPRESENTA UN OBJETO SENCILLO QUE NO SE PUEDE DESCOMPONER MAS.
        //-COMPUESTO-->IMPLEMENTA LAS OPERACIONES TRABAJANDO CON UNA COLECCION.
        static void Main(string[] args)
        {
            IComponente<string> arbol = new Compuesto<string>("raiz");
            IComponente<string> trabajo = arbol;
            string opcion = "";
            string dato = "";
            while (opcion != "6")
            {
                Console.WriteLine("Estoy en {0}", trabajo.nombre);
                Console.WriteLine("1) Agregar compuesto, 2) Agregar componente, 3) Borrar, 4) Buscar, 5) Mostrar, 6) Salir");
                opcion = Console.ReadLine();
                Console.WriteLine();
                if (opcion == "1")
                {
                    Console.WriteLine("Indique el nombre del compuesto: ");
                    dato = Console.ReadLine();
                    IComponente<string> c = new Compuesto<string>(dato);
                    trabajo.adicionar(c);
                    trabajo = c;
                }
                if (opcion == "2")
                {
                    Console.WriteLine("Indique el nombre del componente: ");
                    dato = Console.ReadLine();
                    trabajo.adicionar(new Componente<string>(dato));
                }
                if (opcion == "3")
                {
                    Console.WriteLine("Indique el elemento a borrar: ");
                    dato = Console.ReadLine();
                    trabajo = trabajo.borrar(dato);
                }
                if (opcion == "4")
                {
                    Console.WriteLine("Indique el elemento a buscar: ");
                    dato = Console.ReadLine();
                    trabajo = arbol.buscar(dato);
                }
                if (opcion=="5")
                {
                    Console.WriteLine(arbol.mostrar(0));
                }

            }
        }
    }
}
