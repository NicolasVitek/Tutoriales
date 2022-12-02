using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_memento
{
    class Program
    {
        //SE USA PARA CAPTURAR EL ESTADO INTERNO DE UN OBJETO Y GUARDARLO DE FORMA
        //EXTERNA PARA RESTAURARLO DESPUES. SE USAN EN AUTOSAVE SUS PARTES SON:
        //-ORIGINADOR-->PROVEE SOPORTE A LOS OBJETOS QUE SERAN GUARDADOS Y DECIDE QUE
        //TANTO DEL ESTADO SE DEBE GUARDAR.
        //-MEMENTO-->SE ENCARGA DE HACER EL GUARDADO
        //-CARETAKER-->REGISTRA LOS DIFERENTES ESTADOS GUARDADOS. GUARDA LOS MEMENTO.
        static void Main(string[] args)
        {
            Originador auto = new Originador("March", 2019, 250000);
            auto.Mostrar();

            Caretaker ct = new Caretaker();
            ct.Memento = auto.CrearMemento();

            auto.Nombre = "Vocho";
            auto.Modelo = 1970;
            auto.Costo = 35000;
            auto.Mostrar();
            //RESTAURAMOS EL ESTADO ANTERIOR
            auto.Restaura(ct.Memento);
            auto.Mostrar();
        }
    }
}
