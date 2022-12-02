using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_interprete
{
    class Contexto
    {
        public string Expresion;
        public int Valor;

        public Contexto(string expresion)
        {
            this.Expresion = expresion;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Se evaluara {0}", expresion);
        }
    }
}
