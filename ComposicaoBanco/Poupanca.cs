using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Poupanca
    {
        private double saldo;

        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                this.saldo = value;
            }
        }
        public void Sacar(double valor)
        {
            saldo -= valor;
        }
        public void Depositar(double valorDeposito)
        {
            saldo += valorDeposito;
        }
        public void GerarRendimento()
        {
            Console.WriteLine($"Rendimento de R${saldo * 0.005} na poupança.");
            saldo += saldo * 0.005;
        }
    }
}