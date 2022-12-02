using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_mediador
{
    class Mediador
    {
        //CREAMOS UN DELEGADO QUE USAREMOS PARA INVOCAR LOS METODOS
        public delegate void Envio(string emisor, string mensaje);
        Envio enviarMensaje;

        //METDDO A INVOCAR
        public void Suscribir(Envio metodo)
        {
            enviarMensaje += metodo;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---Suscrito---");
        }
        public void Enviar(string emisor, string mensaje)
        {
            //USAMOS EL MEDIADOR PARA CENSURAR
            if (mensaje.Contains("Palabrota"))
            {
                mensaje = mensaje.Replace("Palabrota", "******");
            }
            //ENVIAMOS LOS MENSAJES CORRESPONDIENTES VIA EL DELEGADO
            enviarMensaje(emisor, mensaje);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---Mensaje enviado---");
        }
        //SACAMOS EL METODO DEL DELEGADO, YA NO SERA INVOCADO
        public void Bloqueo(Envio metodo)
        {
            enviarMensaje -= metodo;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---Bloqueo---");
        }
    }
}
