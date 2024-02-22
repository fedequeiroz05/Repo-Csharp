using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandovariavelCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            idade = 10;
            Console.WriteLine("Sua idade é " + idade);

            idade = (10 + 10) - 3;
            Console.WriteLine("minha mãe tem " + idade);

            double salario;
            salario = 3200.45;

            double tamanho;
            tamanho = 3.0 / 2;
            Console.WriteLine("Meu verdadeiro tamanho é " + tamanho);

            Console.WriteLine("Eu recebo mensalmente R$" + salario);

            Console.WriteLine("Ola mundo, criando variavel projeto Csharp2");
            Console.WriteLine("Projeto 2 finalizar, pressione enter para fechar...");
            Console.WriteLine(idade);
            Console.ReadLine();

        }
    }
}
