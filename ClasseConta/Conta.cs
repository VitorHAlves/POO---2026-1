using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseConta
{
    public class Conta
    {
        //declaração de atributos
        public int numero;
        public string titular;
        public double saldo;

        //declaração de funções/métodos
        public void Sacar(double valor)
        {
            saldo -= valor;
        }
        public void Depositar(double valorDeposito)
        {
            saldo += valorDeposito;
        }
        public void MostrarAtributos()
        {
         Console.WriteLine($"Numero: {numero} \tTitular: {titular} \tSaldo: {saldo}");   
        }
    }
}