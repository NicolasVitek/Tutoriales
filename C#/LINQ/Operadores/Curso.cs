using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Curso
    {
        public string curso;
        public double id;

        public Curso(string curso, int id)
        {
            this.curso = curso;
            this.id = id;
        }
        public override string ToString()
        {
            return string.Format("Curso==>{0}", curso);
        }
    }
}
