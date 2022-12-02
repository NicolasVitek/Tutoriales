using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_de_flyweight
{
    class FlyweightFactory1
    {
        private List<IFlyweights> lista = new List<IFlyweights>();
        public int conteo = 0;

        public int agregar(string nombre)
        {
            bool existe = false;
            foreach (IFlyweights item in lista)
            {
                if (item.obtenerNombre()==nombre)
                {
                    existe = true;
                }
            }
            if (existe)
            {
                Console.WriteLine("El objeto ya existe, no se ha agregado");
                return -1;
            }
            else
            {
                Receta receta = new Receta();
                receta.colocarNombre(nombre);
                lista.Add(receta);
                conteo = lista.Count;
                return conteo - 1;
            }
        }
        public IFlyweights this[int indice]
        {
            get { return lista[indice]; }
        }
    }
}
