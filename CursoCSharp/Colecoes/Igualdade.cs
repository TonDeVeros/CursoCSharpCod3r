using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Livro", 11.90);
            var p2 = new Produto("Livro", 11.90);
            var p3 = p2;

            //dará false porque as duas variaveis ocupam espaços de memoria diferentes
            Console.WriteLine(p1 == p2);

            //dará true pois apontam para o mesmo espaço de memória
            Console.WriteLine(p2 == p3);

            //Equals() também compara endereco de memória
            Console.WriteLine(p1.Equals(p2));


        }
    }
}
