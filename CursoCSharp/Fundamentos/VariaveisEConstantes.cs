using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //Área da circunferência
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 33.454;
            
            double area =  PI * Math.Pow(raio, 2);
            Console.WriteLine($"A área da circunferência é de: {area}");

            //Tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo" + estaChovendo);

            byte idade = 45;

        }
    }
}
