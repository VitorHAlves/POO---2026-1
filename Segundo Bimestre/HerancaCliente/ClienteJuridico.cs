using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class ClienteJuridico : Cliente
    {
        private int cnpj;
        public int Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public ClienteJuridico(int codigo, string? nome, int cnpj) : base(codigo,nome)
        {
            Cnpj = cnpj;
        }
        public ClienteJuridico()
        {//construtor padrão

        }
        public void MostrarAtributos()
        {   //  A palavra base chama o método mostraratributos()
            // da superclasse
            base.MostrarAtributos();
            Console.WriteLine("CNPJ: " + Cnpj);
        }
    }
}