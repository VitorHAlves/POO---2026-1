using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioDIP
{
    public interface ILeiDeEntrega
    {
        bool DeveEntregarUrgente(NotaFiscal nf);
    }
}