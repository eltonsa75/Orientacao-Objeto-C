using System;
using System.Globalization;

namespace Projeto3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exemplo de vetor de Produto */
            Produto[] vet;
            double soma, media;
            int N;

            N = int.Parse(Console.ReadLine());
            vet = new Produto[N];

            for (int i = 0; i < N; i++)
            {
                String nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Produto(nome, preco);
            }

            soma = 0.0;
            for (int i=0; i<N; i++)
            {
                soma = soma + vet[i].preco;
            }
            media = soma / N;

            Console.WriteLine("PREÇO MEDIA = R$ " + media.ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadLine();

        }

    }

}
