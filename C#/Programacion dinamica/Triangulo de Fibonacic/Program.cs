using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Triangulo_de_Fibonacic
{
    class Program
    {
        //ES UN TRIANGULO BASADO EN LOS NUMEROS DONDE CADA NUMERO ES LA SUMA
        //DE LOS DOS NUMEROS DE ARRIBA DE EL EN CUALQUIER DIAGONAL
            //     1
            //    1 1
            //   2 1 2
            //  3 2 2 3
            // 5 3 4 3 5 
            //8 5 6 6 5 8
       //FORMULA RECURSIVA -->F(n,m)=F(n-1,m)+F(n-2,m)=F(n-1,m-1)+F(n-2,m-2)

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            mostrar(5);
            sw.Stop();
            Console.WriteLine("Para recursivo, {0:N2} ticks", sw.ElapsedTicks);
            sw.Reset();

            //PROGRAMACION DINAMICA
            sw.Start();
            fibDP(5);
            sw.Stop();
            Console.WriteLine("Para DP, {0:N2} ticks", sw.ElapsedTicks);
            sw.Reset();

        }
        static int fib(int n, int m)
        {
            if ((n==0 && m==0)||(n==1 && m==0)||(n==1 & m==1)||(n==2 && m==1))
            {
                return 1;
            }
            if (n>m)
            {
                return fib(n - 1, m) + fib(n - 2, m);
            }
            else if (m==n)
            {
                return fib(n - 1, m - 1) + fib(n - 2, m - 2);
            }
            else
            {
                return 0;
            }
        }
        static void fibDP(int n)
        {
            int[,] tabla = new int[n, n];
            tabla[0, 0] = 1;
            tabla[1, 0] = 1;
            tabla[1, 1] = 1;
            tabla[2, 1] = 1;
            for (int i = 2; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i>j)
                    {
                        tabla[i, j] = tabla[i - 1, j] + tabla[i - 2, j];
                    }
                    else
                    {
                        tabla[i, j] = tabla[i - 1, j - 1] + tabla[i - 2, j - 2];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                string a = new string(' ', n - 1);
                Console.WriteLine(a);
                for (int j = 0; j <= i; j++)
                {
                    Console.WriteLine("{0} ", fib(i, j));
                }
                Console.WriteLine();
            }
        }
        static void mostrar(int p)
        {
            for (int i = 0; i < p; i++)
            {
                string a = new string(' ', p-1);
                Console.WriteLine(a);
                for (int j = 0; j <= i; j++)
                {
                    Console.WriteLine("{0} ", fib(i, j));
                }
                Console.WriteLine();
            }

        }
    }
}
