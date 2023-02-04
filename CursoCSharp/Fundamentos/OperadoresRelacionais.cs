using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresRelacionais
    { // Todo o resultado de um operador relacional
      // é um boolean
        public static void Executar()
        {
            Console.WriteLine("Digite a nota:");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaCorte = 7.0;

            Console.WriteLine("Nota inválida? {0}", nota > 10);
            Console.WriteLine("Nota inválida? {0}", nota < 0);
            Console.WriteLine("Perfeito? {0}", nota == 10);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10);
            Console.WriteLine("Passou por média? {0}", nota >= notaCorte);
            Console.WriteLine("Recuperação? {0}", nota < notaCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3);



        }
    }
}
