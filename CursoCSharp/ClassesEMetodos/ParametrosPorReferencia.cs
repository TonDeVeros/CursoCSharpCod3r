using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;

        }

        public static void AlterarOut(out int numero, out int numero2)
        {
            // não se passa dado para um parametro do tipo out
            numero = 0;
            numero2 = 0;
            numero = numero + 15;//metodo esta devolvendo um valor que não foi inicializado
            numero2 = numero2 + 30;
        }
        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            //int b = 2;
            AlterarOut(out int b, out int c);
            Console.WriteLine($"{b} {c}");   
        }
    }
}
