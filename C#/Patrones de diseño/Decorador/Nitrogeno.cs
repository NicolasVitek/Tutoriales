using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    class Nitrogeno:IComponente
    {
        //VARIABLE DE REFERENCIA HACIA QUIEN DECORAMOS
        private IComponente decoramosAuto;

        public Nitrogeno(IComponente componente)
        {
            decoramosAuto = componente;
        }
        public override string ToString()
        {
            return "Sistema de nitrogeno\r\n"+ decoramosAuto.ToString(); 
        }
        public string Funciona()
        {
            return decoramosAuto.Funciona() + ", Nitrogeno listo";
        }
        public double Costo()
        {
            //COSTO DE LO QUE DECORO + COSTO COMO COMPONENTE
            return decoramosAuto.Costo() + 45000;
        }
        public void Usa()
        {
            Console.WriteLine("Nitrogeno en uso");
        }
    }
}
