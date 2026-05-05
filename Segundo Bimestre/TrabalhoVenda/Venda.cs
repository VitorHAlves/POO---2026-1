using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVenda
{
    public class Venda
    {
        public string? Data { get; set; }
        public double Total { get; set; }

        public List<ItemVenda> Itens { get; set; }
        public Pagamento FormaPagamento { get; set; }

        public Venda(string? data)
        {
            Data = data;
            Itens = new List<ItemVenda>();
        }
        public void AdicionarItem(ItemVenda item)
        {
            Itens.Add(item);
            AtualizarTotal();
        }
        public void AtualizarTotal()
        {
            double acumulador = 0;

            foreach (var item in this.Itens)
            {
                acumulador += item.Subtotal;
            }
            Total = acumulador;
        }
    }
}