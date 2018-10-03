using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Matriz
{
    class Produto
    {
        /* Declarar Variaveis */
        public string nome { get; private set; }
        public double preco;
        public int quantidadeEmEstoque;

        /* Construtor */
        public Produto(string nome, double preco, int quantidadeEmEstoque)
        {
            /* This é uma referencia ao próprio objeto */
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
        }

        /* SobreCarga aonde inicializo a quantidade com valor 0*/
        public Produto(string nome, double preco)
        {
            /* This é uma referencia ao próprio objeto */
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = 0;
        }

        /* Emplementação dos Metodos */
        public double valorTotalEmEstoque()
        {
            return preco * quantidadeEmEstoque;
        }


        public void realizarEntrada(int quantidade)
        {
            quantidadeEmEstoque = quantidadeEmEstoque + quantidade;
        }

        public void realizarSaida(int quantidade)
        {
            quantidadeEmEstoque = quantidadeEmEstoque - quantidade;
        }
        public override string ToString()
        {
            return nome
                + " , R$ "
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + quantidadeEmEstoque
                + " unidades, Total: R$: "
                + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
