using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesDictionary
    {
        public static void Executar()
        {
            //o int é a chave e a string o valor 
            var filmes = new Dictionary<int, string>();

            // a chave não pode ser repetida entao teremos um filme por ano 
            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incriveis");
            filmes.Add(2006, "O grande Truque");

            if (filmes.ContainsKey(2004))
            {
                //é como se fosse um array 
                Console.WriteLine("2004: " + filmes[2004]);

                //outro método de pegar valor é através da função abaixo
                // desta forma se a chave não existe, não dará erro apenas mostrará uma string vazia
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));
            }

            Console.WriteLine(filmes.ContainsValue("Amnesia"));

            //a funcao abaixo faz a chave inserida ser removida e retorna true se o valor foi removido.
            Console.WriteLine($"Removeu? { filmes.Remove(2004) }");

            //usando o tryGetValue também não ocorre erro caso o valor não exista, apenas uma string vazia.
            filmes.TryGetValue(2016, out string filme2006);
            Console.WriteLine( $"Filme {filme2006}!");


            //para percorrer todas as chaves de um dictionary
            foreach (var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            foreach ( var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }

            foreach ( KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }

            foreach (var filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }
        }
    }
}
