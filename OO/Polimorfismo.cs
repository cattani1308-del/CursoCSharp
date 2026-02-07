using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{   

    public class Arroz
    {
        public double Peso;
    }

    public class Feijao
    {
        public double Peso;
    }

    public class Carne
    {
        public double Peso;
    }

    public class Pessoa
    {
        public double Peso;


        public void Comer(Arroz arroz)
        {
            Peso += arroz.Peso;
        }

        public void Comer(Feijao feijao)
        {
            Peso += feijao.Peso;
        }

        public void Comer(Carne carne)
        {
            Peso += carne.Peso;
        }
    }
     class Polimorfismo
    {
        public static void Executar()
        {
         Arroz ingrediente1 = new Arroz();
         ingrediente1.Peso = 0.25;

         Feijao ingrediente2 = new Feijao();
            ingrediente2.Peso = 0.3;

         Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.3;

         Pessoa cliente = new Pessoa();
            cliente.Peso = 80.2;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine($"Agora o peso do cliente é {cliente.Peso}Kg!");


         
        }
    }
}
