using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_mediador
{
    interface IColega
    {
        void Recibir(string emisor, string mensaje);
        void Enviar(string mensaje);
    }
}
