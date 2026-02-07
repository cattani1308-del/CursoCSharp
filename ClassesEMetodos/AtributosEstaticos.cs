using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Produto
    {
        public string Nome;
        public double Preço;
        public double Desconto = 0.1;

        public Produto(string nome, double preço, double desconto)
        {
            Nome = nome;
            Preço = preço;
            Desconto = desconto;
        }
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere adicionar o modificador "obrigatório" ou declarar como anulável.
        public Produto() { 
        }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere adicionar o modificador "obrigatório" ou declarar como anulável.
        public double CalculadoraDesconto()
        {
            return Preço - Preço * Desconto;
        }
    }
    internal class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("caneta", 3.2, 0.1);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preço = 5.3,
                Desconto = 0.5
            };

            Console.WriteLine("Preço com desconto: {0}", produto1.CalculadoraDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalculadoraDesconto());
        }
    }
}
