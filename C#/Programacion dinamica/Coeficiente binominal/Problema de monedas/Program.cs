using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Problema_de_monedas
{
    class Program
    {
        //COMBINACION DE DISTINTAS MONEDAS DE DISTINTAS DENOMINACIONES PARA UNA CANTIDAD N
        static void Main(string[] args)
        {
            int[] monedas = { 1, 2, 5 };
            int m = monedas.Length;
            int n = 130;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(cambio(monedas, m, n));
            sw.Stop();
            Console.WriteLine("Para recursivo, {0:N0} ticks", sw.ElapsedTicks);
            sw.Reset();
            //PROGRAMACION DINAMICA
            sw.Start();
            Console.WriteLine(cambioDP(monedas, m, n));
            sw.Stop();
            Console.WriteLine("Para recursivo, {0:N0} ticks", sw.ElapsedTicks);
            sw.Reset();
        }
        static int cambio(int[] s, int m, int n)
        {
            //M ES LA CANTIDAD DE DENOMINACIONES
            //SI N=0 NO HAY MONEDAS
            if (n==0)
            {
                return 1;
            }
            //SI NO HAY MONEDAS Y N NO ES CERO O SI ES NEGATIVO NO TIENE SOLUCION
            if ((m<=0 &&n!=0)||(n<0))
            {
                return 0;
            }
            //LA CANTIDAD CON MENOS MONEDAS+MISMAS MONEDAS CON LA CANTIDAD - LA MONEDA
            //QUE YA PROBAMOS
            return cambio(s, m - 1, n) + cambio(s, m, n - s[m - 1]);
        }
        static int cambioDP(int[] s, int m, int n)
        {
            int[] tabla = new int[n + 1];
            for (int i = 0; i < tabla.Length; i++)
            {
                tabla[i] = 0;
            }
            //CUANDO EL VALOR ES 0, LAS COMBINACIONES SON 1, SE COLOCAN DIRECTAMENTE
            tabla[0] = 1;
            //TOMAMOS LAS MONEDAS UNA POR UNA Y VAMOS ACTUALIZANDO LA TABLA
            for (int i = 0; i < m; i++)
            {
                for (int j = s[i]; j <= n; j++)
                {
                    tabla[j] += tabla[j - s[i]];
                }
            }
            return tabla[n];

        }
    }
}
