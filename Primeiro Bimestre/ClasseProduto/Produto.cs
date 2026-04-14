using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        public int codigo;
        public string nome;
        public double precoUnitario;
        public int qtde;
        public double total;


        public void MostrarAtributos()
        {
         Console.WriteLine($"Código: {codigo} \tNome: {nome} \tprecoUnitario: {precoUnitario} \tQuantidade: {qtde}");   
        }
        public void EstoqueMinimo()
        {
            if (qtde < 3)
                Console.WriteLine($"Estoque mínimo! Produto '{nome}' tem apenas {qtde} unidade(s).");
            else
                Console.WriteLine($"Estoque ok! ainda tem {qtde}");
        }
    }
}