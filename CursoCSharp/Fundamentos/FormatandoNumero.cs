using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumero
    {   
        public static void Executar()
        {
            
            double valor = 15.172;
            Console.WriteLine(valor.ToString("F1")); //formatando com apenas uma casa decimal.
            Console.WriteLine(valor.ToString("C")); //formatando com Moeda(currency).
            Console.WriteLine(valor.ToString("P")); // formatando para porcentagem.
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C3", cultura)); 
            // o número ao lado do "C" representa o número de casas decimais que será impresso

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // deixa o número inteiro com 10 posições
        }
    }
}
