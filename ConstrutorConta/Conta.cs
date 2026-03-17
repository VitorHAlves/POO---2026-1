using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        private int numero;
        private string? titular;
        private double saldo;
        private static int contador;//toda variávle statica sai da instância
        public static int Contador// se a variável é estatica, o get set dele tb tem que ser
        {
            get
            {
                return contador;//n tem diz pq ele so pode ser para variável que nao é estatica
            }// sem set pq só quero q ele seja alterado aq dentro
        }

        public Conta()// esse é o construtor padrão (ctor+tab)
        {       //não tem parametro e é concedido
            //de forma automatica a voce
            contador++;
        }
        public Conta(int numero)
        {// atributo = parâmetro
            this.numero = numero;
            contador++;   
        }
        public Conta(string? titular, double saldo)
        {
            this.titular = titular;   
            this.saldo = saldo;
            contador++;
        }
        public void MostrarAtributos()
        {
         Console.WriteLine($"Numero: {numero} \tTitular: {titular} \tSaldo: {saldo}");   
        }
    }
}