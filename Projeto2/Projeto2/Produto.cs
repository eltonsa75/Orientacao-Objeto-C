﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Projeto2
{
    class Produto
    {
        /* Declarar Variaveis */
        public string nome;
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
