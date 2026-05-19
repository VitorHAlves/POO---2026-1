using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioSRP
{
    public class Conta
    {
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public Conta(string titular)
        {
            Titular = titular;
            Saldo = 0;
        }
        public void Deposito(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor deve ser positivo!");
            }
            Saldo += valor;
        }
        public void Sacar (decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            Saldo -= valor;
        }
    }
}