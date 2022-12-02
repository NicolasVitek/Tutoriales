using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_prototipo
{
    class Program
    {
        //CREA NUEVOS OBJETOS AL CLONAR A PROTOTIPOS YA EXISTENTES. AGILIZA
        //LA INSTANCIACION DE GRANDES CLASES Y ESCONDE LAS CLASES DE LAS QUE
        //FUERON CREADOS. LA CREACION DEL OBJETO ES POR CLONACION Y SE PUEDE
        //AGREGAR EN TIEMPO DE EJECUCION. SE USA CUANDO LA INSTANCIACION ES 
        //COSTOSA O PARA SUSTITUTIR EL PATRON DE FABRICA. SUS PARTES SON
        //-IPROTOTIPO-->DEFINE LA INTERFAZ QUE INDICA QUE EL PROTOTIPO ES CLONABLE
        //-ADMINPROTOTIPO-->LA CLASE QUE TIENE LA CAPACIDAD DE HACER CLONES.
        //-PROTOTIPO-->CLASE QUE PUEDE SER CLONADA.
        //-CLIENTE-->ADICIONA PROTOTIPOS A LA LISTA Y PIDE CLONES.

        static void Main(string[] args)
        {
            AdminPrototipo adm = new AdminPrototipo();
            Persona uno = (Persona)adm.obtenerPrototipo("Persona");
            Persona dos = (Persona)adm.obtenerPrototipo("Persona");
            //VERIFICAMOS QUE TENGAN LOS MISMOS DATOS
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine();
            //MODIFICAMOS EL ESTADO
            uno.edad = 19;
            dos.edad = 39;
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine();
            Auto auto = new Auto("Nissan", 250000);
            adm.agregarPrototipo("Auto",auto);
            Auto auto2 = (Auto)adm.obtenerPrototipo("Auto");
            auto2.modelo = "Honda";
            Console.WriteLine(auto);
            Console.WriteLine(auto2);
            Console.WriteLine();
            Valores val = (Valores)adm.obtenerPrototipo("Valores");
            Console.WriteLine(val);

        }
    }
}
