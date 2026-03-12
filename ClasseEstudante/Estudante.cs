using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseEstudante
{
    public class Estudante
    {
        private string? nome;
        private double nota;

        public double Nota
        {
            set
            {
                if (value >= 0 && value <= 10)
                    this.nota = value;
                else
                    Console.WriteLine("Nota inválida informada.");
            }
            get
            {
                return this.nota;
            }
        }
        public string Nome
        {
            set
            {
                this.nome = value;
            }
            get
            {
                return this.nome.ToUpper();
            }
        }

        public bool notaValida()
        {
            if(nota > 0 && nota <= 10)
            {
                return true;
            }
            else
                return false;
        }
        public void MostrarAtributos()
        {
         Console.WriteLine($"Nome: {this.Nome} \tNota: {this.Nota}");   
        }
        public bool EstaAprovado()
        {
            if (nota >= 6)
            {
                return true;
            }
            else
                return false;
        }
        public void ExibirInformações()
        {
            bool situacao = EstaAprovado();
            Console.WriteLine("Status: "+ (EstaAprovado() ? "Aprovado": "Reprovado"));
        }
    }
}