using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_interprete
{
    class ExpresionMiles:Expresion
    {
        public override string Unidad()
        {
            //REGRESAMOS EL CARACTER PARA QUE SEA USADO POR EL INTERPRETE
            //PARA RECONOCER Y EVALUAR EL VALOR
            return "M";
        }
        public override string Cuatro()
        {
            return " ";
        }
        public override string Cinco()
        {
            return " ";
        }
        public override string Nueve()
        {
            return " ";
        }
        public override int Factor()
        {
            //EL VALOR ENCONTRADO SERA MULTIPLICADO POR 1000 EN EL INTERPRETE
            return 1000;
        }
    }
}
