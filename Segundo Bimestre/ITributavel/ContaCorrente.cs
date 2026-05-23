using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITributavel
{
    public class ContaCorrente : Itributavel
    {
        
        private double saldo;
        public double Saldo
        {
            get
            {
                return this.saldo;
            }
        }
        public ContaCorrente()
        {   
            this.saldo = 0;
        }
        public void Sacar(double valor)
        {
            saldo -= valor;
        }
        public void Depositar(double valorDeposito)
        {
            saldo += valorDeposito;
        }
        public void GerarExtrato()
        {
            Console.WriteLine($"Saldo Atual: R${Saldo}");
        }
        
        public double CalculaTributos()
        {
            return saldo * 0.05;
        }
    }   

}