using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_MVC
{
    class VistaAuto:IVistaAuto
    {
        public void DespliegaAuto(Auto auto)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("El auto");
            Console.WriteLine("{0} {1}, ${2}", auto.Nombre, auto.Modelo, auto.Costo);
        }
        public int SolicitaEntrada()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1) Cambiar costo 2) Cambiar modelo 3) Salir");
            Console.WriteLine("Ingrese la opcion");
            int opcion = int.Parse(Console.ReadLine());
            return opcion;
        }
    }
}
