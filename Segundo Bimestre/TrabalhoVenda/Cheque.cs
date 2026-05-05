using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVenda
{
    public class Cheque : Pagamento
    {
        public long Numero { get; set; }
        public string? DataDeposito { get; set; }
        public int Situacao { get; set; }

        public Cheque(string? data, double total, long numero, string? dataDeposito,int situacao) : base(data,total)
        {
            Numero = numero;
            DataDeposito = dataDeposito;
            Situacao = situacao;
        }

        public override string Descricao()
        {
            return $"Cheque Número {Numero} | Depósito: {DataDeposito} | Situação: {Situacao}";
        }
    }
}