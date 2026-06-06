using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioDIP
{
    public class CalculadorDeImposto : ICalculadorDeImposto
    {
        public double Para(NotaFiscal nf)
        {
            return nf.Valor * 0.1;
        }
    }
}