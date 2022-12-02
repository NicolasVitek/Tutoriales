using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_singleton
{
    class Program
    {
        //GARANTIZA QUE EXISTA UNA INSTANCIA DE UNA CLASE. CREA UN OBJETO GLOBAL
        //DE ACCESO PARA ESE OBJETO. LA CLASE SE INSTANCIA UNA VEZ. CREA UNA EXCEP
        //CION SI SE INTENTA INSTANCIAR MAS DE UNA VEZ. SE USA EN ANTIVIRUS, CONEXI
        //ON A BASES DE DATOS, IMPRESORA O HARDWARE. SUS PARTES SON:
        //-SINGLETON-->LA CLASE QUE CONTIENE LO NECESARIO PARA SOLO PRODUCIR UNA
        //INSTANCIA DE SI MISMO.
        //-OBTENERINSTANCIA-->METODO QUE PERMITE OBTENER LA INSTANCIA UNICA.
        static void Main(string[] args)
        {
            Singleton uno = Singleton.obtenerInstancia();
            uno.ponerDatos("Nicolas", 29);
            uno.algunProceso();
            Console.WriteLine(uno);
            Console.WriteLine();
            //COMPROBAMOS QUE ES LA MISMA INSTANCIA
            Singleton dos = Singleton.obtenerInstancia();
            Console.WriteLine(dos);
        }
    }
}
