using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioLSP
{
    public class ContaCorrente : Conta ,IConta
    {
        public ContaCorrente(decimal saldoIn,string nome) : base(saldoIn,nome)
        {
            Titular = nome;
            Saldo = saldoIn;
        }
        public override void Depositar(decimal valor)
        {
            if (valor > 0)
                Saldo += valor;
            else
                Console.WriteLine("Só é possivel depositar valores positivos.");
        }
        public override void Sacar(decimal valor)
        {
            if (valor > Saldo)
                Console.WriteLine("Saldo insuficiente.");
            else
                Saldo -= valor;
        }
        
    }
}