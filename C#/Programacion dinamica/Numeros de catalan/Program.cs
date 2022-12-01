using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Numeros_de_catalan
{
    class Program
    {
        //IMPLEMENTACION DE NUMEROS DE CATALAN USANDO LA SIGUIENTE FORMA RECURSIVA
        //PARA TODO N>=0
        //C 0=1
        //C n+1= SUMATORIA DE 0 A N DE Ci * Cn-1
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("[{0},{1}]", i, catalan(i));
            }
            sw.Stop();
            Console.WriteLine("Para recursivo, {0:N0} ticks", sw.ElapsedTicks);
            sw.Reset();
            //PROGRAMACION DINAMICA
            sw.Start();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("[{0},{1}]", i, catalanDP(i));
            }
            sw.Stop();
            Console.WriteLine("Para DP, {0:N0} ticks", sw.ElapsedTicks);
            sw.Reset();

        }
        static int catalan(int indice)
        {
            if (indice<=1)
            {
                return 1;
            }
            int numero = 0;
            for (int i = 0; i < indice; i++)
            {
                numero += catalan(i) + catalan(indice - i - 1);
            }
            return numero;
        }
        static int catalanDP(int indice)
        {
            int[] tabla = new int[indice + 2];
            tabla[0] = 1;
            tabla[1] = 1;
            for (int i = 2; i <= indice; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    tabla[i] += tabla[j] *tabla[i - j - 1];
                }
            }
            int resultado = tabla[indice];
            return resultado; 
        }
    }
}
