using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_basicas
{
    class Estudiante
    {
        public string nombre, id, curso;
        public double promedio;

        public Estudiante(string nombre, string id, string curso, double promedio)
        {
            this.nombre = nombre;
            this.id = id;
            this.curso = curso;
            this.promedio = promedio;
        }
        public override string ToString()
        {
            return string.Format("Nombre: {0}, {1}, curso: {2}, promedio: {3}", nombre, id, curso, promedio);
        }
    }
}
