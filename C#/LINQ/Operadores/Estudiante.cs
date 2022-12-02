using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Estudiante
    {
        public string nombre;
        public double id;

        public Estudiante(string nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;
        }
        public override string ToString()
        {
            return string.Format("Estudiante {0}, {1}",nombre, id);
        }
    }
}
