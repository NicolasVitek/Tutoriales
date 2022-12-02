using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_biulder
{
    interface IBuilder
    {
        void construyeMotor();
        void construyeCarroceria();
        void construyeLLantas();
    }
}
