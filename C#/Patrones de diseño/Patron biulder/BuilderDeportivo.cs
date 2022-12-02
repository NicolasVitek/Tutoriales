using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_biulder
{
    class BuilderDeportivo:IBuilder
    {
        private Producto auto = new Producto();

        public void construyeCarroceria()
        {
            auto.colocarCarroceria(new CarroceriaEspecial());
        }
        public void construyeMotor()
        {
            auto.colocarMotor(new MotorGrande());

        }
        public void construyeLLantas()
        {
            auto.colocarLLantas(new LLantasSuper());
        }
        public Producto obtenerProducto()
        {
            return auto;
        }
    }
}
