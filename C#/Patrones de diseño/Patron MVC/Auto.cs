using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_MVC
{
    class Auto
    {
        public string Nombre;
        public int Modelo;
        public double Costo;

        public Auto(string nombre, int modelo, double costo)
        {
            this.Nombre = nombre;
            this.Modelo = modelo;
            this.Costo = costo;
        }
    }
}
