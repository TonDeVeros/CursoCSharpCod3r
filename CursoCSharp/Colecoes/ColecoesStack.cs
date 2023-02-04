using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class ColecoesStack
    {
        public static void Executar()
        {
            //nova instancia de pilha
            var pilha = new Stack();

            //adcionar valor a pilha
            pilha.Push(3);
            pilha.Push("A");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha)
            {
                Console.WriteLine(item); 
            }

            //Pop pega o valor no topo da pilha e o retira
            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach (var item in pilha)
            {
                Console.WriteLine(item);
            }

            //Peek pega o valor no topo da pilha mas não o retira.
            Console.WriteLine($"\nPeek: {pilha.Peek()}");
            Console.WriteLine(pilha.Count);
        }
    }
}
