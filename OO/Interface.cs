using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO

{
   interface OperacaoBinaria
    {
        int Operacao(int a, int b);
   
    }

    public class Soma : OperacaoBinaria
    {
        public int Operacao(int a,int b)
        {
            return a + b;
        }

        public object Operacao()
        {
            throw new NotImplementedException();
        }
    }

     public class Subtracao : OperacaoBinaria
    {
        public object Operacao()
        {
            throw new NotImplementedException();
        }

        public int Operaco(int a,int b)
        {
            return a - b;
        }

        int OperacaoBinaria.Operacao(int a, int b)
        {
            throw new NotImplementedException();
        }
    }

    class Multiplicacao : OperacaoBinaria
    {
        public int Operacao(int a,int b)
        {
            return a * b;
        }

        public object Operacao()
        {
            throw new NotImplementedException();
        }
    } 

    class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
        {
            new Soma(),
            new Subtracao(),
            new Multiplicacao()
        };
        public object op;

        public string ExecutarOperacoes(int a,int b)
        {
            string resultado = "";

            {
                resultado += $"Usando  {op.GetType().Name} = {op.Operacao()}\n";
            }
            return resultado;
        }

    }
    public class Interface
    { 
        public static void Executar()
        { 
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(20, 5);
            Console.WriteLine(resultado);
        
        }
    }
}
