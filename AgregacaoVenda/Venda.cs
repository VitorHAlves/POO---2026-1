using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public Venda(Comprador comprad,Vendedor vendedor,List<Produto>vetorProd)
        {
            this.Comp = comprad;
            this.Vend = vendedor;
            this.VetProd = vetorProd;
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
        double totalVenda1 = 0;
        foreach (var i in VetProd)
        {
            totalVenda1 += i.Preco;
        }
        Console.WriteLine($"Verba inicial: {comp.Verba}");
        comp.DiminuirVerba(totalVenda1);
        vend.CalcularComissao(totalVenda1);
        
        Console.WriteLine("Relatório da venda ");
        Console.WriteLine($"Produtos: {}");
        Console.WriteLine($"Total da Venda: {totalVenda1}");
        Console.WriteLine($"Verba restante: {comp.Verba}");
        Console.WriteLine($"Comissão do vendedor: {vend.Comissao}");
        }   
    }
}