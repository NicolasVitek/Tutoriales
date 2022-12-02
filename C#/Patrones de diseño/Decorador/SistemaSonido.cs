using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    class SistemaSonido : IComponente
    {
        private IComponente decoramosAuto;
        public SistemaSonido(IComponente componente)
        {
            decoramosAuto = componente;
        }
        public override string ToString()
        {
            return "Radio 650RXZ\r\n" + decoramosAuto.ToString();
        }
        public string Funciona()
        {
            return decoramosAuto.Funciona() + ", Radio lista";
        }
        public double Costo()
        {
            //COSTO DE LO QUE DECORO + COSTO COMO COMPONENTE
            return decoramosAuto.Costo() + 4500;
        }
    }
}
