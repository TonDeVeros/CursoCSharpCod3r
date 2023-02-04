using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;
    }
    internal class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;

            Console.WriteLine(carro1.Fabricante + carro1.Modelo + carro1.Ano);
        }
    }
}
