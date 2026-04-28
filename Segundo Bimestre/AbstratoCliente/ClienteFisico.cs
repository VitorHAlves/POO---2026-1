using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public class ClienteFisico : Cliente
    {
        public int Rg { get; set; }

        public ClienteFisico(int codigo, string? nome, int idade,int rg) : base(codigo,nome,idade)
        {
            Rg = rg;
        }

        public override void VerificaIdade()
        {
            if (Idade < 50)
            {
                Console.WriteLine("CF - Idade Validada!");
            }
        }
    }
}