using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_puente
{
    class Program
    {
        //DESACOPLA LA IMPLEMENTACION DE LA ABSTRACCION. SE USA CUANDO SURGE UNA
        //NUEVA VERSION DEL SOFTWARE PERO LA ANTEIOR UN SE VA A SEGUIR USANDO CON
        //EL CLIENTE. EL CODIGO NO CAMBIA. SUS PARTES SON:
        //-ABSTRACCION-->LA PARTE QUE EL CLIENTE YA CONOCE
        //-OPERACION-->EL METODO QUE INVOCA EL CLIENTE
        //-IBRIDGE-->LA INTERFAZ QUE MUESTRA LOS COMPORTAMIENTOS QUE PUEDEN VARIAR
        //EN LA ABSTRACCION
        //-IMPLEMENTACION n-->LAS DIFERENTES IMPLEMENTACIONES DE LA ABSTRACCION
        //-OPERACIONIMP-->EL METODO QUE IMPLEMENTA LA OPERACION

        static void Main(string[] args)
        {
            Dictionary<string, double> productos = new Dictionary<string, double>();
            productos.Add("M101", 56.32);
            productos.Add("M234", 23.88);
            productos.Add("C654", 978.33);
            productos.Add("M401", 43.28);
            productos.Add("C345", 785.23);
            productos.Add("D567", 432.20);
            productos.Add("M103", 874.54);
            productos.Add("D901", 23.18);
            productos.Add("C732", 43.12);
            productos.Add("M056", 21.42);

            Abstraccion bridge = new Abstraccion(new Implementacion3(), productos);
            bridge.mostrarTotales();
            bridge.listarProductos();
        }
    }
}
