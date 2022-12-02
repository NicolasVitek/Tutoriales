using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_observador
{
    class Program
    {
        //DEFINE UNA RELACION ENTRE OBJETOS. CUANDO UNO CAMBIA SU ESTADO LOS DEMAS SON
        //NOTIFICADOS. GENERALMENTE SE TIENE UN SUJETO Y VARIOS OBSERVADORES. EN EL MODELO
        //PUSH SE ENVIA TODO RELACIONADO CON EL CAMBIO DE ESTADO, EN EL MODELO PULL SOLO SE
        //INFORMA QUE HAY UN CAMBIO DE ESTADO. SUS PARTES SON:
        //-SUJETO--> LA CLASE QUE CUANDO CAMBIA DE ESTADO, NOTIFICA
        //-IOBSERVADOR-->LA INTERFAZ QUE LOS OBSERVADORES DEBEN DE IMPLEMENTAR PARA RECIBIR
        //NOTIFICACIONES
        //-OBSERVADOR-->LA CLASE QUE ESPERA LA NOTIFICACION DEL SUJETO.
        //-UPDATE-->EL METODO CON EL QUE RECIBE LA NOTIFICACION
        //-NOTIFICAR-->EL METODO QUE ENVIA LA NOTIFICACION.
        static void Main(string[] args)
        {
            Sujeto sujeto = new Sujeto();

            Observador a = new Observador("A", sujeto);
            Observador b = new Observador("B", sujeto);
            Observador c = new Observador("C", sujeto);

            for (int i = 0; i < 5; i++)
            {
                sujeto.Trabajo();
            }
            //ALGUIEN SE SALE DE LA LISTA
            Console.WriteLine("--Desuscribir--");
            sujeto.Desuscribir(b);
            for (int i = 0; i < 5; i++)
            {
                sujeto.Trabajo();
            }
        }
    }
}
