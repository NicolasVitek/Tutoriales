using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_biulder
{
    interface ICarroceria
    {
        string Caracteristicas();
    }
    class CarroceriaBasica : ICarroceria
    {
        public string Caracteristicas()
        {
            return "Carroceria de metal";
        }
    }
    class CarroceriaEspecial : ICarroceria
    {
        public string Caracteristicas()
        {
            return "Carroceria de fibra de carbono";
        }
    }
}
