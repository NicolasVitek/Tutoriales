using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_comando
{
    class ComandoEncender:IComando
    {
        Automovil auto;
        public ComandoEncender(Automovil auto)
        {
            this.auto = auto;
        }
        public void Ejecutar()
        {
            auto.Encender();
        }
    }
}
