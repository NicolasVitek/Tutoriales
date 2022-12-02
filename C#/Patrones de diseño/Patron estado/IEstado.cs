using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_estado
{
    interface IEstado
    {
        void Trabajar();
        void CortarFuego();
        void PonerCombustible();
        void ForzarFuego();
    }
}
