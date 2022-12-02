using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_estado
{
    class EstadoEspera:IEstado
    {
        Caldera caldera;

        public EstadoEspera(Caldera caldera)
        {
            this.caldera = caldera;
        }
        public void Trabajar()
        {
            caldera.Temperatura -= 5;
            if (caldera.Combustible > 0 && caldera.Temperatura<60)
            {
                caldera.ColocarEstado(caldera.Calentando);
            }
        }
        public void CortarFuego()
        {
            Console.WriteLine("No hay fuego prendido");
        }
        public void PonerCombustible()
        {
            Console.WriteLine("Colocando combustible");
            caldera.Combustible += 28; 
        }
        public void ForzarFuego()
        {
            if (caldera.Combustible>0)
            {
                Console.WriteLine("Se ha prendido el fuego de manera forzada");
                caldera.Combustible -= 3;
                caldera.Temperatura += 10;
                if (caldera.Temperatura>100)
                {
                    caldera.ColocarEstado(caldera.Alarma);
                }
            }
        }
        public override string ToString()
        {
            return string.Format("Espera--> temp {0}, comb {1}", caldera.Temperatura, caldera.Combustible);
        }
    }
}
