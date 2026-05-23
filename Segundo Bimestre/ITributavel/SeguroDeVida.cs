using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITributavel
{
    public class SeguroDeVida : Itributavel
    {
        public double ValorSeguro { get; set; }
        public double CalculaTributos()
        {
            return 75;
        }
    }
}