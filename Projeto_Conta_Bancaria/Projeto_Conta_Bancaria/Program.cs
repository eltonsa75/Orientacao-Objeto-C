using System;
using System.Globalization;

namespace Projeto_Conta_Bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta x;
            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da  conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)");
            char ch = char.Parse(Console.ReadLine());
            if (ch == 's')
            {
                Console.Write("Digite o valor do depósito inicial: ");
                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x = new Conta(numero, nome, valorInicial);
            }
            else
            {
                x = new Conta(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Conta Criada: ");
            Console.WriteLine(x);

            Console.WriteLine();
            Console.Write("Digite um valor para depósito: ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.depositar(dep);
            Console.WriteLine();
            Console.WriteLine("Conta Atualizada: ");
            Console.WriteLine(x);


            Console.WriteLine();
            Console.Write("Digite um valor para saque:");
            double saq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.sacar(saq);
            Console.WriteLine();
            Console.Write("Conta Atualizada: ");
            Console.WriteLine(x);





            Console.ReadLine();

        }
    }
}
