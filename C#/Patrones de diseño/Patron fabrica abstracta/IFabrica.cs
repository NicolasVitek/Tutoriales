using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_fabrica_abstracta
{
    interface IFabrica
    {
        void crearProducto();
        IProductoLeche obtenerProductoLeche { get; }
        IProductoSaborizante obtenerSabor { get; }
    }
}
