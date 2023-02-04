using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        
        //utilizamos a velocidade atual para podermos criar métodos de frear e acelerar
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }


        protected int AlterarVelocidade(int delta)
        {
            //Este método está encapsulado, melhorando a relação entre classes
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                novaVelocidade = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        //adcionando o virtual, o método pode ser sobrescrito
        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro
    {
        public Uno(): base(200)
        {

        }
    }

    public class Ferrari : Carro
    {
        public Ferrari (): base(300)
        {

        }

        //quando substituir uma funcionalidade por outra, temos que manter a compatibilidade entre os métodos
        //aquilo que foi feito na classe mais generica pode ser modificado na mais especifica.
        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }

        //aqui estamos ocultando o método frear da classe pai
        public new int Frear()
        {
            return AlterarVelocidade(-15);
        }
    }


    internal class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());


            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com tipo carro...");
            Carro carro3 = new Ferrari();
            //override pega o método da instancia(Ferrari);
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            //ocultado pega o método do tipo(Carro) 
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            
            Console.WriteLine("Uno com tipo carro...");
            carro3 = new Uno();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}
