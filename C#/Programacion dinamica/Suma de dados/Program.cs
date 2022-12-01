using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_de_dados
{
    class Program
    {
        //TENEMOS n DADOS Y CADA UNO DE ELLOS TIENE m CARAS CON VALORES QUE VAN
        //DESDE 1 HASTA m. ENCONTRAR LA CANTIDAD POSIBLE DE SUMAS QUE NOS DAN UN
        //VALOR x(SUMA DE LAS CARAS) 
        static void Main(string[] args)
        {
            int sumas = 0;
            for (int i = 0; i <= 12; i++)
            {
                sumas = suma(2, 6, i);
                Console.WriteLine("La cantidad de sumas para " + i + " es " + sumas);
            }

        }
        static int suma(int cant, int Pcaras, int numero)
        {
            int[,] tabla = new int[cant + 1, numero + 1];
            int dado = 0;
                int valor = 0; 
                int caras = 0;
            //COLOCAMOS LOS VALORES PARA EL DADO 1. LAS FILAS SON LOS DADOS
            //LAS COLUMNAS LOS VALORES
            for (valor = 1; valor <= Pcaras && valor<=numero; valor++)
            {
                tabla[1, valor] = 1;
            }
            //RECORREMOS CADA DADO DESDE 2. PARA CADA DADO RECORREMOS CADA POSIBLE
            //VALOR. PARA CADA VALOR RECORRERMOS LAS CARAS QUE SEAN MENORES QUE ESE
            //VALOR. CALCULAMOS USANDO DATOS OBTENIDOS PREVIAMENTE
            for (dado = 2; dado <= cant; dado++)
            {
                for (valor = 1; valor <= numero; valor++)
                {
                    for (caras = 1; caras <= Pcaras && caras<valor; caras++)
                    {
                        tabla[dado, valor] += tabla[dado - 1, valor - caras];
                    }
                }
            }
            return tabla[cant, numero];

        }
    }
}
