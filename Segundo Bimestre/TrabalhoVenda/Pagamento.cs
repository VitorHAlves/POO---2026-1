using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVenda
{
    public abstract class Pagamento
    {
        protected string? data;
        protected double total;
        public Pagamento(string? data,double total)
        {
            Data = data;
            Total = total;
        }
        public string? Data
        {
            get { return data; }
            set { data = value; }
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        public abstract string Descricao();//polimorfismo
        
        
    }
}