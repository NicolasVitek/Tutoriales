using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_proxy
{
    class Program
    {
        //DA SOPORTE A OTROS OBJETOS QIE CONTROLAN LA CREACION Y EL ACCESO A OTROS OBJETOS
        //ES UN INTERMEDIARIO ENTRE EL CLIENTE Y ESOS OBJETOS. SE PUEDE USAR PARA LOGIN 
        //PUEDE DE SER DE TIPO REMOTO, VIRTUAL, SMART O AUTENTIFCACION. SUS PARTES SON:
        //-ISUJETO-->INTERFAZ COMUN ENTRE EL SUJETO Y EL PROXY
        //-SUJETO-->LA CLASE QUE ES REPRESENTADA POR EL PROXY
        //-PROXY-->LA CLASE QUE CREA, CONTROLA Y DA ACCESO AL SUJETO
        //-PETICION-->UNA OPERACION EN EL SUJETO QUE ES ENVIADA VIA EL PROXY

        static void Main(string[] args)
        {
            Proxy.ISujeto proxy = new Proxy.ProxySencillo();
            proxy.Peticion(1);
            Console.WriteLine();
            proxy.Peticion(2);
            Console.WriteLine();

            Proxy.ISujeto proxy2 = new Proxy.ProxySeguro();
            proxy2.Peticion(1);
            Console.WriteLine();
            proxy2.Peticion(2);
            Console.WriteLine();

        }
    }
}
