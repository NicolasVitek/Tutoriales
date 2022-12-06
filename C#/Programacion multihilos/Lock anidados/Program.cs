using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _15__Lock_anidados
{
    class Program
    {
        //EL LOCK ANIDADO SIGNIFICA QUE UN METODO QUE TIENE LOCK INVOCA A OTRO METODO QUE TIENE LOCK
        //EL HILO BLOQUEARA EL LOCK MAS EXTERNO, EL QUE SE INVOCA PRIMERO.
        static void Main(string[] args)
        {
            Thread hilo = new Thread(Segura.operacion);
            hilo.Start();
        }
    }
}
