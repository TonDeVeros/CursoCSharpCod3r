using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public abstract class Celular
    {
        //uma classe abstrata não pode ser instanciada
        //queremos criar para ela ser herdada por outras classes 

        //uma classe abstrata pode ou não ter métodos abstratos
        //métodos abstratos mostram que a classe ainda não está acabada, ela necessita classes que a herdam
        public abstract string Assistente();//cada celular tem sua assistente certa(siri, bixby)
        public string Tocar()
        {
            return "Trim trim trim...";
        }
    }

    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Bixby!";
        }
    }

    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Siri!";
        }
    }

    internal class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new Iphone(),
                new Samsung()
            };

            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
