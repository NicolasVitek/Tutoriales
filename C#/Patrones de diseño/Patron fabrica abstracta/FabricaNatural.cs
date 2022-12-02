using System;
using System.Collections.Generic;
using Sy|stem.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_fabrica_abstracta
{
    class FabricaNatural:IFabrica
    {
        private IProductoLeche leche;
        private IProductoSaborizante sabor;
        
        public IProductoLeche obtenerProductoLeche { get { return leche; } }
        public IProductoSaborizante obtenerSabor { get { return sabor; } }

        public void crearProducto()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string seleccion;
            Console.WriteLine("Estamos creando tu bebida");
            Console.WriteLine("1) Almendras, 2) Coco");
            seleccion = Console.ReadLine();
            if (seleccion=="1")
            {
                leche = new LecheAlmendras();
            }
            else
            {
                leche = new LecheCoco();
            }
            leche.Producir();
            Console.WriteLine("Ahora extraemos el sabor");
            sabor = new SaborVainilla();
            sabor.Obtener();
        }
    }
}
