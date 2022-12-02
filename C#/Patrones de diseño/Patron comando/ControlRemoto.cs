using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_comando
{
    class ControlRemoto
    {
        private IComando[] comandos = new IComando[4];
        public ControlRemoto(Automovil auto)
        {
            comandos[0] = new ComandoEncender(auto);
            comandos[1] = new ComandoApagar(auto);
            comandos[2] = new ComandoPrenderAlarma(auto);
            comandos[3] = new ComandoApagarAlarma(auto);
        }
        public void Boton(int indice)
        {
            comandos[indice].Ejecutar();
        }
    }
}
