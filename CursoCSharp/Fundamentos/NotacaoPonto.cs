using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {   
            // ToUpper() é um método
            var saudacao = "olá".ToUpper().Insert(3, " World!")
                .Replace("World", "Mundo");

            Console.WriteLine(saudacao);
            // Length é um valor
            Console.WriteLine("Teste".Length);

            //não é possível usar notação ponto em um objeto não instanciado(vazio)
            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
            // o ponto ? ignora o objeto caso ele seja vazio

        }
    }
}
