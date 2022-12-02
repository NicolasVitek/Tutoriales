using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_mediador
{
    class Program
    {
        //PERMITE QUE LOS OBJETOS SE COMUNIQUEN SIN CONOCER LA IDENTIDAD DE CADA UNO
        //ENCAPSULA EL PROTOCOLO QUE USAN LOS OBJETOS. SE USA DONDE ES NECESARIO UN
        //PROTOCOLO DE ENVIAR O RECIBIR. O PARA CENTRALIZAR LA INTERCONEXION DE LOS
        //OBJETOS. SUS PARTES SON:
        //-COLEGA-->EL COLEGA SE REGISTRA CON EL MEDIADOR Y LE PERMITE UN METODO RECIBIR
        //-MEDIADOR-->ENVIA MENSAJES A TODOS LOS COLEGAS REGISTRADOS POR MEDIO DE UN
        //DELEGADO DE RESPUESTA.
        //-ICOLEGA-->INTERFAZ QUE DEFINE A LOS COLEGAS
        static void Main(string[] args)
        {
            Mediador mediador = new Mediador();
            ColegaA Ana = new ColegaA("Ana", mediador);
            ColegaA Luis = new ColegaA("Luis", mediador);
            ColegaB David = new ColegaB("David", mediador);

            Ana.Enviar("Saludos");
            Luis.Enviar("Como estan??");
            David.Enviar("Adios");
            Console.WriteLine();

            Console.WriteLine("Verificamos censura");
            Luis.Enviar("La Palabrota no me gusta");
            Console.WriteLine();

            mediador.Bloqueo(Luis.Recibir);
            Ana.Enviar("Adios");
        }
    }
}
