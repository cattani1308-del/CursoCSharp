using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;

namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public string GetInfoPublica()
        {
            return InfoPublica;
        }

        public string GetCorDoOlho()
        {
            return CorDoOlho;
        }

        public string GetJeitoDeFalar()
        {
            return JeitoDeFalar;
        }

        public string GetJeitoDeFalar(string jeitoDeFalar) => jeitoDeFalar;
        public void MeusAcessos(string infoPublica, string corDoOlho, string jeitoDeFalar)
        {
            Console.WriteLine("FilhoNaoReconhecido...");

            Console.WriteLine(infoPublica);
            Console.WriteLine(corDoOlho);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(jeitoDeFalar);
            //Console.WriteLine(SegredoFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop);
        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("AmigoDistante...");

            Console.WriteLine(amiga.InfoPublica);
        //    Console.WriteLine(amiga.CorDoOLho);
        //    Console.WriteLine(amiga.NumeroCelular);
        //    Console.WriteLine(amiga.JeitoDeFalar);
        //    Console.WriteLine(amiga.SegredoFamilia);
        //    Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }
    }
    internal class Encapsulamento
    {
        public static void Executar()
        {
          SubCelebridade sub = new SubCelebridade();
          sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
