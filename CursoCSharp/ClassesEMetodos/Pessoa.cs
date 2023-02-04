using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Pessoa
    {
        public string Nome;
        public int Idade;
        public double Salario;

        public string Apresentar()
        {
            return string.Format($"Olá! me chamo {Nome} e tenho {Idade}");
        }

        public void ApresentarNoConsole()
        {   //chamando direto o resultado do método será passado para o CW.
            Console.WriteLine(Apresentar());
        }
    }
}
