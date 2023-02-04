using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            // Pode-se colocar números inteiros dentro de variáveis do tipo double pois
            // o tipo double conté mais informãções que o tipo int.
            // O nome disso é conversão implícita.
            int    inteiro  = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            // casting -> converter um tipo em outro.
            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            // Para passar  string para int utilizamos o método Parse().
            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Sua idade é: {0}", idadeInteiro);

            //Também pode-se converter a partir do método Convert
            idadeInteiro = Convert.ToInt32(idadeString);


            // Pode-se evitar o erro de entrada de dados errados com o método TryParse.
            Console.WriteLine("Digite um número");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero); 
            Console.WriteLine("Resultado: {0}", numero);



            Console.WriteLine("Digite um segundo número");
            string palavra2 = Console.ReadLine();
            int.TryParse(palavra, out int numero2); //é possível declarar a variável no próprio TryParse.
            Console.WriteLine("Resultado 2: {0}", numero2);
           
        }
    }
}
