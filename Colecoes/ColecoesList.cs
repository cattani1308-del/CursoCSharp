using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = Preco;

        }

        public override bool Equals(object obj)
        {
          Produto outroProduto = (Produto)obj;
          bool mesmoNome = Nome == outroProduto.Nome;
          bool mesmoPreco = Preco == outroProduto.Preco;
          return mesmoNome && mesmoPreco;
        }

        public override int GetHashCode()
        {
            return Nome.Length;
        }
    }
    internal class ColecoesList
    {
        public static void Executar()
        {
            var Livro = new Produto("Game of Throne", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(Livro);

            var combo = new List<Produto>
            {
             new Produto("Camisa", 29.9),
             new Produto("8ª Temporada Game of Thrones", 99.9),
             new Produto("Poster", 10)
            };

            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }
        }
    }
}
