using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{

    public class CarroOpcional
    {
        double desconto = 0.1;

        string nome;
        public string Nome
        {
            get
            {
                return "Opcional:" + nome;
            }
            set
            {
                nome = value;
            }
        }
        //Propriedade autoimplementada
        public double Preço { get; set; }   
        // Somente leitura
        public double PreçoComDesconto
        {
            get => Preço - (desconto * Preço);
        }
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere adicionar o modificador "obrigatório" ou declarar como anulável.
        public CarroOpcional()
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere adicionar o modificador "obrigatório" ou declarar como anulável.
        {

        }
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere adicionar o modificador "obrigatório" ou declarar como anulável.
        public CarroOpcional(string nome, double preço)
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere adicionar o modificador "obrigatório" ou declarar como anulável.
        {
            Nome = nome;
            Preço = preço;
           
        }

    }
    internal class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(op1.PreçoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preço = 2349.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preço);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preço);
            Console.WriteLine(op2.PreçoComDesconto);
        }
    }
}
