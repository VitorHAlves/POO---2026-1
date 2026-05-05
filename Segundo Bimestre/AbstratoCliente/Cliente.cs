using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public abstract class Cliente
    {// a palavra abstract faz com que a classe nunca seja instânciada.
        //declaração de atributos
        private int codigo;
        private string? nome;
        protected Endereco endereco;
        private int idade;
        //declaração de métodos
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
                
        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        
        public Endereco _Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public Cliente(int codigo, string? nome, int idade) 
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }
        public abstract void VerificaIdade();
        public virtual void Mostrar()
        {
            Console.WriteLine($"Nome: {Nome}\tIdade: {Idade}");
            _Endereco.Mostrar();
        }
    }
}