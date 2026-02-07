using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero { Acao, Aventura, Terror, Animaçao, Comedia };

    public class Filme
    {
        public required string Título;
        public Genero GenerodoFilme;
    }
    internal class ExemploEnum
    {
        public static void Executar ()
        {
            int id = (int)Genero.Animaçao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme
            {
                Título = "Sharknardo 17",
                GenerodoFilme = Genero.Comedia
            };

            Console.WriteLine("{0} é {1}!", filmeParaFamilia.Título, filmeParaFamilia.GenerodoFilme);
        }
    }
}
