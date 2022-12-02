using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_modo_fabrica
{
    class Creador
    {
        public static IVehiculo metodoFabrica(int dinero)
        {
            IVehiculo temp = null;

            //SELECCIONAMOS EL TIPO DE INSTANCIA SEGUN NUESTRAS REGLAS
            if (dinero>10000000)
            {
                temp = new Avion();
            }
            else if (dinero>200000)
            {
                temp = new Auto();
            }
            else
            {
                temp = new Bicicleta();
            }
            return temp;
        }
    }
}
