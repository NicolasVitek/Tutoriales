using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_biulder
{
    class Program
    {
        //SEPARA LA ESPECIFICACION DE UN OBJETO COMPLEJO DE SU CONSTRUCCION
        //SE BASA EN DIRECTORES Y CONSTRUCTORES. ESTE ULTIMO PROVEE PARTES 
        //QUE SE ACUMULAN HASTA QUE EL DIRECTOR FINALIZA. SUS PARTES SON:
        //-ICONSTRUCTOR-->INTERFAZ QUE DEFINE QUE PUEDE CONSTRUIRSE
        //-DIRECTOR-->SECUENCA DE OPERACIONES QUE SE SIGUEN PARA CREAR UN 
        //PRODUCTO
        //-CONSTRUCTOR-->UNA CLASE QUE ES INVOCADA POR EL DIRECTOR PARA CREAR
        //LAS PARTES DEL PRODUCTO
        //-PRODUCTO-->EL OBJETO BAJO CONSTRUCCION.
        static void Main(string[] args)
        {
            Director director = new Director();
            BuilderNormal normal = new BuilderNormal();
            director.Construye(normal);
            Producto auto = normal.obtenerProducto();
            auto.mostrarAuto();
            Console.WriteLine();

            BuilderDeportivo deportivo = new BuilderDeportivo();
            director.Construye(deportivo);
            Producto auto2 = deportivo.obtenerProducto();
            auto2.mostrarAuto();
        }
    }
}
