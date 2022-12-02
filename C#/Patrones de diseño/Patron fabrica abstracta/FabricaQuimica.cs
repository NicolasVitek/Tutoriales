using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_fabrica_abstracta
{
    class FabricaQuimica:IFabrica
    {
        private IProductoLeche leche;
        private IProductoSaborizante sabor;

        public IProductoLeche obtenerProductoLeche { get { return leche; } }
        public IProductoSaborizante obtenerSabor { get { return sabor; } }

        public void crearProducto()
        {
            Console.WriteLine("Estamos produnciendo tu malteada");
            leche = new LecheVaca();
            sabor = new SaborChocolate();
        }
    }
}
