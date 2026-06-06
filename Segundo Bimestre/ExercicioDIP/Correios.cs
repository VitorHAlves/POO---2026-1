using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioDIP
{
    public class Correios : ICorreios
    {
        public void EnviaPorSedex10(NotaFiscal nf)
        {
            Console.WriteLine($"Enviando a Nota fiscal {nf.Numero} via Sedex 10");
        }
        public void EnviaPorSedexComum(NotaFiscal nf)
        {
            Console.WriteLine("Enviando a Nota Fiscal {nf.Numero} via Sedex Comum");
        }
    }
}