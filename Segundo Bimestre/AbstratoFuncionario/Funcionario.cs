using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        //declaração dos atributos
        protected int codigo;
        protected string? nome;
        protected double salario;

        public List<Dependente> Dependentes { get; set;}
        //declaração dos métodos
        public Funcionario(int codigo, string? nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            Dependentes = new List<Dependente>();
        }
        public virtual void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo} Nome: {Nome} Salário {Salario:c}");
        }

        public void AdicionarDependente(Dependente dep)
        {
            Dependentes.Add(dep);
        }

        public void RemoverDependente(int codigo)
        {
            for (int i = 0; i < Dependentes.Count; i++)
            {
                Dependente d = Dependentes.ElementAt(i);
                if (d.Codigo == codigo)
                {
                    Dependentes.Remove(d);
                    break;
                }
            }
        }
        public int CalcularTotalDependentes()
        {
            return Dependentes.Count;
        }
        public void ListarDependentes()
        {
            foreach (var d in Dependentes)
                d.Mostrar();
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