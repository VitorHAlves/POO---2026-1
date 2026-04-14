using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Comprador
    {
        private double verba;
        public double Verba
        {
            set
            {
                if(value >= 0)
                    this.verba = value;
                else
                    Console.WriteLine("Verba inválida!");
            }
            get
            {
                return verba;
            }
        }
        public Comprador(double Valor)
        {
            Verba = Valor;
        }
        public void DiminuirVerba(double ValorVend)
        {
            Verba = Verba - ValorVend;
        }
        public void MostrarAtributos()
        {
         Console.WriteLine($"Verba: {this.Verba}");   
        }   
    }
}