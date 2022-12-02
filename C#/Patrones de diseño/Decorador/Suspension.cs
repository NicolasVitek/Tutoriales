using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    class Suspension: IComponente
    {
        private IComponente decoramosAuto;
        public Suspension(IComponente componente)
        {
            decoramosAuto = componente;
        }
        public override string ToString()
        {
            return "Suspension de alto rendimiento\r\n" + decoramosAuto.ToString();
        }
        public string Funciona()
        {
            return decoramosAuto.Funciona() + ", Elevando suspension";
        }
        public double Costo()
        {
            //COSTO DE LO QUE DECORO + COSTO COMO COMPONENTE
            return decoramosAuto.Costo() + 63500;
        }
    }
}
