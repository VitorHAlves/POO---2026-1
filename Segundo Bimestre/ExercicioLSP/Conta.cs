using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioLSP
{
    public class Conta
    {
        public string Titular { get; set; }
        public decimal Saldo { get; set; }
        public Conta(decimal SaldoIn, string nome)
        {
            Titular = nome;
            Saldo = SaldoIn;
        }
        public virtual void Depositar(decimal valor)
        {
            if (valor > 0) Saldo += valor;
        }
        public virtual void Sacar(decimal valor)
        {
            if (valor <= Saldo)
                Saldo -= valor;
        }
    }
}