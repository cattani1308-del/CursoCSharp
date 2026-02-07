using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaIfElseIf {
        public static void Executar() {
            Console.Write("Digite a nota do aluno ");

            string Entrada = Console.ReadLine();
            Double.TryParse(Entrada, out double nota);

            if (nota >= 9.0) {
                Console.WriteLine("Quadro de honra!");
            } else if (nota >= 7.0 && nota < 9.0) {
                Console.WriteLine("Aprovado!");
            } else if (nota >= 5.0 && nota < 7.0) {
                Console.WriteLine("Recuperação ");
            } else {
                Console.WriteLine("Te vejo na proxima...");
            }

            Console.WriteLine("Fim!!");
        }
    }
}
