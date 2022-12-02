using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//BIBLIOTECAS AGREGADAS
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Patron_memento
{
    class Memento
    {
        internal void Salvar(Originador objeto)
        {
            BinaryFormatter formateador = new BinaryFormatter();
            Stream stream = new FileStream("Autos.aut", FileMode.Create, FileAccess.Write, FileShare.None);
            formateador.Serialize(stream, objeto);
            stream.Close();
            Console.WriteLine("Se ha guardado");
        }
        internal Originador Restaurar()
        {
            BinaryFormatter formateador = new BinaryFormatter();
            Stream stream = new FileStream("Autos.aut", FileMode.Open, FileAccess.Read, FileShare.None);
            Originador temp = (Originador)formateador.Deserialize(stream);
            stream.Close();
            Console.WriteLine("Se ha restaurado");
            return temp;
        }
    }
}
