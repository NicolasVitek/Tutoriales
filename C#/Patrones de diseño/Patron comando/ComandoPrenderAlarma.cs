using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_comando
{
    class ComandoPrenderAlarma:IComando
    {
        Automovil auto;
        public ComandoPrenderAlarma(Automovil auto)
        {
            this.auto = auto;
        }
        public void Ejecutar()
        {
            auto.colocarAlarma();
        }
    }
}
