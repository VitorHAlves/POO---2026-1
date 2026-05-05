using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVenda
{
    public class ItemVenda
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public Produto Produto { get; set; }

        public ItemVenda(Produto produto,int quantidade)
        {
            Produto = produto;
            Preco = produto.Preco;
            Quantidade = quantidade;    
        }
        public double Subtotal
        {
            get
            {
                if (Quantidade >= 50)
                    return Preco * Quantidade * 0.80;

                return Preco * Quantidade;
            }
        }
        
    }
}