using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 7.0;
            bool bomComportamento = true;
            string resultado = nota >= 7.0 && bomComportamento //posso usar operador lógico dentro do ternário
                ? "Aprovado" : "Reprovado";// o resultado deve ser o tipo da variável
            Console.WriteLine(resultado);


        }
    }
}
