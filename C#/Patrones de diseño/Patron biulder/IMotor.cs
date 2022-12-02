using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_biulder
{
    interface IMotor
    {
        string Especificaciones();
    }
    class MotorBasico: IMotor
    {
        public string Especificaciones()
        {
            return "Motor de 4 cilindros";
        }
    }
    class MotorGrande : IMotor
    {
        public string Especificaciones()
        {
            return "Motor de 8 cilindros";
        }
    }
}
