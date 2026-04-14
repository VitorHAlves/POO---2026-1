using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class Cliente
    {
        //declaração dos atributos
        protected int codigo;
        public int Codigo
        {
            get{return codigo;}
            set{codigo = value;}
        }
        protected string? nome;
        public string? Nome
        {
            get{return nome;}
            set{nome = value;}
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {codigo}\tNome: {nome}\t");
        }
    }
}