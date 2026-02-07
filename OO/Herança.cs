using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Carro(int velocidadeMaxima)
    {
        protected readonly int VelocidadeMaxima = velocidadeMaxima;
        int VelocidadeAtual;

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            } else
            {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;

        }
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
      public Uno() : base(200)
        {

        }

    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(350)
        {

        } 
        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }
        // Oculta o método da classe Pai 
        public new int Frear()
        {
            return AlterarVelocidade(-15);
        }
    }
    internal class Herança
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
#pragma warning disable IDE0090 // Usar 'new(...)'
            Uno carro1 = new Uno();
#pragma warning restore IDE0090 // Usar 'new(...)'
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1 .Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());


            Console.WriteLine("Ferrari...");
#pragma warning disable IDE0090 // Usar 'new(...)'
            Ferrari carro2 = new Ferrari();
#pragma warning restore IDE0090 // Usar 'new(...)'
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com tipo Carro...");
            Carro carro3 = new Ferrari(); //Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com tipo Carro...");
            carro3 = new Uno(); // Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

        }
    }
}
