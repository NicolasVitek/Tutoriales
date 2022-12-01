using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query_progresivo
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUERY EN VARIOS PASOS PARA METER LOGICA ANTES DEL RESULTADO FINAL
            string[] postres = { "helado", "sandia", "pastel de manzana", "ensala de frutas", "manzana de caramelo" };
            bool mayusculas = false;
            IEnumerable<string> resultado;

            var manzanas = postres.Where(n => n.Contains("manzana"));
            var ordenadas = manzanas.OrderBy(n => n);//ORDEN ALFABETICO
            if (mayusculas)
            {
                resultado = ordenadas.Select(n => n.ToUpper());
            }
            else
            {
                resultado = ordenadas;
            }
            foreach (string item in resultado)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //INTO ES UNA CONTINUACION DE LA COSNSULTA: LA REINICIA PERMITIENDO OTROS WHERE, SELECT U ORDERBY
            //SOLO SE PUEDE USAR DESPUES DE SELECT O GROUP
            IEnumerable<string> encontrados = from p in postres
                                              where p.Contains("manzana")
                                              orderby p
                                              select p
                                              into pays
                                              where pays.Contains("tarta")
                                              select pays;
            foreach (string item in encontrados)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //ENVOLVER CONSULTAS CON WRAPPING
            IEnumerable<string> mipay = from p in
                                            (
                                            from p1 in postres
                                            where p1.Contains("manzana")
                                            orderby p1
                                            select p1
                                            )
                                        where p.Contains("tarta")
                                        select p;
            foreach (string item in mipay)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //LET SE USA PARA COLOCAR UNA NUEVA VARIABLE JUNTO CON LA DE RANGO
            IEnumerable<string> mipay2 = from p in postres
                                let manzanitas =(
                                from p1 in postres
                                where p1.Contains("manzana")
                                orderby p1
                                select p1
                                )
                                        where manzanitas.Contains("tarta")
                                        select p;
            foreach (string item in mipay2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

        }
    }
}
