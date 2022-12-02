using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_interprete
{
    class ExpresionUnidad:Expresion
    {
        public override string Unidad()
        {
            //REGRESAMOS EL CARACTER PARA QUE SEA USADO POR EL INTERPRETE
            //PARA RECONOCER Y EVALUAR EL VALOR
            return "I";
        }
        public override string Cuatro()
        {
            return "IV";
        }
        public override string Cinco()
        {
            return "V";
        }
        public override string Nueve()
        {
            return "X";
        }
        public override int Factor()
        {
            //EL VALOR ENCONTRADO SERA MULTIPLICADO POR 1 EN EL INTERPRETE
            return 1;
        }
    }
} 
