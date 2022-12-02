using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_visitante
{
    class Program
    {
        //DEFINE Y LLEVA A CABO NUEVAS OPERACIONES EN LOS ELEMENTOS DE UNA
        //ESTRUCTURA SIN ALTERAR SUS CLASES. SE USAN EN COMPILADORES Y SISTE
        //MAS GRANDES DE SOFTWARE QUE USAN ARBOLES. SUS PARTES SON:
        //-CLIENTE-->LA CLASE QUE CREA LA ESTRUCTURA Y LA LLENA DE DATOS
        //-ESTRUCTURA DE OBJETOS-->UNA ESTRUCTURA COMPUESTA DE TIPOS RELACIONADOS
        //-ELEMENTO-->EL ELEMENTO RAIZ DE LA ESTRUCTURA
        //-ELEMENTO n-->SUBCLASES DEL ELEMENTO
        //-IVISITOR-->INTERFAZ PARA LAS CLASES VISITANTE
        //-VISITANTE n-->CLASES QUE CONTIENEN LOS METODOS QUE ITERAN A LA ESTRUCTURA
        //Y APLICAN LAS OPERACIONES
        static void Main(string[] args)
        {
            double totalCosto = 0;
            int totalObjetos = 0;
            int totalCalificacion = 0;

            Elemento estructuraObjeto =
                new Elemento(89.0, "botiquin",
                new Elemento(25.6, "termometro",
                new ElementoL(
                    new Elemento(35.8, "antibiotico",
                    new Elemento(15.5, "antiacido",
                    new ElementoL(
                        new Elemento(12.8, "aspirina", null),
                        new Elemento(56.6, "anti inflamatorio", null)))),
                    new Elemento(12.8, "gasa",
                    new Elemento(23.5, "cinta",
                    new Elemento(112.5, "tijeras", null))))));

            Visitante visitante = new Visitante();
            visitante.ContarElementos(estructuraObjeto);

            totalCosto = visitante.Total;
            totalCalificacion = visitante.Calificaciones;
            totalObjetos = visitante.Conteo;
            Console.WriteLine("Se tienen {0} objetos con un costo de ${1} en {2} clasficaciones", totalObjetos, totalCosto, totalCalificacion);

        }
    }
}
