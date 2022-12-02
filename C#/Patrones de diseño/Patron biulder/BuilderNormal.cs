using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_biulder
{
    class BuilderNormal : IBuilder
    {
        private Producto auto = new Producto();

        public void construyeCarroceria()
        {
            auto.colocarCarroceria(new CarroceriaBasica());
        }
        public void construyeMotor()
        {
            auto.colocarMotor(new MotorBasico());

        }
        public void construyeLLantas()
        {
            auto.colocarLLantas(new LLantas12());
        }
        public Producto obtenerProducto()
        {
            return auto;
        }
    }
}
