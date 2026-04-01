using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Banco
    {
        private List<Poupanca> poups;
        public List<Poupanca> Poups
        {
            get
            {
                return this.poups;
            }
            set
            {
                this.poups = value;
            }
        }
        private List<ContaCorrente> contas;
        public List<ContaCorrente> Contas
        {
            get
            {
                return this.contas;
            }
            set
            {
                this.contas = value;
            }
        }
        
        public void AbrirConta(double chequeEspecial)
        {
            contas.Add(new ContaCorrente(chequeEspecial));
        }
        public void AbrirPoupanca()
        {
            poups.Add(new Poupanca());
        }
        public void IniciarBanco()
        {
            contas = new List<ContaCorrente> ();
            poups = new List<Poupanca>();
        }

        ~Banco()
        {
            contas = null;
            poups = null;
            Console.WriteLine("Destrutor do banco chamado");
        }
    }
}