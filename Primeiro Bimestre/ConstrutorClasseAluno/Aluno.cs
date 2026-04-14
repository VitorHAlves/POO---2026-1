using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorClasseAluno
{
    public class Aluno
    {
        private long ra;
        private string? nome;
        private static int contador;
        public static int Contador//contador estatico
        {
            get
            {
                return contador;
            }
        }
        public Aluno()//ctor padrão
        {
            contador++;
            this.nome = "Sem nome";
            this.ra = 1570482421000 + contador;
        }
        public Aluno(string? nome)//ctor
        {
            this.nome = nome;
            contador++;
            this.ra = 1570482421000 + contador;
        }
        public long Ra//Ra encapsulado
        {
            get
            {
                return ra;
            }
        }
        public string? Nome//Nome encapsulado
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
        public void MostrarAtributos()
        {
         Console.WriteLine($"Nome: {this.Nome} \tRA: {this.Ra}");   
        }    
    }
}