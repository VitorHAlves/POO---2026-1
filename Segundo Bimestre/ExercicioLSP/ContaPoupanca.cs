using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioLSP
{
    public class ContaPoupanca : Conta ,IConta
    {
        public ContaPoupanca(decimal SaldoIn, string nome) : base(SaldoIn,nome)
        {
            Titular = nome;
            Saldo = SaldoIn;
        }
        public override void Depositar(decimal valor)
        {
            if (valor > 0)
                Saldo += valor;
            else
                Console.WriteLine("Só é possivel depositar valores positivos!");
        }
        public override void Sacar(decimal valor)
        {
            if (valor > Saldo)
                Console.WriteLine("Saldo Insuficiente!");
            else
                Saldo -= valor;
        }
    }
}