using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//BILBIOTECA AGREGADA
using System.Xml.Linq;

namespace Introduccion
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement raiz = new XElement("raiz");
            XElement elemento1 = new XElement("elemento1");
            elemento1.Add(new XAttribute("atributo", "valor"));
            elemento1.Add(new XElement("Anidado", "Contenido"));
            raiz.Add(elemento1);
            Console.WriteLine(raiz);

        }
    }
}
