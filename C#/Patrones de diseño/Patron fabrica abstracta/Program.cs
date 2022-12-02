using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_fabrica_abstracta
{
    class Program
    {
        //SE ENCARGA DE LA INSTANCIACION DE OJBETOS RELACIONADOS SIN EL USO DE 
        //SUBCLASES. CREA FAMILIA DE OBJETOS RELACIONADOS, OSEA QUE LOS OBJETOS
        //DEBEN DE PRODUCIRSE JUNTOS. SUS PARTES SON;
        //-IFABRICAABSTRACTA-->UNA INTERFAZ CON LAS OPERACIONES DE CREACION DE LOS
        //PRODUCTOS ABSTRACTOS.
        //-FABRICA n-->IMPLEMENTA LAS OPERACIONES DE CREACION DE LA FABRICAABSTRACTA
        //-IPRODUCTOABSTRACTO-->INTERFAZ DE TIPO DE PROUDCTO CON SUS COMPORTAMIENTOS
        //-PRODUCTO n-->CLASES QUE IMPLEMENTAN A PRODUCTOABSTRACTO

        static void Main(string[] args)
        {
            IFabrica fabrica = new FabricaQuimica();
            fabrica.crearProducto();
            IProductoLeche leche = fabrica.obtenerProductoLeche;
            IProductoSaborizante sabor = fabrica.obtenerSabor;
            leche.Producir();
            sabor.Obtener();
            Console.WriteLine("Mi malteada es de {0} y de {1}", leche.obtenerDatos(), sabor.Informacion());
            Console.WriteLine();

            fabrica = new FabricaNatural();
            fabrica.crearProducto();
            leche = fabrica.obtenerProductoLeche;
            sabor = fabrica.obtenerSabor;
            Console.WriteLine("Mi malteada es de {0} y de {1}", leche.obtenerDatos(), sabor.Informacion());
        }
    }
}
