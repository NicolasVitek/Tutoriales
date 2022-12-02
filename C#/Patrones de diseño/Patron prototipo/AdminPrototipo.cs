using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_prototipo
{
    class AdminPrototipo
    {
        private Dictionary<string, IPrototipo> prototipos = new Dictionary<string, IPrototipo>();

        public AdminPrototipo()
        {
            //ADICIONAMOS LOS OBJETOS PROTOTIPOS CON LOS VALORES QUE NOS INTERESAN
            Persona persona = new Persona("Nico", 29);
            prototipos.Add("Persona", persona);
            Valores valores = new Valores(1);
            prototipos.Add("Valores", valores);
        }
        public void agregarPrototipo(string llave, IPrototipo prototipo)
        {
            prototipos.Add(llave, prototipo);
        }
        public object obtenerPrototipo(string llave)
        {
            return prototipos[llave].clonar();
        }
    }
}
