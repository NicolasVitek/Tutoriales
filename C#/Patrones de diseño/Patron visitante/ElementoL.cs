using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_visitante
{
    class ElementoL: Elemento
    {
        public ElementoL(Elemento hijo, Elemento siguiente)
        {
            this.hijo = hijo;
            this.siguiente = siguiente;
        }
        public override void Aceptar(IVisitante visitante)
        {
            visitante.Visitar(this);
        }
    }
}
