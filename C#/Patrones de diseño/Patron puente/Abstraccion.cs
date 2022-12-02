using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_puente
{
    //ESTA CLASE CONECTA AL CLIENTE CON LA ABSTRACCION A USAR
    class Abstraccion
    {
        IBridge implementacion;
        Dictionary<string, double> productos;

        public Abstraccion(IBridge implementacion, Dictionary<string, double> productos)
        {
            this.implementacion = implementacion;
            this.productos = productos;
        }
        public Abstraccion(int tipo, Dictionary<string, double> productos)
        {
            if (tipo==1)
            {
                implementacion = new Implementacion1();
            }
            if (tipo==2)
            {
                implementacion = new Implementacion2();
            }
            if (tipo == 3)
            {
                implementacion = new Implementacion3();
            }
            this.productos = productos;
        }
        public void mostrarTotales()
        {
            implementacion.mostrarTotales(productos);
        }
        public void listarProductos()
        {
            implementacion.listarProductos(productos);
        }
    }
}
