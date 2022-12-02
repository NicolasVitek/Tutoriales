using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_adaptador
{
    class Adaptador: ITarget
    {
        Calculadora adaptado = new Calculadora();

        //AQUI HACEMOS LA ADAPTACION DE LA OPERACION
        public int sumar(int a, int b)
        {
            double r = 0;
            //CREAMOS EL ARRAY QUE NECESITA EL ADAPTADO Y 
            //ADAPTAMOS LOS DATOS QUE SE ENVIAR
            int [] operadores={ a,b};
            //REALIZAMOS LA OPERACION EN EL ADAPTADO
            r = adaptado.suma(operadores);
            //ADAPTAMOS EL RESUTLADO
            return (int)r;
        }
    }
}
