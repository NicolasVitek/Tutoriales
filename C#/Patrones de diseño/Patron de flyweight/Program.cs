using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_flyweight
{
    class Program
    {
        //PERMITE COMPARTIR INFORMACION QUE SE ENCUENTRA EN PEQUEÑOS OBJETOS
        //QUE EXISTEN EN GRANDES CANTIDADES. AYUDA A REDUCIR LAS NECESIDADES 
        //DE ALMACENAMIENTO. SUS PARTES SON:
        //-CLIENTE-->ES EL QUE MANTIENE EL ESTADO NO COMPARTIDO.
        //-IFLYWEIGHT-->LA INTERFAZ POR MEDIO DE LA CUAL LOS FLYWEIGHT PUEEDN
        //RECIBIR O ACTUAR SOBRE SU ESTADO INTRINSECO.
        //-FLYWEIGHTFACTORY-->ADMINISTRA A LOS OBJETOS FLYWEIGHT.
        //-FLYWEIGHT-->GUARDA EL ESTADO INTRINSECO QUE SE COMPARTE A TODOS LOS
        //OBJETOS.
        //EL PATRON DISTINGUE DOS ESTADOS PARA LOS OBJETOS:
        //-INTRINSECO-->SE PUEDE COMPARTIR A GRAN ESCALA
        //-EXTRINSECO-->EL ESTADO SE CALCULA EN EL MOMENTO.
        //EL ESTADO "NO COMPARTIDO" ES EL CONJUNTO DE GRUPOS A LOS QUE PERTENECE.
        static void Main(string[] args)
        {
            int i =0;
            List<int> americana = new List<int>();
            List<int> italiana = new List<int>();
            List<int> mexicana = new List<int>();

            List<int> carnes = new List<int>();
            List<int> sopas = new List<int>();
            List<int> ensaladas = new List<int>();

            List<int> rapidas = new List<int>();

            FlyweightFactory1 flywf = new FlyweightFactory1();
            i = flywf.agregar("Hamburguesa");
            americana.Add(i);
            italiana.Add(i);
            mexicana.Add(i);
            i = flywf.agregar("Queso");
            americana.Add(i);
            ensaladas.Add(i);
            i = flywf.agregar("Minestone");
            italiana.Add(i);
            sopas.Add(i);
            i = flywf.agregar("Antipasto");
            italiana.Add(i);
            ensaladas.Add(i);
            i = flywf.agregar("Tacos");
            mexicana.Add(i);
            carnes.Add(i);
            rapidas.Add(i);
            i = flywf.agregar("Codito");
            sopas.Add(i);
            mexicana.Add(i);
            i = flywf.agregar("Nopales");
            mexicana.Add(i);
            ensaladas.Add(i);
            i = flywf.agregar("Pizza");
            italiana.Add(i);
            rapidas.Add(i);

            foreach (int  item in rapidas)
            {
                Receta receta = (Receta)flywf[item];
                receta.calcularCosto();
                receta.mostrar();
            }
            Console.WriteLine();

            for (int j = 0; j < flywf.conteo; j++)
            {
                Receta receta = (Receta)flywf[j];
                receta.mostrar();
            }
        }
    }
}
