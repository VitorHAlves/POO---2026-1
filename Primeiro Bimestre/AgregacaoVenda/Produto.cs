using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        private int codigo;
        private string nome;
        private double preco;
        private static int contador;

        public static int Contador//contador
        {
            get
            {
                return contador;
            }
        }
        public int Codigo//codigo
        {
            get
            {
                return codigo;
            }
        }
        public string Nome//nome encapsulado
        {
            set
            {
                this.nome = value;
            }
            get
            {
                return this.nome;
            }
        }
        
        public double Preco//preço encapsulado
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Valor inválido!");
                }
                else
                    this.preco = value;
            }
            get
            {
                return this.preco;
            }
        }
        public Produto(string? nome,double preco)//CTOR
        {
            contador++;
            this.nome = nome;
            this.preco = preco;
            this.codigo = 500 + contador;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {this.Codigo} \tNome: {this.nome} \tPreço: {this.preco}");   
        }   
    }
}