using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_iterador
{
    class Contenedora : IEnumerable
    {
        private int[] valores = new int[10];
        public Contenedora()
        {
            for (int i = 0; i < 10; i++)
            {
                valores[i] = i * i;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (new ContenedorEnum(valores));
        }
    }
    class ContenedorEnum : IEnumerator
    {
        private int[] arreglo;
        private int posicion = -1;

        public ContenedorEnum(int [] arreglo)
        {
            this.arreglo = arreglo;
        }
        public bool MoveNext()
        {
            posicion++;
            if (posicion<arreglo.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            posicion = -1;
        }
        public object Current
        {
            get{ return arreglo[posicion]; }
        }
    }
}
