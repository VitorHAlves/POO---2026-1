using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioDIP
{
    public class DespachadorDeNotasFiscais
    {
        private INFDao dao;
        private ICalculadorDeImposto impostos;
        private EntregadorDeNFs entregador;
        public DespachadorDeNotasFiscais(INFDao dao, ICalculadorDeImposto impostos, EntregadorDeNFs entregador)
        {
            this.dao = dao;
            this.impostos = impostos;
            this.entregador = entregador;
        }
        public void Processa(NotaFiscal nf)
        {
            double imposto = impostos.Para(nf);
            nf.DefinirImposto(imposto);
            entregador.Entregar(nf);
            dao.Persiste(nf);
        }
    }
}