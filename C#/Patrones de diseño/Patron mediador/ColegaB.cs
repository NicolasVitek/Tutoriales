using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_mediador
{
    class ColegaB:IColega
    {
        private Mediador mediador;
        private string nombre;
        private int conteo;

        public ColegaB(string nombre, Mediador mediador)
        {
            this.nombre = nombre;
            //TENEMOS LA REFERENCIA AL MEDIADOR
            this.mediador = mediador;
            //NOS SUSCRIBIMOS
            mediador.Suscribir(Recibir);
        }
        public void Recibir(string emisor, string mensaje)
        {
            conteo++;
            //LLEVA A CABO LA RECEPCION SEGUN SU ESTILO
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("<-[{0}, {1}]({2}): {3}", nombre, emisor,conteo, mensaje);
        }
        public void Enviar(string mensaje)
        {
            //AQUI COLOCAMOS LA LOGICA PARA EL ENVIO DE MENSAJE. NO NECESARIAMENTE
            //DEBE DE SER UN PARAMETRO.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[{0}]:{1}", nombre, mensaje);
            mediador.Enviar(nombre, mensaje);
        }
    }
}
