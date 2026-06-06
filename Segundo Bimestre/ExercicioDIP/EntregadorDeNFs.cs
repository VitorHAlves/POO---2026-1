using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioDIP
{
    public class EntregadorDeNFs
    {
        private ICorreios correios;
        private ILeiDeEntrega lei;
        
        public EntregadorDeNFs(ICorreios correios, ILeiDeEntrega lei)
        {
            this.correios = correios;
            this.lei = lei;
        }
        public void Entregar(NotaFiscal nf)
        {
            if (lei.DeveEntregarUrgente(nf))
                correios.EnviaPorSedex10(nf);
            else
                correios.EnviaPorSedexComum(nf);
        }
    }
}