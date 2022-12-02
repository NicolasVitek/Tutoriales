using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_comando
{
    class ComandoApagar:IComando
    {
        Automovil auto;
        public ComandoApagar(Automovil auto)
        {
            this.auto = auto;
        }
        public void Ejecutar()
        {
            auto.Apagar();
        }
    }
}
