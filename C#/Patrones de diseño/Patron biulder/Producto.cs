using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_biulder
{
    class Producto
    {
        private IMotor motor;
        private ICarroceria carroceria;
        private ILlantas llantas;

        public void colocarMotor(IMotor motor)
        {
            this.motor = motor;
            Console.WriteLine("Se ha colocado el motor " + motor.Especificaciones());
        }
        public void colocarLLantas(ILlantas motor)
        {
            this.llantas = motor;
            Console.WriteLine("Se ha colocado unas llantas " + motor.Informacion());
        }
        public void colocarCarroceria(ICarroceria motor)
        {
            this.carroceria = motor;
            Console.WriteLine("Se ha colocado una carroceria " + motor.Caracteristicas());
        }
        public void mostrarAuto()
        {
            Console.WriteLine("El auto tiene {0}, {1}, {2}", motor.Especificaciones(), llantas.Informacion(), carroceria.Caracteristicas());
        }
    }
}
