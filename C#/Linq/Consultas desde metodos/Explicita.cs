using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas_desde_metodos
{
    class Explicita
    {
        private static string[] postres = { "helado", "sandia", "pastel de manzana", "ensala de frutas", "manzana de caramelo" };

        //LA CONSULTA NO PUEDE USARSE DE FORMA IMPLICITA. DEBE SER ESTATICO
        private static IEnumerable<string> encontrados = from p in postres
                                          where p.Contains("manzana")
                                          orderby p
                                          select p;
        public static IEnumerable<int> obtenerPares()
        {
            int[] numeros = { 1, 2, 4, 6, 9, 10, };
            IEnumerable<int> valores = from n in numeros
                                       where n%2==0
                                       select n;
            return valores;
        }
        public static IEnumerable<string> obtenerPostres()
        {
            return encontrados;
        }
        public static int[] obtenerImpares()
        {
            int[] numeros = { 1, 2, 4, 6, 9, 10, };
            var valores = from n in numeros
                                       where n % 2 != 0
                                       select n;
            return valores.ToArray();

        }
    }
}
