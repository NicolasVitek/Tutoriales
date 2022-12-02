using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_modo_fabrica
{
    interface IVehiculo
    {
        void Encender();
        void Acelerar();
        void Frenar();
        void Girar();
    }
}
