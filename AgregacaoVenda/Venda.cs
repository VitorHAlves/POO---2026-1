using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        private Comprador comp;
        private Vendedor vend;
        private List<Produto> vetProd;

        public Vendedor Vend
        {
            set
            {
                this.vend = value;
            }
            get
            {
                return this.vend;
            }
        }

        public List<Produto> VetProd//encapsulamento 
        {
            set
            {
                this.vetProd = value;
            }
            get
            {
                return this.vetProd;
            }
        }

        public Comprador Comp
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
        public void MostrarAtributos()
        {
         Console.WriteLine($"Comprador: {this.Comp} \tVendedor: {this.Vend} \t Produto {this.vetProd}");   
        }   
    }
}