using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_estado
{
    class EstadoCalentando:IEstado
    {
        Caldera caldera;

        public EstadoCalentando(Caldera caldera)
        {
            this.caldera = caldera;
        }
        public void Trabajar()
        {
            if (caldera.Combustible>0)
            {
                Console.WriteLine("Estamos calentando");
                caldera.Combustible -= 3;
                caldera.Temperatura += 10;
            }
            //VERIFICAMOS SI HAY CAMBIO DE ESTADO
            if (caldera.Temperatura>100)
            {
                caldera.ColocarEstado(caldera.Alarma);
            }
            else if (caldera.Temperatura > 80)
            {
                caldera.ColocarEstado(caldera.Espera);
            }
            if (caldera.Combustible<=0)
            {
                caldera.ColocarEstado(caldera.Espera);
            }
        }
        public void CortarFuego()
        {
            Console.WriteLine("Cortamos fuego");
            caldera.ColocarEstado(caldera.Espera);
        }
        public void PonerCombustible()
        {
            Console.WriteLine("No se puede poner combustible cuando esta prendida");
        }
        public void ForzarFuego()
        {
            Console.WriteLine("El fuego esta prendido");
        }
        public override string ToString()
        {
            return string.Format("Calentando--> temp {0}, comb {1}", caldera.Temperatura, caldera.Combustible);
        }
    }
}
