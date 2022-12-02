using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_estado
{
    class Caldera
    {
        //VARIABLES DE REFERENCIA DE ESTADOS
        private IEstado calentando;
        private IEstado espera;
        private IEstado alarma;

        //VARIABLE QUE REPRESENTA EL ESTADO ACTUAL
        private IEstado estado;

        public int Temperatura;
        public int Combustible;

        internal IEstado Calentando { set { calentando = value; } get { return calentando; } }
        internal IEstado Espera { set { espera = value; } get { return espera; } }
        internal IEstado Alarma { set { alarma = value; } get { return alarma; } }

        public Caldera()
        {
            Temperatura = 20;
            Combustible = 50;
            //INSTANCIAMOS LOS ESTADOS
            calentando = new EstadoCalentando(this);
            espera = new EstadoEspera(this);
            alarma = new EstadoAlarma(this);

            estado = calentando;
        }
        public void ColocarEstado(IEstado estado)
        {
            Console.WriteLine("---Cambio de estado---");
            this.estado = estado;
        }
        public void Trabajar()
        {
            estado.Trabajar();
        }
        public void CortarFuego()
        {
            estado.CortarFuego();
        }
        public void PonerCombustible()
        {
            estado.PonerCombustible();
        }
        public void ForzarFuego()
        {
            estado.ForzarFuego();
        }
        public override string ToString()
        {
            return estado.ToString();
        }
    }
}
