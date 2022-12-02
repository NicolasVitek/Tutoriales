using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_interprete
{
    class ExpresionCientos:Expresion
    {
        public override string Unidad()
        {
            //REGRESAMOS EL CARACTER PARA QUE SEA USADO POR EL INTERPRETE
            //PARA RECONOCER Y EVALUAR EL VALOR
            return "C";
        }
        public override string Cuatro()
        {
            return "CD";
        }
        public override string Cinco()
        {
            return "D";
        }
        public override string Nueve()
        {
            return "CM";
        }
        public override int Factor()
        {
            //EL VALOR ENCONTRADO SERA MULTIPLICADO POR 100 EN EL INTERPRETE
            return 100;
        }
    }
}
