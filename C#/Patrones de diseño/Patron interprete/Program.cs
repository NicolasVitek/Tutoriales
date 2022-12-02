using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_interprete
{
    class Program
    {
        //INTERPRETA UNA INSTRUCCION ESCRITA EN UN LENGUAJE O NOTACION CON UN FIN
        //ESPECIFICO. PODEMOS CREAR UNA GRAMATICA PROPIA. SUS PARTES SON:
        //-CLIENTE-->LA CLASE QUE CONSTRUYE UNA ESTRUCTURA QUE REPRESENTA LA GRAMATICA
        //-CONTEXTO-->UNA CLASE QUE CONTIENE LA INFORMACION A USARSE POR EL INTERPRETE
        //-EXPRESIOABSTRACTA-->CLASE ABSTRACTA QUE PROVEE UNA INTERFAZ PARA LAS CLASES
        //DE LA ESTRUCTURA Y LA OPERACION DEL INTERPRETE.
        //-NOTERMINAL-->UNA CLASE QUE IMPLEMENTA AL INTERPRETE Y PUEDE CONTENER OTROS
        //TERMINOS
        //-TERMINAL-->UNA CLASE QUE IMPLEMENTA AL INTERPRETE.
        static void Main(string[] args)
        {
            string expresion = "MCMXCIV";
            Contexto contexto = new Contexto(expresion);

            List<Expresion> arbol = new List<Expresion>();
            arbol.Add(new ExpresionMiles());
            arbol.Add(new ExpresionCientos());
            arbol.Add(new ExpresionDecenas());
            arbol.Add(new ExpresionUnidad());
           
            


            foreach (Expresion item in arbol)
            {
                item.Interpretar(contexto);
            }
            Console.WriteLine("El numero romano {0} es {1} en decimal", expresion, contexto.Valor);
        }
    }
}
