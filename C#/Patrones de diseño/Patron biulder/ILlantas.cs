using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_biulder
{
    interface ILlantas
    {
        string Informacion();
    }
    class LLantas12: ILlantas
    {
        public string Informacion()
        {
            return "LLantas de 12 pulgadas";
        }
    }
    class LLantasSuper : ILlantas
    {
        public string Informacion()
        {
            return "LLantas de 18 pulgadas, rines de aluminio";
        }
    }
}
