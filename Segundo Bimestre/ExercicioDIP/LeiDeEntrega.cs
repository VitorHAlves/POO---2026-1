using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioDIP
{
    public class LeiDeEntrega : ILeiDeEntrega
    {
        public bool DeveEntregarUrgente(NotaFiscal nf)
        {
            return nf.Valor > 500;
        }
    }
}