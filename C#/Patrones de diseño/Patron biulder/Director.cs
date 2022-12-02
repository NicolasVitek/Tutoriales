using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_biulder
{
    class Director
    {
        public void Construye(IBuilder constructor)
        {
            //EL DIRECTOR INDICA LOS PASOS PARA HACER LA CONSTRUCCION
            //PERO EL CONSTRUCTOR SE ENCARGA DE CONSTRUIR SEGUN LA 
            //ESPECIFICACION

            constructor.construyeCarroceria();
            constructor.construyeMotor();
            constructor.construyeLLantas();
        }
    }
}
