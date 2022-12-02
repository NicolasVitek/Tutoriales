using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_interprete
{
    abstract class Expresion
    {
        public void Interpretar(Contexto contexto)
        {
            //SI NO HAY ELEMENTOS QUE INTERPRETAR SALIMOS
            if (contexto.Expresion.Length==0)
            {
                return;
            }
            //VERIFICAMOS SI EMPIEZA CON NUEVE
            if (contexto.Expresion.StartsWith(Nueve()))
            {
                //AGREGAMOS EL NUEVO VALOR POR LA POSICION DONDE ESTE
                contexto.Valor += (9 * Factor());
                //ELIMINAMOS DOS CARACTERES IX, XC, CM
                contexto.Expresion = contexto.Expresion.Substring(2);
            }
            //VERFICCAMOS SI EMPIEZA CON 4
            else if (contexto.Expresion.StartsWith(Cuatro()))
            {
                contexto.Valor += (4 * Factor());
                contexto.Expresion = contexto.Expresion.Substring(2);
            }
            //VERIFICAMOS SI EMPIEZA CON 5
            else if (contexto.Expresion.StartsWith(Cinco()))
            {
                contexto.Valor +=( 5 * Factor());
                contexto.Expresion = contexto.Expresion.Substring(1);
            }
            //RECORREMOS LAS UNIDADES ENCONTRADAS
            while (contexto.Expresion.StartsWith(Unidad()))
            {
                contexto.Valor += (1 * Factor());
                contexto.Expresion = contexto.Expresion.Substring(1);
            }
        }
        //METODOS ABSTRACTOS PARA ENCONTRAR EL CARACTER Y FACTOR SEGUN
        //LA EXPRESION
        public abstract string Unidad();
        public abstract string Cuatro();
        public abstract string Cinco();
        public abstract string Nueve();
        public abstract int Factor();

    }
}
