using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_compuesto
{
    interface IComponente<T>
    {
        T nombre { set; get; }
        void adicionar(IComponente<T> elemento);
        IComponente<T> borrar(T elemento);
        IComponente<T> buscar(T elemento);
        //LA PROFUNDIDAD REPRESENTA QUE TAN ADENTRO DE LA JERARQUIA ESTA ESE COMPONENTE
        string mostrar(int profundidad);
    }
}
