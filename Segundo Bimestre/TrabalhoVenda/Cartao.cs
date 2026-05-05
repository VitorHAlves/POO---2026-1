using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVenda
{
    public class Cartao : Pagamento
    {
        public string? DadosTransacao { get; set; }
        public int ResultadoTransacao { get; set; }

        public Cartao(string? data,double total, string? dadosTransacao,int resultadoTransacao) : base(data,total)
        {
            DadosTransacao = dadosTransacao;
            ResultadoTransacao = resultadoTransacao;
        }
        public override string Descricao()
        {
            return $"Cartão | Dados: {DadosTransacao} | Resultado: {ResultadoTransacao}";
        }
    }
}