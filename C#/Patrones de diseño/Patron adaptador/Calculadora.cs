using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_adaptador
{
    class Calculadora
    {
        //ESTA CLASES ES LA QUE QUEREMOS ADAPTAR, EL CLIENTE NO LA PUEDE
        //USAR DIRECTAMENTE XQ USA OTRA INTERFAZ.

        public double suma(int[] operandos)
        {
            int r = 0;
            for (int i = 0; i < operandos.Length; i++)
            {
                r += operandos[i];
            }
            return r;
        }
    }
}
