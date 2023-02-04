using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class UsandoArray
    {
        public static void Executar()
        {// é uma estrutura indexada
            string[] alunos = new string[5];//não posso colocar outro tipo. Ex: int
            alunos[0] = "Anderson";
            alunos[1] = "Bia";
            alunos[2] = "Camila";
            alunos[3] = "Daniel";
            alunos[4] = "Emanuel";

            foreach (var x in alunos)
            {
                Console.WriteLine(x);
            }

        }
    }
}
