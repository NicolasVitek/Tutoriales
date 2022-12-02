using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_MVC
{
    class ControladorAuto
    {
        //REFERENCIA A LA VISTA
        private IVistaAuto vista;
        //REFERNCIA AL MODELO
        private Auto modelo;

        public int Opcion;

        public ControladorAuto(Auto modelo, IVistaAuto vista)
        {
            this.modelo = modelo;
            this.vista = vista;
        }
        public void DesplegarVista()
        {
            vista.DespliegaAuto(modelo);
        }
        public void Solicita()
        {
            Opcion = vista.SolicitaEntrada();
            if (Opcion==1)
            {
                ActualizaCosto(modelo.Costo * 1.15);
            }
            if (Opcion==2)
            {
                ActualizaModelo();
            }
        }
        public void ActualizaCosto(double costo)
        {
            modelo.Costo = costo;
        }
        public void ActualizaModelo()
        {
            Console.WriteLine("Ingresa el modelo");
            modelo.Modelo = int.Parse(Console.ReadLine());
        }
    }
}
