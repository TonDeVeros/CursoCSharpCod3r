using System;
using System.IO;

namespace CursoCSharp.Api
{

    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix) ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

            return path.Replace("~", home);
        }
    }
    internal class PrimeiroArquivo
    {
        public static void Executar()
        {
            //o "/t" é interpretado com TAB e o "/n" é interpretado como quebra de linha
            //var s = "\teste\nestes\a.txt";

            //caminhos devem ser escritos com o @ antes
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo");
                }
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("É possível");
                sw.WriteLine("adcionar");
                sw.WriteLine("mais texto!");
            }
        }
    }
}
