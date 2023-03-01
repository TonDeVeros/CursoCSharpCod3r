using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class Nullables
    {
        static int num3;//sera inicializado como 0;
        public static void Executar()
        {
            Nullable<int> num1 = null;
            int? num2 = null;

            if (num1.HasValue)
            {
                Console.WriteLine("Valor de num:" + num1);
            }
            else
            {
                Console.WriteLine("A variavel nao possui valor");
            }

            int valor = num1 ?? 1000;//se num1 nao for nulo sera o valor, senao sera 1000;
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();

            Console.WriteLine(resultado);

            try
            {
                int x = num1.GetValueOrDefault();
                int y = num2.Value;
                Console.WriteLine(x + y);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
           

            
        }

    }
}
