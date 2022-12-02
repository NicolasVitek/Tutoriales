using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_visitante
{
    interface IVisitante
    {
        //UN METODO PARA VISITAR CADA TIPO DE ELEMENTO
        void Visitar(Elemento elemento);
        void Visitar(ElementoL elemento);
    }
}
