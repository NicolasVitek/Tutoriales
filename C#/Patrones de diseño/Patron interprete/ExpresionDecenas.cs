using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_interprete
{
    class ExpresionDecenas:Expresion
    {
        public override string Unidad()
        {
            //REGRESAMOS EL CARACTER PARA QUE SEA USADO POR EL INTERPRETE
            //PARA RECONOCER Y EVALUAR EL VALOR
            return "X";
        }
        public override string Cuatro()
        {
            return "XL";
        }
        public override string Cinco()
        {
            return "L";
        }
        public override string Nueve()
        {
            return "XC";
        }
        public override int Factor()
        {
            //EL VALOR ENCONTRADO SERA MULTIPLICADO POR 10 EN EL INTERPRETE
            return 10;
        }
    }
}
