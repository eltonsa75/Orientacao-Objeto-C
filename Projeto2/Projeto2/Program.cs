using System;
using System.Globalization;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int qte;
            Produto P;

            Console.WriteLine("Digite os dados do Produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            P = new Produto(nome, preco, quantidade); 

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + P);


            Console.WriteLine();
            Console.Write("Digite a quatidade de produtos que entraram no estoque: ");
            qte = int.Parse(Console.ReadLine());
            P.realizarEntrada(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + P);


            Console.WriteLine();
            Console.Write("Digite a quatidade de produtos que sairam no estoque: ");
            qte = int.Parse(Console.ReadLine());
            P.realizarSaida(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + P);







            Console.ReadLine();
        }

    }
   
}
