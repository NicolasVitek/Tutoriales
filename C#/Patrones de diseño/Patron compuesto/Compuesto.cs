using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_compuesto
{
    class Compuesto<T>: IComponente<T>
    {
        List<IComponente<T>> elementos;
        public T nombre { get; set; }
        public Compuesto(T nombre)
        {
            this.nombre = nombre;
            elementos = new List<IComponente<T>>();
        }
        public void adicionar(IComponente<T> elemento)
        {
            elementos.Add(elemento);
        }
        public IComponente<T> borrar(T elemento)
        {
            IComponente<T> elem = this.buscar(elemento);
            if (elem!=null)
            {
                (this as Compuesto<T>).elementos.Remove(elem);
            }
            return this;
        }
        public IComponente<T> buscar(T elemento)
        {
            //SI SOMOS QUIEN NOS BUSCA NOS REGRESAMOS
            if (nombre.Equals(elemento))
            {
                return this;
            }
            IComponente<T> encontrado = null;
            foreach (IComponente<T> item in elementos)
            {
                encontrado = item.buscar(elemento);
                if (encontrado != null)
                {
                    break;
                }
            }
            return encontrado;
        }
        public string mostrar(int profundidad)
        {
            //CONSTRUIMOS UNA CADENA CON UNA CANTIDAD DE - IGUAL A LA PROFUNDIDAD
            StringBuilder info = new StringBuilder(new string('-', profundidad));
            //AGREGAMOS LA INFORMACION DEL COMPUESTO
            info.Append("Compuesto: " + nombre + " elementos: " + elementos.Count + "\r\n");
            //AGREGAMOS LOS ELEMENTOS
            foreach (IComponente<T> item in elementos)
            {
                info.Append(item.mostrar(profundidad + 1));
            }
            return info.ToString();
        }
    }
}
