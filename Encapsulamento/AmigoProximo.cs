using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
     public class AmigoProximo
    {
        //tem que ter uma instancia pois não recebe por herança, ou seja por composição
        public readonly SubCelebridade amiga = new SubCelebridade();


        public void MeusAcessos()
        {
            Console.WriteLine("AmigoProximo...");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho);
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoFamilia);

        }

    }
}
