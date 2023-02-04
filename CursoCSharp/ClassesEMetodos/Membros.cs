using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Membros
    {
        public static void Executar()
        {
            Pessoa estoico = new Pessoa();
            estoico.Nome = "Antonio";
            estoico.Idade = 20;

            //Console.WriteLine($"{estoico.Nome} tem {estoico.Idade} anos");

            estoico.ApresentarNoConsole();

            var linda = new Pessoa();
            linda.Nome = "Ingrid";
            linda.Idade = 29;

            // armazenando o resultado em uma variável eu tenho mais
            // liberdade com o resultado
            var apresentacaoDaLinda = linda.Apresentar();
            Console.WriteLine(apresentacaoDaLinda.Length);
            Console.WriteLine(apresentacaoDaLinda);
            
        }
    }
}
