using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_proxy
{
    //USO DE ANIDAMIENTO DENTRO DE UNA CLASE: CUALQUIER CLASE
    //COLOCADA COMO PRIVADA O ANIDADA ES CONOCIDA SOLO POR PROXY
    class Proxy
    {
        public interface ISujeto
        {
            void Peticion(int opcion);
        }
        public class ProxySencillo: ISujeto
        {
            private Cocina cocina;
            public void Peticion(int opcion)
            {
                if (cocina == null)
                {
                    Console.WriteLine("Activando el sujeto");
                    cocina = new Cocina();
                }
                if (opcion==1)
                {
                    cocina.RecetaSecreta();
                }
                if (opcion==2)
                {
                    cocina.Cocinar(5);
                }
            }
        }
        public class ProxySeguro: ISujeto
        {
            private Cocina cocina;
            public void Peticion(int opcion)
            {
                string pass;
                Console.WriteLine("Dame la contraseña: ");
                pass = Console.ReadLine();
                if (pass=="abc123")
                {
                    if (cocina==null)
                    {
                        Console.WriteLine("Activando el sujeto");
                        cocina = new Cocina();
                    }
                    if (opcion == 1)
                    {
                        cocina.RecetaSecreta();
                    }
                    if (opcion == 2)
                    {
                        cocina.Cocinar(5);
                    }
                }
                else
                {
                    Console.WriteLine("Acceso denegado");
                }
            }
        }
        //ESTA ES LA CLASE QUE ESTAMOS PROTEGIENDO CON EL PROXY
        private class Cocina
        {
            public void RecetaSecreta()
            {
                Console.WriteLine("Pan");
                Console.WriteLine("Aceita de olvida");
                Console.WriteLine("Especias");
                Console.WriteLine("Jamon");
                Console.WriteLine("Queso");
            }
            public void Cocinar(int n)
            {
                Console.WriteLine("Cocinando {0} recetas", n);
            }
        }
    }
}
