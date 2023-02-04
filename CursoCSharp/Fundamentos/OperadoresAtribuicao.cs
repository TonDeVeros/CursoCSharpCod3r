using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAtribuicao
    {
        public static void Executar()
        {
            int num = 3;
            num = 7; // o número 7 fica no lugar do 3
            num += 10; //num = num + 10
            num -= 3; // num = num - 3;
            num *= 5; // num = num * 5;
            num /= 2; // num = num / 5;

            Console.WriteLine(num);

            int a = 1;
            int b = a;// valor de b tem o valor a copiado

            a++; // a = a + 1;
            b--; // b = b - 1;

            Console.WriteLine($"{a} {b}");

            //Não se preocupe com o código
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;   // nesse caso as duas variáveis 
            d.nome = "Maria";// compartilham o mesmo espaço de memória;

            Console.WriteLine(c.nome);


        }
    }
}
