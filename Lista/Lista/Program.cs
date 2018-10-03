using System;
/* Biblioteca para Lista */
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            /* conteito de Lita */
            List<Produto> lista = new List<Produto>();

            lista.Add(new Produto("TV", 900.00));
            lista.Add(new Produto("Aspirador", 400.00));
            lista.Add(new Produto("Geladeira", 2000.00));
           

            int pos = lista.FindIndex(x => x.preco>3000);
            Console.WriteLine("Posição encontrada  = " + pos);

            for (int i=0; i<lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.ReadLine();
        }
    }
}
