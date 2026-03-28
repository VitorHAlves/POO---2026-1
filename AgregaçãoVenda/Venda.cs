using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregaçãoVenda
{
    public class Venda
    {
        private Comprador comp;
        private Vendedor vend;
        private Produto vetProd;

        public Comprador comp
        {
            set
            {
                this.comp = value;
            }
            get
            {
                return this.comp;
            }
        }
    }
}