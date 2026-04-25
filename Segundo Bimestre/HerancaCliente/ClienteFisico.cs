using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    //           classe derivada : classe base
    public class ClienteFisico : Cliente
    {
        private int rg;
        public ClienteFisico(int codigo, string? nome, int rg) : base(codigo,nome)
        {
            Rg = rg;
        }
        public ClienteFisico()
        {//construtor padrão

        }
        public int Rg       
        {
            get { return rg; }
            set { rg = value; }
        }
        public override void MostrarAtributos()
        {   //  A palavra base chama o método mostraratributos()
            // da superclasse
            base.MostrarAtributos();
            Console.WriteLine("RG: " + rg);
        }
    }
}