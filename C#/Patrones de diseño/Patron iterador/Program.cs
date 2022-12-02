using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_iterador
{
    class Program
    {
        //PROVEE UN MECANISMO PARA ACCEDER A LOS ELEMENTOS DE UNA COLECCION 
        //DE FORMA SECUENCIAL SIN TENER QUE CONOCER COMO ESTA ESTRUCTURADA
        //TAMBIEN PUEDE FILTRAR LOS ELEMENTOS DE LA COLECCION. SUS PARTES SON
        //-IENUMERATOR-->INTERFAZ QUE DEFINE EL ENUMERADOR
        //-IENUMERABLE-->INTERFAZ QUE INDICA QUE ESA CLASE PUEDE SER USADA POR
        //EL ITERADOR
        static void Main(string[] args)
        {
            Contenedora datos = new Contenedora();
            foreach (int item in datos)
            {
                Console.WriteLine(item);
            }
        }
    }
}
