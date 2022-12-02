using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador
{
    class Auto:IComponente
    {
        private string modelo, caracteristicas;
        private double costo;

        public Auto(string modelo, string caracteristicas, double costo)
        {
            this.modelo = modelo;
            this.caracteristicas = caracteristicas;
            this.costo = costo;
        }
        public void Puertas(bool estado)
        {
            if (estado)
            {
                Console.WriteLine("Puertas cerradas");
            }
            else
            {
                Console.WriteLine("Puertas abiertas");
            }
        }
        public override string ToString()
        {
            return string.Format("Modelo {0}, {1} \r\n", modelo, caracteristicas);
        }
        public double Costo()
        {
            return costo;
        }
        public string Funciona()
        {
            return "Encendi el moto";
        }
    }
}
