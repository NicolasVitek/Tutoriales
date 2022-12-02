using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_singleton
{
    class Singleton
    {
        //AQUI SE GUARDA LA UNICA INSTANCIA QUE VA A EXISTIR
        private static Singleton instancia;

        private string nombre;
        private int edad;

        //EL CONSTRUCTOR DEBE SER PRIVADO
        private Singleton()
        {
            nombre = "Sin asignar";
            edad = 90;
        }
        public static Singleton obtenerInstancia()
        {
            if (instancia==null)
            {
                instancia = new Singleton();
                Console.WriteLine("Instancia creada por primera vez");
            }
            return instancia;
        }
        public override string ToString()
        {
            return string.Format("La persona {0} tiene {1} de edad", nombre, edad);
        }
        public void ponerDatos(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        //ESTO REPRESENTA CUALQUIER OTRO OBJETO
        public void algunProceso()
        {
            Console.WriteLine("{0} esta trabajando en algo" + nombre);
        }
    }
}