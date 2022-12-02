using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_mediador
{
    class ColegaA:IColega
    {
        private Mediador mediador;
        private string nombre;

        public ColegaA(string nombre, Mediador mediador)
        {
            this.nombre = nombre;
            //TENEMOS LA REFERENCIA AL MEDIADOR
            this.mediador = mediador;
            //NOS SUSCRIBIMOS
            mediador.Suscribir(Recibir);
        }
        public void Recibir(string emisor, string mensaje)
        {
            //LLEVA A CABO LA RECEPCION SEGUN SU ESTILO
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Soy {0}, recibi de {1}: {2}", nombre, emisor, mensaje);
        }
        public void Enviar(string mensaje)
        {
            //AQUI COLOCAMOS LA LOGICA PARA EL ENVIO DE MENSAJE. NO NECESARIAMENTE
            //DEBE DE SER UN PARAMETRO.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Soy {0}, envio {1}", nombre, mensaje);
            mediador.Enviar(nombre, mensaje);
        }
    }
    }

