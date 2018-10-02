﻿using System;
using System.Globalization;


namespace Projeto_Conta_Bancaria
{
    class Conta
    {
        public int numero { get; private set; }
        public string titular { get; set; }
        public double saldo { get; private set; }

        public Conta(int numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }

        public void depositar(double quantia)
        {
            saldo += quantia;
        }

        public void sacar(double quantia)
        {
            saldo = saldo - quantia - 5.0;

        }

        public Conta(int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
            saldo = 0.0;
        }

        public override string ToString()
        {
            return "Conta " +
            numero
            + ", Titular: "
            + titular
            + ", Saldo: $ "
            + saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
