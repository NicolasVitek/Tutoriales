using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_estado
{
    class EstadoAlarma:IEstado
    {
        Caldera caldera;

        public EstadoAlarma(Caldera caldera)
        {
            this.caldera = caldera;
        }
        public void Trabajar()
        {
            Console.WriteLine("!!Alarma!! alta temperatura");
            caldera.Temperatura -= 5;
            if (caldera.Combustible <= 0 || caldera.Temperatura < 90)
            {
                caldera.ColocarEstado(caldera.Espera);
            }
        }
        public void CortarFuego()
        {
            Console.WriteLine("No esta prendida");
        }
        public void PonerCombustible()
        {
            Console.WriteLine("No se puede colocar combustible con la temperatura alta");
        }
        public void ForzarFuego()
        {
            Console.WriteLine("Aumentara la temperatura");
            caldera.Combustible -= 3;
            caldera.Temperatura += 10;
        }
        public override string ToString()
        {
            return string.Format("Alarma--> temp {0}, comb {1}", caldera.Temperatura, caldera.Combustible);
        }
    }
}
