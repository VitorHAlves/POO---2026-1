using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Vendedor
    {
        private double comissao;
        public double Comissao
        {
            set
            {
                this.comissao = value;
            }
            get
            {
                return this.comissao;
            }
        }
        public void CalcularComissao(double valorVendido)
        {
            Comissao += valorVendido * 0.02;
        }

        public void MostrarAtributos()
        {
         Console.WriteLine($"Comissão: {this.Comissao}");   
        }   
    }
}