using System;
using System.IO; //tudo que tiver geracao de arquivo necessita dessa dependencia


namespace CursoCSharp.Api
{
    internal class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~/lendo_arquivo.txt".ParseHome();

            if(!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                //só podemos usar o bloco "using" se for implementado a IDisposable
                {
                    sw.WriteLine("Produto;Preço;Qtde");
                    sw.WriteLine("Caneta Bic Preta;3.59;89");
                    sw.WriteLine("Borracha branca; 2.89;27");
                }
            }

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
