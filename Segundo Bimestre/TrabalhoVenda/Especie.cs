using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVenda
{
    public class Especie : Pagamento
    {
        public double Quantia { get; set; }
        public Especie(string? data, double total, double quantia) : base(data,total)
        {
            Quantia = quantia;
        }
        private double troco;
        public double Troco
        {
            get
            {
                return Quantia - Total;
            }
        }
        public override string Descricao()
        {
            return $"Espécie | Quantia: {Quantia:c} | Troco: {Troco:c}";
        }
    }
}