using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//SE USA PARA MEDIR EL TIEMPO
using System.Diagnostics;
namespace Introduccion
{
    class Program
    {
        //ES UN PARADIGMA QUE NOS PERMITE RESOLVER PROBLEMAS AL DIVIDIRLOS EN PROBLEMAS
        //MAS PEQUEÑOS Y GUARDANDO LOS RESULTADOS DE LOS SUBPROBLEMAS PARA USARLOS MAS
        //ADELANTE. SOLO SIRVE PARA ALGUNOS PROBLEMAS.

        //SE GUARDAN LOS VALORES CALCULADOS PARA NO SER CALCULADOS NUEVAMENTE
        static int[] valores = new int[40];
        //ESTO SE HACE DE DOS FORMAS: MEMOIZACION Y TABULACION.
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int numero = fib(39);
            sw.Stop();
            Console.WriteLine("Para recursivo {0}, {1:N0} ticks", numero, sw.ElapsedTicks);
            sw.Reset();
            //MEMOIZACION
            //-1 INDICA QUE NO HA SIDO PROCESADO
            for (int i = 0; i < 40; i++)
            {
                valores[i] = -1;
            }
            sw.Start();
            numero = fibM(39);
            sw.Stop();
            Console.WriteLine("Para memoizacion {0}, {1:N0} ticks", numero, sw.ElapsedTicks);
            sw.Reset();
            //TABULACION
            sw.Start();
            numero = fibT(39);
            sw.Stop();
            Console.WriteLine("Para tabulacion {0}, {1:N0} ticks", numero, sw.ElapsedTicks);
            sw.Reset();
        }
        public static int fib(int n)
        {
            if (n==0 || n==1)
            {
                return n;
            }
            return fib(n - 1) + fib(n - 2);
        }
        //MEMOIZACION-->PRIMERO SE BUSCA EN LA COLECCION EL VALOR PARA VER SI YA SE CALCULO
          //SI NO ESTA SE CALCULA
          //SI YA SE CALCULO, SE LO TOMA
        //LA COLECCION SE INICIALIZA CON -1 PARA INDICAR QUE EL VALOR NO HA SIDO CALCULADO 
        //PREVIAMENTE. LA COLECCION SE LLENA SEGUN SE VAYA NECESITANDO ESE VALOR
        public static int fibM(int n)
        {
            //VERIFICAMOS SI NO HA SIDO PROCESADO PARA CALCULARLO
            if (valores[n]==-1)
            {
                if (n==1)
                {
                    valores[n] = 1;
                }
                else if (n==0)
                {
                    valores[n] = 0;
                }
                else
                {
                valores[n]= fib(n - 1) + fib(n - 2);
                }
            }
            //SI YA LO TENEMOS O YA LO PROCESAMOS LO DEVOLVEMOS
            return valores[n];
        }
        //TABULACION-->SE CALCULAN LOS VALORES MAS PROFUNDOS PARA QUE PUEDAN SER USADOS
        //POR LOS VALORES MAS SUPERFICIALES. LA COLECCION SE LLENA PARA TODOS LOS VALORES
        static int fibT(int n)
        {
            int[] valores = new int[n + 1];
            //ININCIALIZAMOS LOS CASOS CONOCIDOS
            valores[0] = 0;
            valores[1] = 1;
            for (int i = 2; i <=n ; i++)
            {
                //CALCULAMOS EL VALOR, LOS ANTERIORES YA FUERON CALCULADOS
                valores[i] = valores[i - 1] + valores[i - 2];
            }
            return valores[n];
        }





    }
}
