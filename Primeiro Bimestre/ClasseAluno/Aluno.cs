using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAluno
{
    public class Aluno
    {
        public int ra;
        public string nome;
        public double p2;
        public double media;
        public double p1;

        public void MostrarAtributos()
        {
            Console.WriteLine($"RA: {ra} \tNome: {nome} \tP1: {p1} \tP2: {p2} \tMédia: {media}");   
        }
        public void CalcularMedia()
        {
            media = (p1 + p2) / 2;
        }
    }

}