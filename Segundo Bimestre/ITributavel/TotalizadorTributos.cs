using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITributavel
{
    public class TotalizadorTributos
    {
        public double Total { get; private set; }

        public void Adiciona(Itributavel t)
        {
            this.Total += t.CalculaTributos();
        }
    }
}