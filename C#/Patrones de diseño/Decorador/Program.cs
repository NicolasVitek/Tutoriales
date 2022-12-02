using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    class Program
    {
        //PROVEE UN MECANISMO PARA COLOCAR UN NUEVO COMPORTAMIENTO Y/O ESTADO A UN
        //OBJETO DE FORMA DINAMICA. EL OBJETO NO SABE QUE ESTA SIENDO DECORADO. SUS
        //PARTES SON:
        //-COMPONENTE-->LA CLASE ORIGINAL QUE ESA SIENDO DECORADA
        //-ICOMPONENT-->LA INTEFAZ QUE IDENTIFICA A LOS OBJETOS QUE PUEDEN SER DECORADOS
        //-OPERACION-->LA OPERACION EN COMPONENTE QUE PUEDE SER REEMPLAZADA
        //-DECORADOR-->LA CLASE QUE IMPLEMENTA A LA INTERFAZ Y AGREGA COMPORTAMIENTO.
        static void Main(string[] args)
        {
            IComponente auto = new Auto("2018", "4 puertas", 200000);
            Console.WriteLine(auto);
            ((Auto)auto).Puertas(true);
            Console.WriteLine(auto.GetType());
            Console.WriteLine();
            //DECORAMOS CON UN SISTEMA DE SONIDO
            auto = new SistemaSonido(auto);
            //COMPROBAMOS LA ADICION DE LAS CARACTERISTICAS
            Console.WriteLine(auto.Costo());
            Console.WriteLine(auto.Funciona());
            Console.WriteLine(auto);
            Console.WriteLine(auto.GetType());
            Console.WriteLine();
            //DECORAMOS CON NITROGENO
            auto = new Nitrogeno(auto);
            //COMPROBAMOS LA ADICION DE LAS CARACTERISTICAS
            Console.WriteLine(auto.Costo());
            Console.WriteLine(auto.Funciona());
            Console.WriteLine(auto);
            Console.WriteLine(auto.GetType());
            Console.WriteLine();
            //PARA USAR ALGO DE NITROGENO NECESITAMOS HACER UN CAST
            //XQ UNA VEZ DECORADO EL OBJETO CAMBIA DE TIPO
            ((Nitrogeno)auto).Usa();
            //DECORAMOS CON SUSPENSION
            auto = new Suspension(auto);
            //COMPROBAMOS LA ADICION DE LAS CARACTERISTICAS
            Console.WriteLine(auto.Costo());
            Console.WriteLine(auto.Funciona());
            Console.WriteLine(auto);
            Console.WriteLine(auto.GetType());
            Console.WriteLine();
        }
    }
}
