using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_MVC
{
    class Program
    {
        //-MODELO-->DESCRIBE LA LOGICA DE NEGOCIOS QUE DESCRIBEN COMO SE USAN LOS DATOS
        //-VIEW-->INTERFAZ DE USUARIO. DESPLIEGA EL MODELO.
        //-CONTROLLER-->SE ENCARGA DE LA ENTRADA DEL USUARIO. ACTUA SOBRE EL MODELO PARA
        //GENERAR LA VISTA.
        static void Main(string[] args)
        {
            Auto auto = new Auto("March", 2019, 250000);
            IVistaAuto vista = new  VistaAuto();
            ControladorAuto controlador = new ControladorAuto(auto, vista);

            while (controlador.Opcion!=3)
            {
                controlador.DesplegarVista();
                controlador.Solicita();
            }
        }
    }
}
