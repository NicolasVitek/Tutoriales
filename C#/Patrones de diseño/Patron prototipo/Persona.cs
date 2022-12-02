using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_prototipo
{
    class Persona:IPrototipo
    {
        public string nombre;
        public int edad;

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}", nombre, edad);
        }
        public object clonar()
        {
            Persona clon = new Persona(nombre, edad);
            return clon;
        }
    }
}
