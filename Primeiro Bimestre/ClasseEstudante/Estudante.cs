using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseEstudante
{
    public class Estudante
    {
        private string? nome;
        private double media;

        public double Media
        {
            set
            {
                if (value >= 0 && value <= 10)
                    this.media = value;
                else
                    Console.WriteLine("Média inválida informada.");
            }
            get
            {
                return this.media;
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

        public void MostrarAtributos()
        {
         Console.WriteLine($"Nome: {this.Nome} \tMédia: {this.Media}");   
        }
        public bool EstaAprovado()
        {
            if (media >= 6)
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