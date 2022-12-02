using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_memento
{
    [Serializable]
    class Originador
    {
        public string Nombre;
        public int Modelo;
        public double Costo;

        public Originador(string nombre, int modelo, double costo)
        {
            this.Nombre = nombre;
            this.Modelo = modelo;
            this.Costo = costo;
        }
        public void Mostrar()
        {
            Console.WriteLine("{0} {1}, con costo de ${2}", Nombre, Modelo, Costo);
        }
        public Memento CrearMemento()
        {
            Memento memento = new Memento();
            memento.Salvar(this);
            return memento;
        }
        public void Restaura(Memento memento)
        {
            Originador temp = memento.Restaurar();
            Nombre = temp.Nombre;
            Modelo = temp.Modelo;
            Costo = temp.Costo;
        }
    }
}
