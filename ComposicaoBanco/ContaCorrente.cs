using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class ContaCorrente
    {
        private double saldo;
        public double Saldo
        {
            get
            {
                return this.saldo;
            }
        }
        private double chequeEspecial;
        public double ChequeEspecial
        {
            get
            {
                return this.chequeEspecial;
            }
            set
            {
                this.chequeEspecial = value;
            }
        }
        public ContaCorrente(double chequeEspecial)
        {   
            this.saldo = 0;
            this.chequeEspecial = chequeEspecial;
        }
        public void Sacar(double valor)
        {
            if (saldo - valor >= -chequeEspecial)
                saldo -= valor;
            else
                Console.WriteLine("Limite do cheque especial atingido!");
        }
        public void Depositar(double valorDeposito)
        {
            saldo += valorDeposito;
        }
        public void GerarExtrato()
        {
            Console.WriteLine($"Saldo Atual: R${Saldo}\t Cheque Especial: R${ChequeEspecial}");
        }
    }
}