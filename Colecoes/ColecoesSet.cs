using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesSet
    {
        public static void Executar()
        {
            var Livro = new Produto("Game of Throne", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(Livro);

            var combo = new HashSet<Produto>
            {
             new Produto("Camisa", 29.9),
             new Produto("8ª Temporada Game of Thrones", 99.9),
             new Produto("Poster", 10)
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
               // Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");

                Console.WriteLine(carrinho.Count);
                carrinho.Add(Livro);
                Console.WriteLine(carrinho.Count);
            }
        }
    }
}
