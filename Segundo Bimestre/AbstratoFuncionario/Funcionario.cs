using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        protected int codigo;
        protected string? nome;
        protected double salario;
        public Funcionario(int codigo, string? nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }
        public virtual void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tSalário: {Salario:c}");
        }
        public abstract double CalcularSalario(int diasUteis);
        
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
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        
        
    }
}