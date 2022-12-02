using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsistema
{
    class Fachada
    {
        //ESTOS SON LOS SUBSISTEMAS QUE ESTA USANDO
        private SistemaCompra compra = new SistemaCompra();
        private SubsistemaAlmacen almacen = new SubsistemaAlmacen();
        private SubsistemaEnvio envio = new SubsistemaEnvio();

        //ESTE METODO ES USADO PARA REALIZAR DE FORMA SENCILLA UNA OPERACION
        //MAS COMPLEJA QUE REQUIERE DE UNO O VARIOS SUBSISTEMAS.
        public void Compra()
        {
            if (compra.comprar())
            {
                if (almacen.sacarAlmacen())
                {
                    envio.enviarPedido();
                }
            }
        }
    }
}
