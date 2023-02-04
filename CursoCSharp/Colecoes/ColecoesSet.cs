using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new HashSet<Produto>(); // não é uma estrutura indexada
            carrinho.Add(livro);

            var combo = new HashSet<Produto>// Set não aceita repeticao
            {
                new Produto("Camisa", 29.9),
                new Produto("8ª temporada Game of Thrones", 99.9),
                new Produto("Poster", 10)
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                //Console.WriteLine(carrinho.IndexOf(item)); não é indexada
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
        }
    }     
}