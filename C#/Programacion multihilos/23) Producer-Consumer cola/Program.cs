using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _23__Producer_Consumer_cola
{
    class Program
    {
        //LA COLA CONTIENE LOS DATOS QUE USAN LOS HILOS PARA TRABAJAR LO CUAL SIRVE
        //PARA TENER UN CONTROL DE LA CANTIDAD DE HILOS QUE SE EJECUTAN. CON IDISPOSABLE
        //APROVECHAMOS EL USING Y ASI NO NOS PREOCUPA LA LIBERACION DE RECURSOS
        static void Main(string[] args)
        {
            using (Cola cola = new Cola())
            {
                Console.WriteLine("Empzamos del lado de main");
                for (int i = 0; i < 5; i++)
                {
                    cola.agregar(i);
                }
                Console.WriteLine("Main continua con lo suyo mientras cola hace el trabajo");
            }
        }
    }
}
