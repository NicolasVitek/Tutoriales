using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_compuesto
{
    class Componente<T>:IComponente<T>
    {
        public T nombre { get; set; }
        public Componente(T nombre)
        {
            this.nombre = nombre;
        }
        public void adicionar(IComponente<T> elemento)
        {
            Console.WriteLine("Solo se adiciona a los compuestos, no a los componentes");
        }
        public IComponente<T> borrar(T elemento)
        {
            Console.WriteLine("No se puede borrar directamente");
            return this;
        }
        public IComponente<T> buscar(T elemento)
        {
            if (elemento.Equals(nombre))
            {
                return this;
            }
            else
            {
                return null;
            }
        }
        public string mostrar(int profundidad)
        {
            return new String('-', profundidad) + nombre + "\n\r"; 
        }
    }
}
