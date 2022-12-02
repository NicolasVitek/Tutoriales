using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_comando
{
    class Automovil
    {
        public void Encender()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Se ha encendido el auto");
        }
        public void Apagar()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Se ha apagado el auto");
        }
        public void colocarAlarma()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Alarma encendida");
        }
        public void quitarAlarma()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Alarma apagada");
        }
    }
}
