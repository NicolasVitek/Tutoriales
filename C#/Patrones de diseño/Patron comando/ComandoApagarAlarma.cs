using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_comando
{
    class ComandoApagarAlarma:IComando
    {
        Automovil auto;
        public ComandoApagarAlarma(Automovil auto)
        {
            this.auto = auto;
        }
        public void Ejecutar()
        {
            auto.quitarAlarma();
        }
    }
}
 
